using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powers/Throw Log", fileName = "ThrowLogPower")]
public class ThrowLogPower : AbstractPower
{
    [SerializeField] private string logToThrow;

    public override void ExecutePower()
    {
        Debug.Log(logToThrow);
    }
}
