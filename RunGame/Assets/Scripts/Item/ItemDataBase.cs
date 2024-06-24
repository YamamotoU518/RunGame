using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Item")]
public class ItemDataBase : ScriptableObject
{
    /// <summary> 名前 </summary>
    public string Name => _name;
    [SerializeField] private string _name = "";
    
    /// <summary> プラスされるスコア </summary>
    public int Score => _score;
    [SerializeField] private int _score = 0;

}
