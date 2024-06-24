using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] public CoinDataBase _coinData = null;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            CoinManager.Instance.AddAmountOfCoins(_coinData.VelueOfMoney);
            Destroy(this.gameObject);
        }
    }
}
