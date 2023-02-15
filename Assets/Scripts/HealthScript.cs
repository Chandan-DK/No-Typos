using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private int health;

    [SerializeField]
    private Transform[] redHealthImageTransforms;

    [SerializeField]
    private TimeScriptableObject timeScriptableObject;

    [SerializeField]
    private DisplayTimeScript displayTimeScript;

    [SerializeField]
    private DisplayScoreScript displayScoreScript;

    void Start()
    {
        health = 3;
    }

    public void DecreaseHealth()
    {
        /* 
        There are grey coloured healths already present at the back of the red hearts.
        So disabling a red heart makes the grey heart visible
        */
        redHealthImageTransforms[--health].gameObject.SetActive(false);

        if (health == 0)
        {
            StoreStatsInScriptableObject();
            ChangeToGameOverSceneScript.SwitchToGameOverScene();
        }
    }

    private void StoreStatsInScriptableObject()
    {
        timeScriptableObject.min = displayTimeScript.minPassed;
        timeScriptableObject.sec = displayTimeScript.secPassed;
        timeScriptableObject.score = displayScoreScript.score;
    }
}
