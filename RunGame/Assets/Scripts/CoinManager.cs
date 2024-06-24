using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance = null;

    [SerializeField] private Text _text = null;

    private int _currentCoin;

    void Awake()
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
        _currentCoin = 0;
    }
    
    void Update()
    {
        _text.text = _currentCoin.ToString();
    }

    public void AddAmountOfCoins(int coin)
    {
        _currentCoin += coin;
    }
}
