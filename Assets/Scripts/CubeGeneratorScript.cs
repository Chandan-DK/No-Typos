using System;
using TMPro;
using UnityEngine;

public class CubeGeneratorScript : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    [SerializeField]
    private Vector3 rightCubeStartingPosition;
    [SerializeField]
    private Vector3 leftCubeStartingPosition;

    [SerializeField]
    private Vector3 moveDirection;

    private float distanceBetweenSuccessiveCubes;

    [SerializeField]
    private float spawnAfterSec;

    private float timeInSec;

    private float timeElapsed;
    private int noOfTimesSpawnSpeedDecreased;

    private int increaseSpeedAfterSec;

    void Start()
    {
        increaseSpeedAfterSec = 20;
        distanceBetweenSuccessiveCubes = 5f;
    }

    void Update()
    {
        timeInSec += Time.deltaTime;
        timeElapsed += Time.deltaTime;

        if (timeInSec >= spawnAfterSec)
        {
            InstantiateCube();
            timeInSec = 0;
        }

        if (noOfTimesSpawnSpeedDecreased <= 5)
        {
            DecreaseSpawnSpeed();
        }
    }

    private void InstantiateCube()
    {
        int randomRowMultiplier = UnityEngine.Random.Range(0, 4);
        float zOffset = distanceBetweenSuccessiveCubes * randomRowMultiplier;

        Vector3 instantiatedCubeInitialPosition;
        
        bool isPositionRight = Convert.ToBoolean(UnityEngine.Random.Range(0, 2));
        if (!isPositionRight) instantiatedCubeInitialPosition = leftCubeStartingPosition;
        else instantiatedCubeInitialPosition = rightCubeStartingPosition;

        Vector3 offsetFromInitialPosition = instantiatedCubeInitialPosition + new Vector3(0, 0, zOffset);

        GameObject instantiatedCube = Instantiate(cube, offsetFromInitialPosition, Quaternion.identity);

        /*
        ASCII value of A = 65
        ASCII value of Z = 90
        Display a random character on the cube from A-Z
        */
        char randomCharacter = (char)UnityEngine.Random.Range(65, 91);
        instantiatedCube.GetComponentInChildren<TextMeshProUGUI>().text = randomCharacter.ToString();

        /*
        The moving cubes are tagged based on their 
        position (left or right) and the row in which they are spawned
        */
        if ((randomRowMultiplier == 0) && isPositionRight) instantiatedCube.tag = "Right Cube0";
        else if ((randomRowMultiplier == 0) && !isPositionRight) instantiatedCube.tag = "Left Cube0";
        else if ((randomRowMultiplier == 1) && isPositionRight) instantiatedCube.tag = "Right Cube1";
        else if ((randomRowMultiplier == 1) && !isPositionRight) instantiatedCube.tag = "Left Cube1";
        else if ((randomRowMultiplier == 2) && isPositionRight) instantiatedCube.tag = "Right Cube2";
        else if ((randomRowMultiplier == 2) && !isPositionRight) instantiatedCube.tag = "Left Cube2";
        else if ((randomRowMultiplier == 3) && isPositionRight) instantiatedCube.tag = "Right Cube3";
        else if ((randomRowMultiplier == 3) && !isPositionRight) instantiatedCube.tag = "Left Cube3";
    }

    private void DecreaseSpawnSpeed()
    {
        if (timeElapsed >= increaseSpeedAfterSec)
            {
                if (noOfTimesSpawnSpeedDecreased < 2) spawnAfterSec--;
                else if (noOfTimesSpawnSpeedDecreased == 2) spawnAfterSec = 0.9f;
                else if (noOfTimesSpawnSpeedDecreased == 3) spawnAfterSec = 0.8f;
                else if (noOfTimesSpawnSpeedDecreased == 4) spawnAfterSec = 0.7f;
                else if (noOfTimesSpawnSpeedDecreased == 5) spawnAfterSec = 0.5f;
                else if (noOfTimesSpawnSpeedDecreased == 6) spawnAfterSec = 0.3f;
                noOfTimesSpawnSpeedDecreased++;
                timeElapsed = 0;
            }
    }
}
