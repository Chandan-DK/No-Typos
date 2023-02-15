using UnityEngine;

public class CubeDestroyerScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource healthDecreaseSound;

    [SerializeField]
    private HealthScript healthScript;

    [SerializeField]
    private ParticleSystem particle;

    private int noOfCubesDestroyed;

    void OnTriggerEnter(Collider collision)
    {
        DestroyCube(collision);
    }

    private void DestroyCube(Collider collision)
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