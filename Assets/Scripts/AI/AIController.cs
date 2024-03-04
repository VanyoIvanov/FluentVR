using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;
using Meta.WitAi.TTS.Utilities;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;
using System;
using TMPro;

namespace OpenAI
{
    public class AIController : MonoBehaviour
    {
        private OpenAIApi _openai = new OpenAIApi();
        private List<ChatMessage> _messages = new List<ChatMessage>();
        public string npcResponse = "";
        private bool isRecording = false;
        public string npcName = ""; 
        public TTSSpeaker speaker;
        public SpeechToText speechToText;
        public Transform player;
        public float interactionDistance = 3.0f;
        private InputData _inputData;
        private GameObject textResponseObject;

       private void Awake()
        {
            textResponseObject = GameObject.Find("TextResponse");
        }

        private void Start()
        {
            _inputData = GetComponent<InputData>();
        }

      private async void Update()
{
    var names = Input.GetJoystickNames();
    Console.WriteLine(names);

    if (player != null)
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= interactionDistance)
        {
            _inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool Abutton);
            _inputData._rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool Bbutton);

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
        else
        {
            //textResponseObject.gameObject.SetActive(false);
        }
    }
}
        public async Task SendReply(string userMessage)
        {
            string prompt = $"Act as a {npcName} in a chat room and reply to the questions. Don't break character. Don't ever mention that you are an AI model. Keep your replies short, no more than one or two sentences. Give the response in english and in bulgarian sepparated with blank line";
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
                npcResponse = message.Content;
                var letterByLetterAnimators = FindObjectsOfType<LetterByLetterAnimator>();
                 foreach (var animator in letterByLetterAnimators)
                    {
                        Debug.Log(npcName);
                        Debug.Log(animator.npcName);
                        if (animator.npcName == npcName)
                        {
                            animator.AnimateText(npcResponse);
                        }
                    }
           

                Debug.Log(npcName +": " +  npcResponse);

                speaker.Speak(npcResponse);
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
            }
        }
    }
}