using TMPro;
using UnityEngine;

public class DisplayScoreAndTimeSurvivedScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeText;

    [SerializeField]
    private TextMeshProUGUI playerScoreText;

    [SerializeField]
    private TimeScriptableObject timeScriptableObject;

    void Start()
    {
        DisplayStats();
    }

    private void DisplayStats()
    {
        timeText.text = $"{timeScriptableObject.min} min {(int)timeScriptableObject.sec} sec";
        playerScoreText.text = $"{timeScriptableObject.score}";
    }
}
