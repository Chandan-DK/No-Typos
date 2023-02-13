using TMPro;
using UnityEngine;

public class DisplayScoreScript : MonoBehaviour
{
    [HideInInspector]
    public int score;

    [SerializeField]
    private TextMeshProUGUI scoreText;

    public void increaseScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
}
