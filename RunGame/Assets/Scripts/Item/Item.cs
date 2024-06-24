using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    /// <summary> 種類 </summary>
    [SerializeField] private ItemDataBase _itemData = null;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            ScoreManager.Instance.AddScore(_itemData.Score);
            Destroy(this.gameObject);
        }
    }
}
