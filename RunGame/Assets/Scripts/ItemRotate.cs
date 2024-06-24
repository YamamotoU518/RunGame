using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotate : MonoBehaviour
{
    private float _nowPos;

    private void Start()
    {
        _nowPos = this.transform.position.y;
    }

    void Update()
    {
        this.gameObject.transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        this.gameObject.transform.position =
            new Vector3(transform.position.x, _nowPos + Mathf.PingPong(Time.time / 3, 0.3f), transform.position.z);
    }
}
