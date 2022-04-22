using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHapticManager : MonoBehaviour
{
    public Sounds[] sounds;

    GameEssentials gameEssentials;

    private void Awake()
    {
        Vibration.Init();
        SetupAudioSources();
    }

    void Start()
    {
        gameEssentials = GameEssentials.instance;
    }

    void SetupAudioSources()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            sounds[i].GetRead( gameObject.AddComponent<AudioSource>());
        }
    }

    public void PlayAudio(string SoundName)
    {
        if (gameEssentials.sd.GetSoundState().Equals("Off"))
            return;

        Sounds s = Array.Find(sounds, sound => sound.name == SoundName);
        s.Play();
    }

    public void Vibrate(long MilliSecs)
    {
        if (gameEssentials.sd.GetHepaticState().Equals("Off"))
            return;

        if (Application.platform == RuntimePlatform.WindowsEditor)
            gameEssentials.PrintOut("Vibrating");
        else 
            Vibration.Vibrate(MilliSecs);
    }

   

    public void Audio_On()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            sounds[i].AudioSourceState(true);
        }
    }

    public void Audio_Off()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            sounds[i].AudioSourceState(false);
        }
    }

}
