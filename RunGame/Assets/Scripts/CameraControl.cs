using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Transform _camerapos;
    [SerializeField] private Transform _playerPos;
    [SerializeField] private Vector3 _cameraVec;
    [SerializeField] private Vector3 _cameraRot;
    
    void Start()
    {
        _camerapos = transform;
        _camerapos.rotation = Quaternion.Euler(_cameraRot);
    }

    private void LateUpdate()
    {
        _camerapos.position = _playerPos.position + _cameraVec;
    }
}
