using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class GunWeapon : MonoBehaviour
{
    public WeaponConfig weaponConfig;
    public WeaponAttachment attachment1;
    public WeaponAttachment attachment2;
    public WeaponAttachment attachment3;
    public WeaponAttachment attachment4;

    public ParticleSystem baseConfig;
    public ParticleSystem attachParticle1;
    public ParticleSystem attachParticle2;
    public ParticleSystem attachParticle3;
    public ParticleSystem attachParticle4;

    private IWeapon _weapon;
    private bool _isDecorated;
    private bool _isFiring;
    private int partAttach = 0;


    public void Start()
    {
        _weapon = new Weapon(weaponConfig);

        Debug.Log("baseConfig: " + (baseConfig != null));
        Debug.Log("attachParticle1: " + (attachParticle1 != null));

    }

    public void ToggleFire()
    {
        _isFiring = !_isFiring;

        if (_isFiring )
        {
            StartCoroutine(FireWeapon());
        }
    }
   
    IEnumerator FireWeapon()
    {
        float fireRate = 20.0f / _weapon.Rate;

        while (_isFiring)
        {
            yield return new WaitForSeconds(fireRate);
            Debug.Log("Firing");

            switch(partAttach)
            {
                case 1:
                    attachParticle1.Play(true);
                    break;
                case 2:
                    attachParticle2.Play(true);
                    break;
                case 3:
                    attachParticle3.Play(true);
                    break;
                case 4:
                    attachParticle4.Play(true);
                    break;
                default:
                    //baseConfig.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
                    baseConfig.Play(true);
                    break;  
            }
        }
    }

    public void Reset()
    {
        _weapon = new Weapon(weaponConfig);
        _isDecorated = !_isDecorated;
        partAttach = 0;
    }

    public void Decorate(int attach)
    {
        if (attach == 1)
        {
            _weapon = new WeaponDecorator(_weapon, attachment1);
            partAttach = 1;
            Debug.Log("Attached 1");
            Debug.Log(partAttach);
        }

        if (attach == 2)
        {
            _weapon = new WeaponDecorator(_weapon, attachment2);
            partAttach = 2;
        }

        if (attach == 3)
        {
            _weapon = new WeaponDecorator(_weapon, attachment3);
            partAttach = 3;
        }

        if (attach == 4)
        {
            _weapon = new WeaponDecorator(_weapon, attachment4);
            partAttach = 4;
        }
    }
}
