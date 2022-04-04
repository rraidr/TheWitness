using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    FMOD.Studio.EventInstance SFXVolumeEvent;

    FMOD.Studio.Bus Background;
    FMOD.Studio.Bus SFX;
    FMOD.Studio.Bus Master;
    float BackgroundVolume = 1f;
    float SFXVolume = 1f;
    float MasterVolume = 1.0f;

    public void Awake()
    {
        Background = FMODUnity.RuntimeManager.GetBus("bus:/Master/Background");
        SFX = FMODUnity.RuntimeManager.GetBus("bus:/Master/SFX");
        Master= FMODUnity.RuntimeManager.GetBus("bus:/Master");
    }

    public void Update()
    {
        Background.setVolume(BackgroundVolume);
        SFX.setVolume(SFXVolume);
        Master.setVolume(MasterVolume);
    }

    public void MasterVolumeLevel(float newMasterVolume)
    {
        MasterVolume = newMasterVolume;
    }

    public void BackgroundVolumeLevel(float newBackgroundVolume)
    {
        BackgroundVolume = newBackgroundVolume;
    }
    public void SFXVolumeLevel(float newSFXVolume)
    {
        SFXVolume = newSFXVolume;

    }

}
