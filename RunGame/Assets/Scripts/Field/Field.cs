using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    void Update()
    {
        // プレイヤーが自分（Field）より前に行ったら（自分が画面外に行ったら）消す
        if (Player.Instance.transform.position.z > gameObject.transform.position.z + 25)
        {
            Destroy(this.transform.parent.gameObject);
        }
    }
}
