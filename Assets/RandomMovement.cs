using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "RandomMovement", menuName = "Behaviours/RandomMovement")]
public class RandomMovement : AbstractBehaviour
{
    [SerializeField] private float axisX = 0;
    [SerializeField] private float axisY = 0;
    

    public override Vector3 CurrentMovement
    {
        get
        {
            float randomAxisX = UnityEngine.Random.Range(-axisX, axisX);
            float randomAxisY = UnityEngine.Random.Range(-axisY, axisY);
            return new Vector2(randomAxisX, randomAxisY);
        }
    }
}
