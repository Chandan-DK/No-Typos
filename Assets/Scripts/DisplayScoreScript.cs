using TMPro;
using UnityEngine;

public class DisplayScoreScript : MonoBehaviour
{
    [HideInInspector]
    public int score;

    [SerializeField]
    private TextMeshProUGUI _scoreText;

    public void DisplayScore()
    {
        score++;
        _scoreText.text = "Score: " + score.ToString();
    }
}
