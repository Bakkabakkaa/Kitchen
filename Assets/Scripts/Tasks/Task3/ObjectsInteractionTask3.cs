using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    private List<Lamp> _allLamps = new List<Lamp>();

    private void Start()
    {
        Lamp[] lamps = GameObject.FindObjectsOfType<Lamp>();

        foreach (var lamp in lamps)
        {
            _allLamps.Add(lamp);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (var lamp in _allLamps)
            {
                lamp.Interact();
            }
        }
    }
}