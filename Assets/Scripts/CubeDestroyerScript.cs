using UnityEngine;

public class CubeDestroyerScript : MonoBehaviour
{
    [SerializeField]
    private AudioSource _healthDecreaseSound;

    [SerializeField]
    private HealthScript _healthScript;

    [SerializeField]
    private ParticleSystem _particle;

    private int _noOfCubesDestroyed;

    void OnTriggerEnter(Collider collision)
    {
        _DestroyCube(collision);
    }

    private void _DestroyCube(Collider collision)
    {
        _noOfCubesDestroyed++;

        ParticleSystem instantiatedParticle = Instantiate(_particle, collision.transform.position, Quaternion.identity);
        instantiatedParticle.Play();

        if (_noOfCubesDestroyed < 3) CameraShakeScript.Invoke();

        _healthScript.DecreaseHealth();

        _healthDecreaseSound.Play();
        Destroy(collision.gameObject);
    }
}