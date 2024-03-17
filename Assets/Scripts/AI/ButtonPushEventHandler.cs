using UnityEngine;

namespace OpenAI
{
    public class ButtonPushEventHandler : MonoBehaviour
    {
        public string userInput = "";
        public AIGrammerQuiz aiQuiz;

        public async void OnButtonPress()
        {
            aiQuiz.HandleButtonPress(userInput);
        }
    }

}
