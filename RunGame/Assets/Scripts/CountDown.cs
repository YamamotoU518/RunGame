using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [Tooltip("この時間からカウントダウンを始める")]
    [SerializeField] private float _num;

    [SerializeField] private Text _text = null;
    void Start()
    {
        
    }
    
    void Update()
    {
        _text.text = _num.ToString("0");
        if (_num <= 0.5f)
        {
            _text.text = "Start!!";
            Invoke("Delete", 1.5f);
            return;
        }
        _num -= Time.deltaTime;
    }

    void Delete()
    {
        _text.enabled = false;
    }
}
