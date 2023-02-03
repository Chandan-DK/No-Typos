using UnityEngine;

public class GameStartedNotifyScript : MonoBehaviour
{
    [HideInInspector]
    public bool hasGameStarted;

    void Start()
    {
        hasGameStarted = true;
    }
}
