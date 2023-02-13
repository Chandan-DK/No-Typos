using UnityEngine;

public class CubeDestroyerScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource healthDecreaseSound;

    private HealthScript healthScript;

    [SerializeField]
    private ParticleSystem particle;

    private int noOfCubesDestroyed;

    void Start()
    {
        healthScript = GameObject.FindObjectOfType<HealthScript>();
    }

    void OnTriggerEnter(Collider collision)
    {
        noOfCubesDestroyed++;

        ParticleSystem instantiatedParticle = Instantiate(particle, collision.transform.position, Quaternion.identity);
        instantiatedParticle.Play();

        if (noOfCubesDestroyed < 3) CameraShakeScript.Invoke();

        healthScript.DecreaseHealth();

        healthDecreaseSound.Play();
        Destroy(collision.gameObject);
    }
}