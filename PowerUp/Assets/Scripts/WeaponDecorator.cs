public class WeaponDecorator : IWeapon
{
    private readonly IWeapon _decoratedWeapon;
    private readonly WeaponAttachment _attachment;

    public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
    {
        _decoratedWeapon = weapon;
        _attachment = attachment;
    }

    public float Rate
    {
        get
        {
            return _decoratedWeapon.Rate + _attachment.Rate;
        }
    }

    public float Strength
    {
        get
        {
            return _decoratedWeapon.Rate + _attachment.Rate;
        }
    }


    public float Amount
    {
        get
        {
            return _decoratedWeapon.Rate + _attachment.Rate;
        }
    }

    public float Range
    {
        get
        {
            return _decoratedWeapon.Rate + _attachment.Rate;
        }
    }
}
