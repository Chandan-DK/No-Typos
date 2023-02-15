using UnityEngine;

[CreateAssetMenu()]
// The values in this script are loaded in the game over scene
public class TimeScriptableObject : ScriptableObject
{
    public int min;
    public float sec;
    public int score;
}
