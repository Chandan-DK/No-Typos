using UnityEngine;

public class CubeMoveScript : MonoBehaviour
{
    private float _cubeSpeed;

    public CubeSpeedGeneratorScript cubeSpeedGeneratorScript;

    void Start()
    {
        cubeSpeedGeneratorScript = GameObject.FindObjectOfType<CubeSpeedGeneratorScript>();

        // Assign speed to the cube based on the row in which it is spawned
        if (transform.tag == "RightCube Row0") _cubeSpeed = -cubeSpeedGeneratorScript.speeds[0];
        else if (transform.tag == "RightCube Row1") _cubeSpeed = -cubeSpeedGeneratorScript.speeds[1];
        else if (transform.tag == "RightCube Row2") _cubeSpeed = -cubeSpeedGeneratorScript.speeds[2];
        else if (transform.tag == "RightCube Row3") _cubeSpeed = -cubeSpeedGeneratorScript.speeds[3];
        else if (transform.tag == "LeftCube Row0") _cubeSpeed = cubeSpeedGeneratorScript.speeds[3];
        else if (transform.tag == "LeftCube Row1") _cubeSpeed = cubeSpeedGeneratorScript.speeds[2];
        else if (transform.tag == "LeftCube Row2") _cubeSpeed = cubeSpeedGeneratorScript.speeds[1];
        else if (transform.tag == "LeftCube Row3") _cubeSpeed = cubeSpeedGeneratorScript.speeds[0];
    }

    void Update()
    {
        transform.Translate(new Vector3(_cubeSpeed, 0, 0) * Time.deltaTime);
    }
}
