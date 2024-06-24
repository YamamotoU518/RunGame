using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Coin")]
public class CoinDataBase : ScriptableObject
{
    public string Name => _name;
    [SerializeField] private string _name = "";

    /// <summary> コインを獲得したときに得るお金 </summary>
    public int VelueOfMoney => _value;
    [SerializeField] private int _value = 0;
}
