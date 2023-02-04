using DG.Tweening;
using System;
using UnityEngine;

public class CameraShakeScript : MonoBehaviour
{
    [SerializeField]
    private Transform mainCamera;

    [SerializeField]
    private float shakeDuration;

    [SerializeField]
    private Vector3 positionStrength;

    [SerializeField]
    private Vector3 rotationStrength;

    public static event Action Shake;

    public static void Invoke()
    {
        Shake?.Invoke();
    }

    public void OnEnable()
    {
        Shake += CameraShake;
    }

    public void OnDisable()
    {
        Shake -= CameraShake;
    }

    public void CameraShake()
    {
        mainCamera.DOComplete();
        mainCamera.DOShakePosition(shakeDuration, positionStrength);
        mainCamera.DOShakeRotation(shakeDuration, rotationStrength);
    }
}
