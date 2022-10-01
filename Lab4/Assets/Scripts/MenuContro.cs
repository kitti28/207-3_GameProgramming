using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.InputSystem;
public class MenuContro : MonoBehaviour
{
    public void playGame() 
    {
        SceneManager.LoadScene("Level 1");
    }

    private void OnQUIT(InputValue value)
    {
        if (!value.isPressed) return;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Escape was pressed");
        }
        else
        {
            Debug.Log("Start");
            playGame();
        }
    }
}
