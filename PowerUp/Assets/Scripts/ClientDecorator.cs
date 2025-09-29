using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private GunWeapon _gunWeapon;
    private bool _isAttached;

    void Start()
    {
        _gunWeapon = (GunWeapon)FindFirstObjectByType(typeof(GunWeapon));
    }

    void OnGUI()
    {
        if (!_isAttached)
        {
            if (GUILayout.Button("Put Attachments On"))
            {
                _gunWeapon.Decorate();
                _isAttached = !_isAttached;
            }
        }

        if (_isAttached)
        {
            if (GUILayout.Button("Reset Weapon"))
            {
                _gunWeapon.Reset();
                _isAttached = !_isAttached;
            }
        }

        if (GUILayout.Button("Toggle Fire"))
        {
            _gunWeapon.ToggleFire();
        }
    }
}
