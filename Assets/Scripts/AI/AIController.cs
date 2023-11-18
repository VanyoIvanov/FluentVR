using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;
using Meta.WitAi.TTS.Utilities;
using System;

namespace OpenAI
{
    public class AIController : MonoBehaviour
    {
        private OpenAIApi _openai = new OpenAIApi();
        private List<ChatMessage> _messages = new List<ChatMessage>();
        private string _npcResponse = "";
        private bool isRecording = false;
        public string prompt = "Act as a random stranger in a chat room and reply to the questions. Don't break character. Don't ever mention that you are an AI model.";
        public TTSSpeaker speaker;
        public SpeechToText speechToText;

        public Transform player;
        public float interactionDistance = 3.0f;

        private void Start()
    {
        // Iterate through all the button names defined in the InputManager.
        foreach (KeyCode keyCode in System.Enum.GetValues(typeof(KeyCode)))
        {
            // Check if the button corresponds to an Oculus Rift S controller button.
            if (keyCode.ToString().StartsWith("JoystickButton"))
            {
                Debug.Log("Detected Oculus Button: " + keyCode.ToString());
            }
        }
    }

        private async void Update()
        {
            if (player != null && !isRecording)
            {
                float distance = Vector3.Distance(player.position, transform.position);

                if (distance <= interactionDistance)
                {
                    // Player is within interaction distance, initiate conversation here.
                    // You can call the SendReply method or any other conversation logic here.
                    if (Input.GetButtonDown("JoystickButton2"))
                    {
                        isRecording = true;
                        // speechToText.StartRecording();
                        Console.WriteLine("Recording!");
                    }

                    if (Input.GetButtonUp("JoystickButton2"))
                    {
                        isRecording = false;
                        Console.WriteLine("Stop Recording!");
                        // string textResult = await speechToText.StopRecording();
                        // await SendReply(textResult);
                    }
                }
            }
        }

        public async Task SendReply(string userMessage)
        {
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

                speaker.Speak(_npcResponse);
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
            }
        }
    }
}
