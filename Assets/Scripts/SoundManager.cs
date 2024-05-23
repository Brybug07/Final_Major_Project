using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider _volumeSlider;

    private void Start()
    {
        if (!PlayerPrefs.HasKey(Constants.musicVolume))
        {
            PlayerPrefs.SetFloat(Constants.musicVolume, 1);
        }

        _volumeSlider.value = DataSaver.GetFloatData(Constants.musicVolume);
    }

    public void ChangeVolume()
    {
        float value = _volumeSlider.value;
        AudioListener.volume = value;
        DataSaver.SetData(Constants.musicVolume, value);
    }
}