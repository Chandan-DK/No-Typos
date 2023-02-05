using TMPro;
using UnityEngine;

public class DisplayTimeSurvivedScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeText;

    [SerializeField]
    private TimeScriptableObject timeScriptableObject;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = $"{timeScriptableObject.min} min {(int)timeScriptableObject.sec} sec";
    }
}
