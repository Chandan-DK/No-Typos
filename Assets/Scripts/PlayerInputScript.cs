using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    [SerializeField]
    private DestroyCubeFromInputScript destroyCubeFromInputScript;

    void Update()
    {
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
