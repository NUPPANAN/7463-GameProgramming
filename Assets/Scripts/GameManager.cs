using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    // Simple singleton script. This is the easiest way to create and understand a singleton script.
    [SerializeField] public int pLives = 3;
    [SerializeField] private Transform livesT;
    [SerializeField] private LiveDisplay livesDisplay;
    


    private void Awake()
    {
        var numGameManager = FindObjectsOfType<GameManager>().Length;

        if (numGameManager > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        UpdateLives();
    }

    private void Update()
    {
        if (pLives <= 0)
        {
            Destroy(gameObject);
            LoadScene(0);
        }
        if (GetCurrentBuildIndex() == 0)
        {
            livesT.gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            livesT.gameObject.SetActive(true);
        }
    }

    public void ProcessPlayerDeath()
    {
        LoadScene(GetCurrentBuildIndex());
        UpdateLives();
    }

    public void LoadNextLevel()
    {
        var nextSceneIndex = GetCurrentBuildIndex() + 1;
        
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        UpdateLives();
        LoadScene(nextSceneIndex);
        
    }

    public int GetCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadScene(int buildindex)
    {
       
        SceneManager.LoadScene(buildindex);
        DOTween.KillAll();
        UpdateLives();
    }

    public void DownLives()
    {
        pLives -= 1;
        UpdateLives();
    }
    public void UpdateLives()
    {
        livesDisplay.UpdateLivesScore(pLives);
    }
}
