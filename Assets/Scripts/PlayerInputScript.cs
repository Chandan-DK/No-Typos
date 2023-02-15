using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField]
    private DestroyCubeFromInputScript destroyCubeFromInputScript;

    void Update()
    {
        /* 
        ASCII value of a = 97 and z = 122
        This loop checks if any of the keys from a to z is pressed and
        destroys the cube with that character
        */
        for (int i = 97; i < 123; i++)
        {
            char character = (char)i;

            if (Input.GetKeyDown(character.ToString()))
            {
                destroyCubeFromInputScript.DestroyCube(character);
            }
        }
    }
}
