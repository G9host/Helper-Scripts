using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DDZ
{
    public class GameEssentials : Singleton<GameEssentials>
    {
        public static string remoteConfigVal = "0";

        public SavedData sd;
        public SceneLoader sl;
        public SoundHapticManager shm;

        void Start()
        {
            //GameObject.Find("EventSystem").SetActive(false);
        }

        public void PrintOut(string val)
        {
            print(val);
        }

    }
}

