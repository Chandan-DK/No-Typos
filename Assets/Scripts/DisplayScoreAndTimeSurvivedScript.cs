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

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = $"{timeScriptableObject.min} min {(int)timeScriptableObject.sec} sec";
        playerScoreText.text = $"{timeScriptableObject.score}";
    }
}
