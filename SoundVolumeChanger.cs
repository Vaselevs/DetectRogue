using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundVolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField] private float _soundChangingSpeed;
    private float _currentVolume;
    private float _maxVolume;
    private float _minVolume;

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
        _maxVolume = 1;
        _minVolume = 0;
    }


    public void SoundUp()
    {
        _sound.volume = Mathf.MoveTowards(_currentVolume, _maxVolume, _soundChangingSpeed * Time.deltaTime);
    }

    public void SoundDown()
    {
        _sound.volume = Mathf.MoveTowards(_currentVolume, _minVolume, _soundChangingSpeed * Time.deltaTime);
    }

}
