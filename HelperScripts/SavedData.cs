using UnityEngine;

public class SavedData : MonoBehaviour
{
    public const string highScore = "HighScore";

    public const string savedScene = "SavedScene";
    public const string levelNumber = "LevelNumber";

    public const string audioState = "SoundState";
    public const string hepaticState = "HapticState";


    // Get Value // Get//
    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(highScore,0);
    }
    
    public int GetLevelNumber()
    {
        return PlayerPrefs.GetInt(levelNumber, 1);
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
    public void SetHighScore(int val)
    {
        PlayerPrefs.SetInt(highScore, val);
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
