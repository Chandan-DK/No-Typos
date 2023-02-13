using TMPro;
using UnityEngine;

public class DestroyCubeFromInputScript : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem particles;

    [SerializeField]
    private DisplayScoreScript displayScoreScript;

    public void DestroyCube(char character)
    {
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
                Destroy(cube.gameObject);
                displayScoreScript.increaseScore();
                break;
            }
        }
    }
}
