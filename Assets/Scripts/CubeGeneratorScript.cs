using System;
using TMPro;
using UnityEngine;

public class CubeGeneratorScript : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private Transform cubeStartingPositionRight;
    [SerializeField]
    private Transform cubeStartingPositionLeft;

    [SerializeField]
    private Vector3 moveDirection;

    [SerializeField]
    private float zOffset;

    [SerializeField]
    private float spawnafterSec;

    private float timeInSec;

    private float timeElapsed;
    private int noOfTimesSpawnSpeedDecreased;

    private int increaseSpeedAfterSec;

    void Start()
    {
        increaseSpeedAfterSec = 20;
    }

    void Update()
    {
        timeInSec += Time.deltaTime;
        timeElapsed += Time.deltaTime;

        if (timeInSec >= spawnafterSec)
        {
            InstantiateCube();
            timeInSec = 0;
        }

        if (noOfTimesSpawnSpeedDecreased <= 5)
        {
            if (timeElapsed >= increaseSpeedAfterSec)
            {
                if (noOfTimesSpawnSpeedDecreased < 2) spawnafterSec--;
                else if (noOfTimesSpawnSpeedDecreased == 2) spawnafterSec = 0.9f;
                else if (noOfTimesSpawnSpeedDecreased == 3) spawnafterSec = 0.8f;
                else if (noOfTimesSpawnSpeedDecreased == 4) spawnafterSec = 0.7f;
                else if (noOfTimesSpawnSpeedDecreased == 5) spawnafterSec = 0.5f;
                else if (noOfTimesSpawnSpeedDecreased == 6) spawnafterSec = 0.3f;
                noOfTimesSpawnSpeedDecreased++;
                timeElapsed = 0;
            }
        }
    }

    private void InstantiateCube()
    {
        int rand = UnityEngine.Random.Range(0, 4);
        float offset = zOffset * rand;

        Vector3 instantiatedCubePositionTransform;
        // It is either false(0) or true(1)
        bool isPositionRight = Convert.ToBoolean(UnityEngine.Random.Range(0, 2));
        if (!isPositionRight) instantiatedCubePositionTransform = cubeStartingPositionLeft.position;
        else instantiatedCubePositionTransform = cubeStartingPositionRight.position;

        GameObject instantiatedCube = Instantiate(cube, instantiatedCubePositionTransform + new Vector3(0, 0, offset), Quaternion.identity);

        // Display a random character on the cube 
        char charNo = (char)UnityEngine.Random.Range(65, 91);
        instantiatedCube.GetComponentInChildren<TextMeshProUGUI>().text = charNo.ToString();

        if ((rand == 0) && isPositionRight) instantiatedCube.tag = "Right Cube0";
        else if ((rand == 0) && !isPositionRight) instantiatedCube.tag = "Left Cube0";
        else if ((rand == 1) && isPositionRight) instantiatedCube.tag = "Right Cube1";
        else if ((rand == 1) && !isPositionRight) instantiatedCube.tag = "Left Cube1";
        else if ((rand == 2) && isPositionRight) instantiatedCube.tag = "Right Cube2";
        else if ((rand == 2) && !isPositionRight) instantiatedCube.tag = "Left Cube2";
        else if ((rand == 3) && isPositionRight) instantiatedCube.tag = "Right Cube3";
        else if ((rand == 3) && !isPositionRight) instantiatedCube.tag = "Left Cube3";
    }
}
