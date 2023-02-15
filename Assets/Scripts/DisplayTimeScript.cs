using UnityEngine;
using TMPro;

public class DisplayTimeScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timerText;

    [HideInInspector]
    public float secPassed;
    [HideInInspector]
    public int minPassed;

    // Update is called once per frame
    void Update()
    {
        secPassed += Time.deltaTime;

        if (secPassed >= 60)
        {
            minPassed++;
            secPassed = 0;
        }

        if (minPassed < 10)
        {
            if (secPassed < 10)
            {
                timerText.text = $"0{minPassed}:0{(int)secPassed}";
            }
            else
            {
                timerText.text = $"0{minPassed}:{(int)secPassed}";
            }
        }
        else
        {
            if (secPassed < 10)
            {
                timerText.text = $"{minPassed}:0{(int)secPassed}";
            }
            else
            {
                timerText.text = $"{minPassed}:{(int)secPassed}";
            }
        }
    }
}
