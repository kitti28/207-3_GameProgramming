using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class GameManager : MonoBehaviour
{
    [SerializeField] private LivesScore livesScore;
    [SerializeField] private int lives = 3;

    // Simple singleton script. This is the easiest way to create and understand a singleton script.
    private void Start()
    {
        UpdateLives();
    }
    
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

    public void ProcessPlayerDeath()
    {
        SceneManager.LoadScene(GetCurrentBuildIndex());
        DOTween.KillAll();

        if (lives == 0)
        {
            SceneManager.LoadScene(0);
            lives += 3;
            livesScore.UpdateLives(lives);
        }
        else
        {
            SceneManager.LoadScene(GetCurrentBuildIndex());
        }
    }

    public void LoadNextLevel()
    {
        var nextSceneIndex = GetCurrentBuildIndex() + 1;
        
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
            /*if (lives == 1)
            {
                lives += 2;
            }
            else if (lives == 2)
            {
                lives += 1;
            }
            else if (lives == 3)
            {
                lives = 3;
            }
            livesScore.UpdateLives(3);*/
        }
        
        SceneManager.LoadScene(nextSceneIndex);
        DOTween.KillAll();
        
    }

    private int GetCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public void Dead()
    {
        lives -=1;
        UpdateLives();
    }

    private void UpdateLives()
    {
        livesScore.UpdateLives(lives);
    }
    
}
