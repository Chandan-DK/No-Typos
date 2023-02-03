using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float timeElapsed;
    private float timeInSec;

    public int increaseSpeedAfterSec;

    private GameStartedNotifyScript gameStartedNotifyScript;
    private CubeSpeedGeneratorScript cubeSpeedGeneratorScript;

    // Start is called before the first frame update
    void Start()
    {
        gameStartedNotifyScript = GameObject.FindObjectOfType<GameStartedNotifyScript>();
        cubeSpeedGeneratorScript = GameObject.FindObjectOfType<CubeSpeedGeneratorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStartedNotifyScript.hasGameStarted)
        {
            timeInSec += Time.deltaTime;
            timeElapsed += Time.deltaTime;
        }

        if (timeInSec >= increaseSpeedAfterSec)
        {
            for (int i = 0; i < 4; i++) cubeSpeedGeneratorScript.speeds[i]++;
            timeInSec = 0;
        }
    }
}
