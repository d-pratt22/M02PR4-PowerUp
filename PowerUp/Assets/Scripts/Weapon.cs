using UnityEngine;

public class Weapon : IWeapon
{
    public float Rate
    {
        get
        {
            return _config.Rate;
        }
    }

    public float Strength
    {
        get
        {
            return _config.Strength;
        }
    }


    public float Amount
    {
        get
        {
            return _config.Amount;
        }
    }

    public float Range
    {
        get
        {
            return _config.Range;
        }
    }

    private readonly WeaponConfig _config;

    public Weapon(WeaponConfig weaponConfig)
    {
        _config = weaponConfig;
    }
}
