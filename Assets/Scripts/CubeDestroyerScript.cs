using UnityEngine;

public class CubeDestroyerScript : MonoBehaviour
{
    private HealthScript healthScript;

    void Start()
    {
        healthScript = GameObject.FindObjectOfType<HealthScript>();
    }

    void OnTriggerEnter(Collider collision)
    {
        healthScript.DecreaseHealth();
        Destroy(collision.gameObject);
    }
}
