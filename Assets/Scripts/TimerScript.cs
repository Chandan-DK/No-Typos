using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float timeElapsed;

    public int increaseSpeedAfterSec;

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
    }
}
