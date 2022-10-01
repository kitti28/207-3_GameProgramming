using UnityEngine;
using TMPro;

public class LivesScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;

    public void UpdateLives(int lives)
    {
        livesText.text = $"Lives: {lives}";
    }
}
