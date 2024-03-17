using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;

namespace OpenAI
{
    public class AIGrammerQuiz : MonoBehaviour
    {
        private OpenAIApi _openai = new OpenAIApi();
        public TMP_Text textComponent;

        private List<ChatMessage> _messages = new List<ChatMessage>();
        private string _gptResponse = "";

        async void Start()
        {
            textComponent = GetComponent<TMP_Text>();
            textComponent.text = await SendReply("Generate");
        }

        public async Task<string> SendReply(string userMessage)
        {
            string prompt = $"From now on, you will act as an English language quiz provider. When I say 'Generate,' you will create a simple English grammar question along with three potential answers, each labeled A, B, or C. You will not reveal which answer is correct. After I respond with my choice (A, B, or C), you will tell me if it's correct or incorrect and you will generate a new question.";
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
                _gptResponse = message.Content;

                Debug.Log("NPC Response: " + _gptResponse);

                return _gptResponse;
            }
            else
            {
                Debug.LogWarning("No text was generated from this prompt.");
                return "";
            }
        }

        public async void HandleButtonPress(string userInput)
        {
            // Call SendReply with the button input
            textComponent.text = await SendReply(userInput);
        }
    }
}
