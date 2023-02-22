using UnityEngine;

public class CubeSpeedGeneratorScript : MonoBehaviour
{
    [HideInInspector]
    public float[] speeds;

    [SerializeField]
    private float _minSpeed;
    [SerializeField]
    private float _maxSpeed;

    void Start()
    {
        _GenerateRandomSpeedForEachRow();
    }

    private void _GenerateRandomSpeedForEachRow()
    {
        speeds = new float[4];
        for (int i = 0; i < 4; i++) speeds[i] = Random.Range(_minSpeed, _maxSpeed);
    }
}
