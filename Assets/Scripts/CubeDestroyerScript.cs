using UnityEngine;

public class CubeDestroyerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
    }
}
