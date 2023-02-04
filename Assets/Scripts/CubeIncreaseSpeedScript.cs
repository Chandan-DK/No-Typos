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

    // Update is called once per frame
    void Update()
    {
        timeInSec += Time.deltaTime;

        if (noOfTimesToIncreaseSpeed > 0)
        {
            if (timeInSec >= increaseSpeedAfterSec)
            {
                for (int i = 0; i < 4; i++) cubeSpeedGeneratorScript.speeds[i]++;
                timeInSec = 0;
                noOfTimesToIncreaseSpeed--;
            }
        }

    }
}
