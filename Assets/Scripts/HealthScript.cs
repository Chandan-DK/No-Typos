using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private int _health;

    [SerializeField]
    private Transform[] _redHealthImageTransforms;

    [SerializeField]
    private TimeScriptableObject _timeScriptableObject;

    [SerializeField]
    private DisplayTimeScript _displayTimeScript;

    [SerializeField]
    private DisplayScoreScript _displayScoreScript;

    void Start()
    {
        _health = 3;
    }

    public void DecreaseHealth()
    {
        /* 
        There are grey coloured healths already present at the back of the red hearts.
        So disabling a red heart makes the grey heart visible
        */
        _redHealthImageTransforms[--_health].gameObject.SetActive(false);

        if (_health == 0)
        {
            _StoreStatsInScriptableObject();
            ChangeToGameOverSceneScript.SwitchToGameOverScene();
        }
    }

    private void _StoreStatsInScriptableObject()
    {
        _timeScriptableObject.min = _displayTimeScript.minPassed;
        _timeScriptableObject.sec = _displayTimeScript.secPassed;
        _timeScriptableObject.score = _displayScoreScript.score;
    }
}
