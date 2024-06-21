using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance = null;
    [Tooltip("Lane")]
    [SerializeField] private Transform[] _place;
    
    /// <summary> playerの座標 </summary>>
    private Vector3 _pos;

    /// <summary> 現在のレーン </summary>
    private int _currentLane = 1;

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
        _pos = transform.position;
    }
    
    void FixedUpdate()
    {
        if (GameManager.Instance._isPlaying)
        {
            _pos.z += 0.1f;
            this.gameObject.transform.position = new Vector3(0, 1, _pos.z);
        }
    }

    private void Update()
    {
        if (GameManager.Instance._isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.A) && _currentLane > 0)
            {
                _currentLane--;
            }
            if (Input.GetKeyDown(KeyCode.D) && _currentLane < _place.Length - 1)
            {
                _currentLane++;
            }
            _pos.x = _place[_currentLane].transform.position.x;
            transform.position = _pos;
        }
    }
}
