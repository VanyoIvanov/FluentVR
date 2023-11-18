using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

namespace OpenAI
{
    public class SpeechToText : MonoBehaviour
    {
        private readonly int duration = 10;
        private AudioClip clip;
        private float time;
        private OpenAIApi openai = new OpenAIApi();

        // private void Update()
        // {
        //     // Replace 'ButtonName' with the actual button name for the Oculus controller
        //     if (Input.GetButtonDown("ButtonName"))
        //     {
        //         StartRecording();
        //     }

        //     if (Input.GetButtonUp("ButtonName"))
        //     {
        //         StopRecording();
        //     }

        //     if (isRecording)
        //     {
        //         time += Time.deltaTime;
        //     }
        // }

        public void StartRecording()
        {
            clip = Microphone.Start(null, false, duration, 44100); // Using the default microphone
            time = 0; // Reset recording time
        }

        public async Task<string> StopRecording()
        {
            Microphone.End(null); // Stopping the microphone

            byte[] data = AudioToWav.ConvertToByteArray(clip);
            var req = new CreateAudioTranscriptionsRequest
            {
                FileData = new FileData() { Data = data, Name = "audio.wav" },
                Model = "whisper-1",
                Language = "en"
            };
            var res = await openai.CreateAudioTranscription(req);

            return res.Text;
        }
    }
}
