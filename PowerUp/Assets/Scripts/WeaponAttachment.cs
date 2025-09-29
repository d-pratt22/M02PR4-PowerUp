using System.IO.Enumeration;
using System.Net.Mail;
using UnityEngine;



[CreateAssetMenu(fileName = "NewWeaponAttachment", menuName = "Weapon/Attachment", order = 1)]

public class WeaponAttachment : ScriptableObject, IWeapon
{
    [Range(0, 50)]
    [Tooltip("Increase rate of firing per second")]
    [SerializeField] public float rate;

    [Range(0, 50)]
    [Tooltip("Increase strength")]
    [SerializeField] public float strength;

    [Range(0, 20)]
    [Tooltip("Increase amount of projectiles")]
    [SerializeField] public float amount;

    [Range(0, 50)]
    [Tooltip("Increase weapon range")]
    [SerializeField] float range;

    public string attachmentName;
    public GameObject attachmentPrefab;
    public string attachmentDescription;

    public float Rate
    {
        get
        {
            return rate;
        }
    }

    public float Strength
    {
        get
        {
            return strength;
        }
    }


    public float Amount
    {
        get
        {
            return amount;
        }
    }

    public float Range
    {
        get
        {
            return range;
        }
    }

}
