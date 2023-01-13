using UnityEngine;

[CreateAssetMenu(menuName = "Some Scriptables/Some scriptable", fileName = "Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField] private string weaponName = null;
    [SerializeField] private int attackPower = 0;
}
