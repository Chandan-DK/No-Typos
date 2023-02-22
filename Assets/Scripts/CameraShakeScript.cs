using DG.Tweening;
using System;
using UnityEngine;

public class CameraShakeScript : MonoBehaviour
{
    [SerializeField]
    private Transform _mainCamera;

    [SerializeField]
    private float _shakeDuration;

    [SerializeField]
    private Vector3 _positionStrength;

    [SerializeField]
    private Vector3 _rotationStrength;

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
        _mainCamera.DOComplete();
        _mainCamera.DOShakePosition(_shakeDuration, _positionStrength);
        _mainCamera.DOShakeRotation(_shakeDuration, _rotationStrength);
    }
}
