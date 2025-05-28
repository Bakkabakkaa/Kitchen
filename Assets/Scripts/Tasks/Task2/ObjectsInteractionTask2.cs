using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _lampRoot;

    private void Awake()
    {
        var position = _lampRoot.transform;
        Instantiate(_prefab, position);
    }
}