using TMPro;
using UnityEngine;

public class DisplayScoreAndTimeSurvivedScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _timeText;

    [SerializeField]
    private TextMeshProUGUI _playerScoreText;

    [SerializeField]
    private TimeScriptableObject _timeScriptableObject;

    void Start()
    {
        _DisplayStats();
    }

    private void _DisplayStats()
    {
        _timeText.text = $"{_timeScriptableObject.min} min {(int)_timeScriptableObject.sec} sec";
        _playerScoreText.text = $"{_timeScriptableObject.score}";
    }
}
