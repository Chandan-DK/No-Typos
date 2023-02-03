using UnityEngine;
using TMPro;

public class DisplayTimeScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timerText;
    private TimerScript timerScript;

    private float secPassed;
    private float minPassed;

    // Start is called before the first frame update
    void Start()
    {
        timerScript = GameObject.FindObjectOfType<TimerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        secPassed += Time.deltaTime;

        if (secPassed >= 60)
        {
            minPassed++;
            secPassed = 0;
        }

        timerText.text = $"{minPassed}:{(int)secPassed}";
    }
}
