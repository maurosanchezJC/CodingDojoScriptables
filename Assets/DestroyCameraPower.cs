using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powers/Destroy Camera", fileName = "DestroyCamera")]
public class DestroyCameraPower : AbstractPower
{
    public override void ExecutePower()
    {
        Destroy(Camera.main);
    }
}
