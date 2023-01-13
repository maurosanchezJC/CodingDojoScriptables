using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InputListener", menuName = "Behaviours/Input Listener")]
public class InputListenerBehavior : AbstractBehaviour
{
    public override Vector3 CurrentMovement
    {
        get
        {
            
            float axisY = Input.GetAxis("Vertical");
            float axisX = Input.GetAxis("Horizontal");
            return new Vector2(axisX, axisY);
        }
    }

}
