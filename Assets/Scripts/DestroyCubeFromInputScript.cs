using TMPro;
using UnityEngine;

public class DestroyCubeFromInputScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource popSound;
    
    [SerializeField]
    private ParticleSystem particles;

    [SerializeField]
    private DisplayScoreScript displayScoreScript;

    public void DestroyCube(char character)
    {
        /*
        CubeMoveScript is a component that is only attached to the moving cubes.
        This helps us uniquely identify the moving cubes from the rest of the game objects in the scene
        */
        CubeMoveScript[] cubes = GameObject.FindObjectsOfType<CubeMoveScript>();

        foreach (var cube in cubes)
        {
            string text;
            text = cube.GetComponentInChildren<TextMeshProUGUI>().text;

            if (text.Equals(character.ToString().ToUpper()))
            {
                ParticleSystem instantiatedParticle = Instantiate(particles, cube.transform.position, Quaternion.identity);
                instantiatedParticle.Play();
                CameraShakeScript.Invoke();
                popSound.Play();
                Destroy(cube.gameObject);
                displayScoreScript.DisplayScore();
                break;
            }
        }
    }
}
