using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private GunWeapon _gunWeapon;
    private bool _isAttached;
    private int attachNum;

    void Start()
    {
        _gunWeapon = (GunWeapon)FindFirstObjectByType(typeof(GunWeapon));
    }

    void OnGUI()
    {
        if (!_isAttached)
        {
            if (GUILayout.Button("Add Rate"))
            {
                attachNum = 1;
                _gunWeapon.Decorate(attachNum);
                _isAttached = !_isAttached;
            }

            if (GUILayout.Button("Add Strength"))
            {
                attachNum = 2;
                _gunWeapon.Decorate(attachNum);
                _isAttached = !_isAttached;
            }

            if (GUILayout.Button("Add Amount"))
            {
                attachNum = 3;
                _gunWeapon.Decorate(attachNum);
                _isAttached = !_isAttached;
            }

            if (GUILayout.Button("Add Range"))
            {
                attachNum = 4;
                _gunWeapon.Decorate(attachNum);
                _isAttached = !_isAttached;
            }
        }

        if (_isAttached)
        {
            if (GUILayout.Button("Reset Weapon"))
            {
                attachNum = 0;
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
