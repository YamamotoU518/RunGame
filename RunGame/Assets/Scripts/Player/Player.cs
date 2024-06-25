using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance = null;
    [Tooltip("Lane")] [SerializeField] private Transform[] _place;

    /// <summary> playerのz軸に動くスピード </summary>
    [SerializeField] private int _speed = 0;

    /// <summary> playerの座標 </summary>>
    private Vector3 _pos;

    /// <summary> 現在のレーン </summary>
    private int _currentLane = 1;

    /// <summary> RunAnimation </summary>
    [SerializeField] private Animator _anim = null;

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
    
    private void Update()
    {
        if (GameManager.Instance._gameState == GameState.IsPlaying)
        {
            _anim.SetBool("Run", true);
            if (Input.GetKeyDown(KeyCode.A) && _currentLane > 0)
            {
                _currentLane--;
            }

            if (Input.GetKeyDown(KeyCode.D) && _currentLane < _place.Length - 1)
            {
                _currentLane++;
            }

            _pos.x = _place[_currentLane].transform.position.x;
            _pos.z += _speed * Time.deltaTime;
            this.gameObject.transform.position = new Vector3(_pos.x, 1, _pos.z);
        }
    }
}