using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGenerator : MonoBehaviour
{
    public GameObject[] _field;
    private int _zPos = 50; // 新しく生成されるFieldの位置
    private bool _creatingField = false;
    private int _fieldNum;
    
    void Update()
    {
        if (!_creatingField)
        {
            _creatingField = true;
            StartCoroutine(GenerateField());
        }
    }

    IEnumerator GenerateField()
    {
        _fieldNum = Random.Range(0, _field.Length);
        Instantiate(_field[_fieldNum], new Vector3(0, 0, _zPos), Quaternion.identity);
        _zPos += 50;
        yield return new WaitForSeconds(5);
        _creatingField = false;
    }
}
