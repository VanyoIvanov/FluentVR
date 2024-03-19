using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    const string VolumeKey = "volume";

    void Start()
    {
        if (!PlayerPrefs.HasKey(VolumeKey))
        {
            PlayerPrefs.SetFloat(VolumeKey, 0.5f);
        }

        LoadVolumePref();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveVolumePref();
    }

    private void LoadVolumePref()
    {
        volumeSlider.value = PlayerPrefs.GetFloat(VolumeKey);
        AudioListener.volume = volumeSlider.value;
    }

    private void SaveVolumePref()
    {
        PlayerPrefs.SetFloat(VolumeKey, volumeSlider.value);
    }
}
