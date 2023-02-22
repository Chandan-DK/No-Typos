using UnityEngine;
using TMPro;

public class DisplayTimeScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _timerText;

    [HideInInspector]
    public float secPassed;
    [HideInInspector]
    public int minPassed;

    void Update()
    {
        secPassed += Time.deltaTime;

        if (secPassed >= 60)
        {
            minPassed++;
            secPassed = 0;
        }

        _DisplayTime();
    }

    private void _DisplayTime()
    {
        if (minPassed < 10)
        {
            if (secPassed < 10)
            {
                _timerText.text = $"0{minPassed}:0{(int)secPassed}";
            }
            else
            {
                _timerText.text = $"0{minPassed}:{(int)secPassed}";
            }
        }
        else
        {
            if (secPassed < 10)
            {
                _timerText.text = $"{minPassed}:0{(int)secPassed}";
            }
            else
            {
                _timerText.text = $"{minPassed}:{(int)secPassed}";
            }
        }
    }
}
