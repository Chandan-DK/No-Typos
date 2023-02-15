using UnityEngine;

public class CubeMoveScript : MonoBehaviour
{
    private float cubeSpeed;

    public CubeSpeedGeneratorScript cubeSpeedGeneratorScript;

    void Start()
    {
        cubeSpeedGeneratorScript = GameObject.FindObjectOfType<CubeSpeedGeneratorScript>();

        // Assign speed to the cube based on the row in which it is spawned
        if (transform.tag == "RightCube Row0") cubeSpeed = -cubeSpeedGeneratorScript.speeds[0];
        else if (transform.tag == "RightCube Row1") cubeSpeed = -cubeSpeedGeneratorScript.speeds[1];
        else if (transform.tag == "RightCube Row2") cubeSpeed = -cubeSpeedGeneratorScript.speeds[2];
        else if (transform.tag == "RightCube Row3") cubeSpeed = -cubeSpeedGeneratorScript.speeds[3];
        else if (transform.tag == "LeftCube Row0") cubeSpeed = cubeSpeedGeneratorScript.speeds[3];
        else if (transform.tag == "LeftCube Row1") cubeSpeed = cubeSpeedGeneratorScript.speeds[2];
        else if (transform.tag == "LeftCube Row2") cubeSpeed = cubeSpeedGeneratorScript.speeds[1];
        else if (transform.tag == "LeftCube Row3") cubeSpeed = cubeSpeedGeneratorScript.speeds[0];
    }

    void Update()
    {
        transform.Translate(new Vector3(cubeSpeed, 0, 0) * Time.deltaTime);
    }
}
