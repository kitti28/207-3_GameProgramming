using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuControler: MonoBehaviour
{
    public void playGame() 
    {
        SceneManager.LoadScene("Level 1");
    }


    //public void exitGame()
}