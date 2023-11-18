using System;
using System.IO;
using UnityEngine;

public static class AudioToWav
{
    public static byte[] ConvertToByteArray(AudioClip audioClip)
    {
        // Get audio data from the AudioClip
        float[] samples = new float[audioClip.samples];
        audioClip.GetData(samples, 0);

        // Create a new MemoryStream to store the WAV data
        using (MemoryStream stream = new MemoryStream())
        using (BinaryWriter writer = new BinaryWriter(stream))
        {
            // Write WAV header
            writer.Write(new char[4] { 'R', 'I', 'F', 'F' });
            writer.Write(36 + samples.Length * 2); // File size
            writer.Write(new char[4] { 'W', 'A', 'V', 'E' });

            // Write format chunk
            writer.Write(new char[4] { 'f', 'm', 't', ' ' });
            writer.Write(16); // Chunk size
            writer.Write((ushort)1); // Audio format (PCM)
            writer.Write((ushort)audioClip.channels); // Number of channels
            writer.Write(audioClip.frequency); // Sample rate
            writer.Write(audioClip.frequency * audioClip.channels * 2); // Byte rate
            writer.Write((ushort)(audioClip.channels * 2)); // Block align
            writer.Write((ushort)16); // Bits per sample

            // Write data chunk
            writer.Write(new char[4] { 'd', 'a', 't', 'a' });
            writer.Write(samples.Length * 2); // Data size

            // Write audio data as 16-bit PCM
            foreach (float sample in samples)
            {
                writer.Write((short)(sample * 32767.0f));
            }

            // Get the WAV data as a byte array
            return stream.ToArray();
        }
    }
}
