using TMPro;
using UnityEngine;

public class DestroyCubeFromInputScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource _popSound;
    
    [SerializeField]
    private ParticleSystem _particles;

    [SerializeField]
    private DisplayScoreScript _displayScoreScript;

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
                ParticleSystem instantiatedParticle = Instantiate(_particles, cube.transform.position, Quaternion.identity);
                instantiatedParticle.Play();
                CameraShakeScript.Invoke();
                _popSound.Play();
                Destroy(cube.gameObject);
                _displayScoreScript.DisplayScore();
                break;
            }
        }
    }
}
