using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [Header("Move Components")]
    [SerializeField] private AbstractBehaviour moveComponent;
    
    [Header("Powers")]
    [SerializeField] private AbstractPower power1;
    [SerializeField] private AbstractPower power2;
    [SerializeField] private AbstractPower power3;
    [SerializeField] private AbstractPower power4;
    [SerializeField] private AbstractPower power5;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            power1.ExecutePower();
        if (Input.GetKeyDown(KeyCode.Alpha2))
            power2.ExecutePower();
        if (Input.GetKeyDown(KeyCode.Alpha3))
            power3.ExecutePower();
        if (Input.GetKeyDown(KeyCode.Alpha4))
            power4.ExecutePower();
        if (Input.GetKeyDown(KeyCode.Alpha5))
            power5.ExecutePower();
        
        moveComponent.Update();
        Move(moveComponent.CurrentMovement);
    }

    private void Move(Vector3 movement)
    {
        transform.Translate(movement);
    }
}
