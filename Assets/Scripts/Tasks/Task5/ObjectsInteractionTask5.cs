using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены

    private Shelf[] _shelves;
    

    private void Start()
    {
        Transform kitchen = GameObject.Find("Kitchen").transform;
        _shelves = kitchen.GetComponentsInChildren<Shelf>();
        
        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned += () =>
            {
                if (shelf.ItemsCount > 3)
                {
                    shelf.Fall();
                }
            };
        }
        
    }
}