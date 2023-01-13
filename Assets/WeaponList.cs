using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Some Scriptables/Weapon List", fileName = "WeaponList")]
public class WeaponList : ScriptableObject
{
    [SerializeField] private List<Weapon> weaponList;
}
