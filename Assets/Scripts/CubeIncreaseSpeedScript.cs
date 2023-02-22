using UnityEngine;

public class CubeIncreaseSpeedScript : MonoBehaviour
{
    private float _timeInSec;

    [SerializeField]
    private float _increaseSpeedAfterSec;

    [SerializeField]
    private CubeSpeedGeneratorScript _cubeSpeedGeneratorScript;

    [SerializeField]
    private int _noOfTimesToIncreaseSpeed;

    void Update()
    {
        _timeInSec += Time.deltaTime;

        if (_noOfTimesToIncreaseSpeed > 0)
        {
            _IncreaseSpeed();
        }

    }

    private void _IncreaseSpeed()
    {
        if (_timeInSec >= _increaseSpeedAfterSec)
        {
            for (int i = 0; i < 4; i++) _cubeSpeedGeneratorScript.speeds[i]++;
            _timeInSec = 0;
            _noOfTimesToIncreaseSpeed--;
        }
    }
}
