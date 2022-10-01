using TMPro;
using UnityEngine;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;

    public void UpdateLive(int lives)
    {
        livesText.text = $"Lives: \n{lives}";
    }
}
