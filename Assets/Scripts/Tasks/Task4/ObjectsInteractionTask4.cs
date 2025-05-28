using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster
    // созданием объекта Waffle в точке WaffleRoot (из папки Prefabs)
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _waffleRoot;
    [SerializeField] private Toaster _toaster;

    private void Start()
    {
        _toaster.TimerIsUp += WaffleUp;
    }

    public void WaffleUp()
    {
        var position = _waffleRoot.transform;
        Instantiate(_prefab, position);
    }

}