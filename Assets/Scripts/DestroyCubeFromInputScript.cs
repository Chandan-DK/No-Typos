using TMPro;
using UnityEngine;

public class DestroyCubeFromInputScript : MonoBehaviour
{
    public void DestroyCube(char character)
    {
        CubeMoveScript[] cubes = GameObject.FindObjectsOfType<CubeMoveScript>();

        foreach (var cube in cubes)
        {
            string text;
            text = cube.GetComponentInChildren<TextMeshProUGUI>().text;

            if (text.Equals(character.ToString().ToUpper()))
            {
                Destroy(cube.gameObject);
                break;
            }
        }
    }
}
