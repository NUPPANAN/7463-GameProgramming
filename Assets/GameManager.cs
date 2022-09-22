using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        var numGameManagers = FindObjectsOfType<GameManager>().Length;

        if (numGameManagers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public void ProcessPlayerDeath()
    {
        RestartScene();
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(GetCurrentSceneIndex());
    }

    public void LoadNextScene()
    {
        var nextSceneBuildIndex = GetCurrentSceneIndex() + 1;
        if (nextSceneBuildIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneBuildIndex = 0;
        }

        SceneManager.LoadScene(nextSceneBuildIndex);
    }

    private int GetCurrentSceneIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}