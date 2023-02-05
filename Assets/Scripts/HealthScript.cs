using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private int health;

    [SerializeField]
    private Transform[] redHealths;

    [SerializeField]
    private TimeScriptableObject timeScriptableObject;

    [SerializeField]
    private DisplayTimeScript displayTimeScript;

    void Start()
    {
        health = 3;
    }

    public void DecreaseHealth()
    {
        redHealths[--health].gameObject.SetActive(false);

        if (health == 0)
        {
            timeScriptableObject.min = displayTimeScript.minPassed;
            timeScriptableObject.sec = displayTimeScript.secPassed;
            ChangeToGameOverSceneScript.SwitchToGameOverScene();
        }
    }
}
