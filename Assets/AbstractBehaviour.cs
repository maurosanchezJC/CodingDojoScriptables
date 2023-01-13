using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractBehaviour : ScriptableObject
{
    public abstract Vector3 CurrentMovement { get; }
    
    public abstract void Update();
}

