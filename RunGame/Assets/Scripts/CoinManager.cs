using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance => _instance;
    private static CoinManager _instance;

    [SerializeField] private Text _text = null;

    public int _currentCoin { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
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
        if (_text) { _text.text = _currentCoin.ToString(); }
    }

    public void AddAmountOfCoins(int coin)
    {
        _currentCoin += coin;
    }
}
