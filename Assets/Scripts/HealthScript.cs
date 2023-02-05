using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private int health;

    [SerializeField]
    private Transform[] redHealths;

    void Start()
    {
        health = 3;
    }

    public void DecreaseHealth()
    {
        redHealths[--health].gameObject.SetActive(false);
    }
}
