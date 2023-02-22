using System;
using TMPro;
using UnityEngine;

public class CubeGeneratorScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private Vector3 _rightCubeStartingPosition;
    [SerializeField]
    private Vector3 _leftCubeStartingPosition;

    [SerializeField]
    private Vector3 _moveDirection;

    private float _distanceBetweenSuccessiveCubes;

    [SerializeField]
    private float _spawnAfterSec;

    private float _timeInSec;

    private float _timeElapsed;
    private int _noOfTimesSpawnSpeedDecreased;

    private int _increaseSpeedAfterSec;

    void Start()
    {
        _increaseSpeedAfterSec = 20;
        _distanceBetweenSuccessiveCubes = 5f;
    }

    void Update()
    {
        _timeInSec += Time.deltaTime;
        _timeElapsed += Time.deltaTime;

        if (_timeInSec >= _spawnAfterSec)
        {
            _InstantiateCube();
            _timeInSec = 0;
        }

        if (_noOfTimesSpawnSpeedDecreased <= 5)
        {
            if (_timeElapsed >= _increaseSpeedAfterSec)
            {
                _DecreaseSpawnSpeed();
            }
        }
    }

    private void _InstantiateCube()
    {
        int randomRowMultiplier = UnityEngine.Random.Range(0, 4);
        float zOffset = _distanceBetweenSuccessiveCubes * randomRowMultiplier;

        Vector3 instantiatedCubeInitialPosition;

        bool isPositionRight = Convert.ToBoolean(UnityEngine.Random.Range(0, 2));
        if (!isPositionRight) instantiatedCubeInitialPosition = _leftCubeStartingPosition;
        else instantiatedCubeInitialPosition = _rightCubeStartingPosition;

        Vector3 offsetFromInitialPosition = instantiatedCubeInitialPosition + new Vector3(0, 0, zOffset);

        GameObject instantiatedCube = Instantiate(_cube, offsetFromInitialPosition, Quaternion.identity);

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
        if ((randomRowMultiplier == 0) && isPositionRight) instantiatedCube.tag = "RightCube Row0";
        else if ((randomRowMultiplier == 0) && !isPositionRight) instantiatedCube.tag = "LeftCube Row0";
        else if ((randomRowMultiplier == 1) && isPositionRight) instantiatedCube.tag = "RightCube Row1";
        else if ((randomRowMultiplier == 1) && !isPositionRight) instantiatedCube.tag = "LeftCube Row1";
        else if ((randomRowMultiplier == 2) && isPositionRight) instantiatedCube.tag = "RightCube Row2";
        else if ((randomRowMultiplier == 2) && !isPositionRight) instantiatedCube.tag = "LeftCube Row2";
        else if ((randomRowMultiplier == 3) && isPositionRight) instantiatedCube.tag = "RightCube Row3";
        else if ((randomRowMultiplier == 3) && !isPositionRight) instantiatedCube.tag = "LeftCube Row3";
    }

    private void _DecreaseSpawnSpeed()
    {
        if (_noOfTimesSpawnSpeedDecreased == 0) _spawnAfterSec--;
        else if (_noOfTimesSpawnSpeedDecreased == 1) _spawnAfterSec = 0.9f;
        else if (_noOfTimesSpawnSpeedDecreased == 2) _spawnAfterSec = 0.8f;
        else if (_noOfTimesSpawnSpeedDecreased == 3) _spawnAfterSec = 0.7f;
        else if (_noOfTimesSpawnSpeedDecreased == 4) _spawnAfterSec = 0.6f;
        else if (_noOfTimesSpawnSpeedDecreased == 5) _spawnAfterSec = 0.5f;
        _noOfTimesSpawnSpeedDecreased++;
        _timeElapsed = 0;
    }
}
