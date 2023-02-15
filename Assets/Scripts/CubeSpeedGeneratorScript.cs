using UnityEngine;

public class CubeSpeedGeneratorScript : MonoBehaviour
{
    [HideInInspector]
    public float[] speeds;

    [SerializeField]
    private float minSpeed;
    [SerializeField]
    private float maxSpeed;

    void Start()
    {
        speeds = new float[8];
        for (int i = 0; i < 8; i++) speeds[i] = Random.Range(minSpeed, maxSpeed);
    }
}
