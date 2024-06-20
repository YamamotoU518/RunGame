using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance = null;
    
    [SerializeField] private Transform[] _place;
    
    private bool _finish;
    float _z;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(this.gameObject);
    }

    void Start()
    {
        _finish = false;
        _z = this.gameObject.transform.position.z;
    }
    
    void FixedUpdate()
    {
        if (GameManager.Instance._start)
        {
            _z += 0.1f;
            this.gameObject.transform.position = new Vector3(0, 1, _z);
        }
    }
}
