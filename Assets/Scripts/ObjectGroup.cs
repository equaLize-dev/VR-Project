using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectGroup : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _objects;

    private int _index = 0;

/*    private void Start()
    {
        foreach (GameObject obj in GetComponentsInChildren<GameObject>())
            _objects.Add(obj.gameObject);
    }*/

    public void SnapObject()
    {
        _objects[_index].SetActive(false);
        if (++_index >= _objects.Count)
            _index = 0;
        _objects[_index].SetActive(true);
    }
}
