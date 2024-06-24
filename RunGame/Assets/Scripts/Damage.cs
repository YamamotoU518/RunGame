using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.Instance.Finish();
        }
    }
}
