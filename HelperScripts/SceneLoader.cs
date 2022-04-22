using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int GetTotalScenesInBuildSettings()
    {
        return SceneManager.sceneCountInBuildSettings;
    }
    public int GetCurrentSceneByBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
    public string GetCurrentSceneByName()
    {
        return SceneManager.GetActiveScene().name;
    }
    public string GetNextSceneByName()
    {
        return (SceneManager.GetActiveScene().buildIndex + 1).ToString();
    }

    public int GetNextSceneByBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex + 1;
    }

    public int GetRandomSceneByBuildIndex()
    {
        return Random.Range(1, GetTotalScenesInBuildSettings() - 1);
    }

    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    } 
    
    public void LoadSceneByInt(int SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void LoadSceneAsynByIndex(int SceneIndex)
    {
        SceneManager.LoadSceneAsync(SceneIndex);
    }

    public void LoadSceneAsynByName(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName);
    }
    

    public void LoadSameScene()
    {
        SceneManager.LoadScene(GetCurrentSceneByName());
    }
}
