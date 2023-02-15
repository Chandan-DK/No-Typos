using UnityEngine;

public class CubeMoveScript : MonoBehaviour
{
    private float cubeSpeed;

    public CubeSpeedGeneratorScript cubeSpeedGeneratorScript;

    void Start()
    {
        cubeSpeedGeneratorScript = GameObject.FindObjectOfType<CubeSpeedGeneratorScript>();
        if (transform.tag == "Right Cube0") cubeSpeed = -cubeSpeedGeneratorScript.speeds[0];
        else if (transform.tag == "Right Cube1") cubeSpeed = -cubeSpeedGeneratorScript.speeds[1];
        else if (transform.tag == "Right Cube2") cubeSpeed = -cubeSpeedGeneratorScript.speeds[2];
        else if (transform.tag == "Right Cube3") cubeSpeed = -cubeSpeedGeneratorScript.speeds[3];
        else if (transform.tag == "Left Cube0") cubeSpeed = cubeSpeedGeneratorScript.speeds[3];
        else if (transform.tag == "Left Cube1") cubeSpeed = cubeSpeedGeneratorScript.speeds[2];
        else if (transform.tag == "Left Cube2") cubeSpeed = cubeSpeedGeneratorScript.speeds[1];
        else if (transform.tag == "Left Cube3") cubeSpeed = cubeSpeedGeneratorScript.speeds[0];
    }

    void Update()
    {
        transform.Translate(new Vector3(cubeSpeed, 0, 0) * Time.deltaTime);
    }
}
