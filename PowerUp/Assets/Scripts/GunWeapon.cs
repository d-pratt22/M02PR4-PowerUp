using UnityEngine;
using System.Collections;

public class GunWeapon : MonoBehaviour
{
    public WeaponConfig weaponConfig;
    public WeaponAttachment attachment1;
    public WeaponAttachment attachment2;
    public WeaponAttachment attachment3;
    public WeaponAttachment attachment4;

    public IWeapon _weapon;
    private bool _isDecorated;

    public void Start()
    {
        _weapon = new Weapon(weaponConfig);
    }
}
