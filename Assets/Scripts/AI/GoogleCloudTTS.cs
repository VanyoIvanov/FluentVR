using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class GoogleCloudTTS : MonoBehaviour
{
    public static GoogleCloudTTS Instance;

    private string apiKey = "AIzaSyAA6D7PlQe3ERp4TzMQCgVJ_GXIfrcOqlw";
    private const string postSynthURL = "https://texttospeech.googleapis.com/v1beta1/text:synthesize";
    private const double sampleRate = 24000;
    public double voicePitch;
    public double voiceRate;
    public string langCode = "es-ES";
    public string voiceName = "es-ES-Neural2-A";
    public SsmlVoiceGender voiceGender = SsmlVoiceGender.MALE;

    public AudioSource audioSource;

    private void SynthSuccess(string audioData)
    {
        var synthOutput = JsonConvert.DeserializeObject<SynthOutput>(audioData);
        AudioClip loadClip = GetClipFromBase64(synthOutput.audioContent);
        audioSource.clip = loadClip;
        audioSource.time = 0.1f;
        audioSource.Play();
    }

    public AudioClip GetClipFromBase64(string Base64data)
    {
        byte[] data = Convert.FromBase64String(Base64data);
        float[] floatData = ConvertByteToFloat(data);
        AudioClip newClip = AudioClip.Create("TTS_Clip", floatData.Length,
            BitConverter.ToUInt16(data, 22),
            BitConverter.ToInt32(data, 24), false);
        newClip.SetData(floatData, 44);
        return newClip;
    }

    private float[] ConvertByteToFloat(byte[] array)
    {
        float[] floatArr = new float[(array.Length / 2) - 22];

        for (int i = 0; i < floatArr.Length; i++)
        {
            floatArr[i] = ((float)BitConverter.ToInt16(array, i * 2)) / 32768.0f;
        }

        return floatArr;
    }

    public void Synthesize(string textToSynth)
    {
        StartCoroutine(RequestSynth(textToSynth));
    }

    private IEnumerator RequestSynth(string textToSynth)
{
    SynthObj newRequest = new SynthObj();
    newRequest.input = new SynthInput() { text = textToSynth };
    newRequest.audioConfig = GetAudioConfig();
    newRequest.voice = GetVoiceConfig();

    string requestJson = JsonConvert.SerializeObject(newRequest);
    Debug.Log("Request JSON: " + requestJson);  // Log the request JSON for debugging
    byte[] bytes = Encoding.UTF8.GetBytes(requestJson);

    using (UnityWebRequest www = new UnityWebRequest(postSynthURL + "?key=" + apiKey, "POST"))
    {
        UploadHandlerRaw uploadHandler = new UploadHandlerRaw(bytes);
        uploadHandler.contentType = "application/json";
        www.uploadHandler = uploadHandler;

        www.downloadHandler = new DownloadHandlerBuffer();

        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log("Error: " + www.error);
            Debug.Log("Response: " + www.downloadHandler.text);

            // Handle the specific error in the response
            if (!string.IsNullOrEmpty(www.downloadHandler.text) && www.downloadHandler.text.Contains("error"))
            {
                // Log additional details about the error
                Debug.LogError("Error in API response: " + www.downloadHandler.text);
            }
        }
        else
        {
            SynthSuccess(www.downloadHandler.text);
        }
    }
}

    private AudioConfig GetAudioConfig()
    {
        return new AudioConfig()
        {
            audioEncoding = AudioEncoding.LINEAR16,
            pitch = voicePitch,
            sampleRateHertz = sampleRate,
            speakingRate = voiceRate,
            volumeGainDb = 0.0
        };
    }

    private VoiceConfig GetVoiceConfig()
    {
        return new VoiceConfig()
        {
            languageCode = langCode,
            name = voiceName,
            ssmlGender = voiceGender
        };
    }
}

public enum SsmlVoiceGender
{
	/// <summary>
	/// An unspecified gender.
	/// In VoiceSelectionParams, this means that the client doesn't care which
	/// gender the selected voice will have. In the Voice field of
	/// ListVoicesResponse, this may mean that the voice doesn't fit any of the
	/// other categories in this enum, or that the gender of the voice isn't known.
	/// </summary>
	SSML_VOICE_GENDER_UNSPECIFIED = 0,
	/// <summary>
	/// A male voice.
	/// </summary>
	MALE = 1,
	/// <summary>
	/// A female voice.
	/// </summary>
	FEMALE = 2,
	/// <summary>
	/// A gender-neutral voice.
	/// </summary>
	NEUTRAL = 3,
}

public enum AudioEncoding
{
	/// <summary>
	/// Not specified. Will return result [google.rpc.Code.INVALID_ARGUMENT][].
	/// </summary>
	AUDIO_ENCODING_UNSPECIFIED = 0,
	/// <summary>
	/// Uncompressed 16-bit signed little-endian samples (Linear PCM).
	/// Audio content returned as LINEAR16 also contains a WAV header.
	/// </summary>
	LINEAR16 = 1,
	/// <summary>
	/// MP3 audio.
	/// </summary>
	MP3 = 2,
	/// <summary>
	/// Opus encoded audio wrapped in an ogg container. The result will be a
	/// file which can be played natively on Android, and in browsers (at least
	/// Chrome and Firefox). The quality of the encoding is considerably higher
	/// than MP3 while using approximately the same bitrate.
	/// </summary>
	OGG_OPUS = 3,
}

[Serializable]
public class SynthObj
{
	public SynthInput input;
	public VoiceConfig voice;
	public AudioConfig audioConfig;
}

[Serializable]
public class SynthInput
{
	public string text;
}

[Serializable]
public class SynthOutput
{
	public string audioContent;
}

[Serializable]
public class VoiceConfig
{
	public string languageCode;
	public string name;
	public SsmlVoiceGender ssmlGender;
}

[Serializable]
public class AudioConfig
{

	public AudioEncoding audioEncoding;
	public double speakingRate;
	public double pitch;
	public double volumeGainDb;
	public double sampleRateHertz;
}

[Serializable]
public class Voice
{
	public string[] languageCodes;
	public string name;
	public SsmlVoiceGender ssmlGender;
	public double naturalSampleRateHertz;
}