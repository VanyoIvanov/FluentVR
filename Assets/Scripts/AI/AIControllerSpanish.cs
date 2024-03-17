using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;
using Meta.WitAi.TTS.Utilities;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using System;

namespace OpenAI
{
    public class AIControllerSpanish : MonoBehaviour
    {
        private OpenAIApi _openai = new OpenAIApi();
        private List<ChatMessage> _messages = new List<ChatMessage>();
        private string _npcResponse = "";
        private bool isRecording = false;
        public string npcName = "";
        public SpeechToText speechToText;
        public GoogleCloudTTS GoogleCloudTTS;
        public Transform player;
        public float interactionDistance = 3.0f;
        private InputData _inputData;

        private void Start()
        {
            _inputData = GetComponent<InputData>();
        }

        private async void Update()
        {           
            if (player != null)
            {
                float distance = Vector3.Distance(player.position, transform.position);

                if (distance <= interactionDistance)
                {
                    _inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool Abutton);
                    _inputData._rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool Bbutton);
                    // Player is within interaction distance, initiate conversation here.
                    if (Abutton == true && !isRecording)
                    {
                        isRecording = true;
                        speechToText.StartRecording();
                        Debug.Log("Start Recording!");
                    }

                    if (Bbutton == true && isRecording)
                    {
                        isRecording = false;
                        Debug.Log("Stop Recording!");
                        string textResult = await speechToText.StopRecording();
                        await SendReply(textResult);
                    }
                }
            }
        }

        public async Task SendReply(string userMessage)
        {
            string prompt = $"Actúa como {npcName} en una sala de chat y responde las preguntas. No rompas el carácter. Nunca menciones que eres un modelo de IA. Mantenga sus respuestas breves, no más de una o dos oraciones en español y en búlgaro.";
            var newMessage = new ChatMessage()
            {
                Role = "user",
                Content = userMessage
            };

            if (_messages.Count == 0)
            {
                newMessage.Content = prompt + "\n" + userMessage;
            }

            _messages.Add(newMessage);

            var completionResponse = await _openai.CreateChatCompletion(new CreateChatCompletionRequest()
            {
                Model = "gpt-3.5-turbo",
                Messages = _messages
            });

            if (completionResponse.Choices != null && completionResponse.Choices.Count > 0)
            {
                var message = completionResponse.Choices[0].Message;
                message.Content = message.Content.Trim();

                _messages.Add(message);
                _npcResponse = message.Content;

                var letterByLetterAnimators = FindObjectsOfType<LetterByLetterAnimator>();
                 foreach (var animator in letterByLetterAnimators)
                    {
                        Debug.Log(npcName);
                        Debug.Log(animator.npcName);
                        if (animator.npcName == npcName)
                        {
                            animator.AnimateText(_npcResponse);
                        }
                    }

                Debug.Log( npcName + ": " + _npcResponse);

                string spanishText = _npcResponse.Split('\n')[0];

                GoogleCloudTTS.Synthesize(spanishText);
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
            }
        }
    }
}
