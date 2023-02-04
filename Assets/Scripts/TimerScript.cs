using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public float timeElapsed;

    public int increaseSpeedAfterSec;

    private GameStartedNotifyScript gameStartedNotifyScript;

    // Start is called before the first frame update
    void Start()
    {
        gameStartedNotifyScript = GameObject.FindObjectOfType<GameStartedNotifyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStartedNotifyScript.hasGameStarted) timeElapsed += Time.deltaTime;
    }
}
