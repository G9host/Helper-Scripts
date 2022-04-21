﻿using UnityEngine;

public class SavedData : MonoBehaviour
{
    public const string highScore = "HighScore";

    public const string pictoHG = "PictoHG";
    public const string brandHG = "brandHG";
    public const string iqHighScore = "IQHG";
    public const string countryHG = "countryHG";
    public const string movieHighScore = "MovieHG";
    public const string oldVsNewHighScore = "OldVsNewHG";
    public const string colorGameHighScore = "ColorGameHG";
    public const string stackSwitchHighScore = "StackSwitchHG";

    public const string mbTotalDollars = "MBTotalDollars"; 

    public const string playerLevelType = "PlayerLevelType";
    
    public const string savedScene = "SavedScene";
    public const string levelNumber = "LevelNumber";

    public const string bpr_ln = "BalloonPopRaceLevelNumber";
    public const string dol_ln = "DrawOneLineLevelNumber";
    public const string ss_ln = "StackSwipeLevelNumber";
    public const string mb_ln = "MemoryBetLevelNumber";
    public const string cr_ln = "ColorRunLevelNumber";

    public const string audioState = "SoundState";
    public const string hepaticState = "HapticState";


    // Get Value // Get//

    public int GetMBTotalDollars()
    {
        return PlayerPrefs.GetInt(mbTotalDollars, 500);
    }

    public int GetPlayerLevelType()
    {
        return PlayerPrefs.GetInt(playerLevelType, 0);
    }
    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(highScore,0);
    }
    public int GetMovieHighScore()
    {
        return PlayerPrefs.GetInt(movieHighScore, 0);
    }
    public int GetColorGameHighScore()
    {
        return PlayerPrefs.GetInt(colorGameHighScore, 0);
    }
    public int GetOldVsNewHighScore()
    {
        return PlayerPrefs.GetInt(oldVsNewHighScore, 0);
    }
    public int GetIQHighScore()
    {
        return PlayerPrefs.GetInt(iqHighScore, 0);
    }
    public int GetPictoHighScore()
    {
        return PlayerPrefs.GetInt(pictoHG, 0);
    }

    public int GetBrandHighScore()
    {
        return PlayerPrefs.GetInt(brandHG, 0);
    }

    public int GetCountryHighScore()
    {
        return PlayerPrefs.GetInt(countryHG, 0);
    }

    public int GetStackSwitchHighScore()
    {
        return PlayerPrefs.GetInt(stackSwitchHighScore, 0);
    }

    
    public int GetLevelNumber()
    {
        return PlayerPrefs.GetInt(levelNumber, 1);
    }

    public int GetBPRLevelNumber()
    {
        return PlayerPrefs.GetInt(bpr_ln, 1);
    }
    public int GetMBLevelNumber()
    {
        return PlayerPrefs.GetInt(mb_ln, 1);
    }
    public int GetDOLLevelNumber()
    {
        return PlayerPrefs.GetInt(dol_ln, 1);
    }
    public int GetSSLevelNumber()
    {
        return PlayerPrefs.GetInt(ss_ln, 1);
    }
    public int GetCRLevelNumber()
    {
        return PlayerPrefs.GetInt(cr_ln, 1);
    }


    public string GetSavedScene()
    {
        return PlayerPrefs.GetString(savedScene, "1");
    }

    public int GetSavedSceneByInt()
    {
        return PlayerPrefs.GetInt(savedScene, 1);
    }

    public string GetSoundState()
    {
        return PlayerPrefs.GetString(audioState, "On");
    }

    public string GetHepaticState()
    {
        return PlayerPrefs.GetString(hepaticState, "On");
    }


    // Set Value // Set//

    public void SetMBTotalDollars(int val)
    {
        PlayerPrefs.SetInt(mbTotalDollars, val);
    }

    public void SetPlayerLevelType(int val)
    {
       PlayerPrefs.SetInt(playerLevelType, val);
    }
    public void SetHighScore(int val)
    {
        PlayerPrefs.SetInt(highScore, val);
    }
    public void SetMovieHighScore(int val)
    {
         PlayerPrefs.SetInt(movieHighScore, val);
    }
    public void SetColorGameHighScore(int val)
    {
         PlayerPrefs.SetInt(colorGameHighScore, val);
    }
    public void SetOldVsNewHighScore(int val)
    {
         PlayerPrefs.SetInt(oldVsNewHighScore, val);
    }
    public void SetIQHighScore(int val)
    {
         PlayerPrefs.SetInt(iqHighScore, val);
    }
    public void SetPictoHighScore(int val)
    {
         PlayerPrefs.SetInt(pictoHG, val);
    }

    public void SetBrandHighScore(int val)
    {
         PlayerPrefs.SetInt(brandHG, val);
    }

    public void SetCountryHighScore(int val)
    {
         PlayerPrefs.SetInt(countryHG, val);
    }
    public void SetStackSwitchHighScore(int val)
    {
        PlayerPrefs.SetInt(stackSwitchHighScore, val);
    }

    public void SetSavedScene(string val)
    {
        PlayerPrefs.SetString(savedScene, val);
    }
    public void SetSavedSceneByInt(int val)
    {
        PlayerPrefs.SetInt(savedScene, val);
    }

    public void SetLevelNumber(int val)
    {
        PlayerPrefs.SetInt(levelNumber, val);
    }

    public void SetBPRLevelNumber(int val)
    {
         PlayerPrefs.SetInt(bpr_ln, val);
    }
    public void SetMBLevelNumber(int val)
    {
         PlayerPrefs.SetInt(mb_ln, val);
    }
    public void SetDOLLevelNumber(int val)
    {
         PlayerPrefs.SetInt(dol_ln, val);
    }
    public void SetSSLevelNumber(int val)
    {
         PlayerPrefs.SetInt(ss_ln, val);
    }
    public void SetCRLevelNumber(int val)
    {
         PlayerPrefs.SetInt(cr_ln, val);
    }

    public void SetSoundState(string state)
    {
        PlayerPrefs.SetString(audioState, state);
    }

    public void SetHepaticState(string state)
    {
        PlayerPrefs.SetString(hepaticState, state);
    }

    

    public void SaveData()
    {
        PlayerPrefs.Save();
    }
}