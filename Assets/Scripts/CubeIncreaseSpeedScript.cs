using UnityEngine;

public class CubeIncreaseSpeedScript : MonoBehaviour
{
    private float timeInSec;

    [SerializeField]
    private float increaseSpeedAfterSec;

    [SerializeField]
    private CubeSpeedGeneratorScript cubeSpeedGeneratorScript;

    [SerializeField]
    private int noOfTimesToIncreaseSpeed;

    void Update()
    {
        timeInSec += Time.deltaTime;

        if (noOfTimesToIncreaseSpeed > 0)
        {
            IncreaseSpeed();
        }

    }

    private void IncreaseSpeed()
    {
        if (timeInSec >= increaseSpeedAfterSec)
        {
            for (int i = 0; i < 4; i++) cubeSpeedGeneratorScript.speeds[i]++;
            timeInSec = 0;
            noOfTimesToIncreaseSpeed--;
        }
    }
}
