using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public Gun gun;
    private bool isHoldingShoot;
    public Transform gunHolder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
    public void OnDrop()
    {
        if (gun != null)
        {
            gun.Drop();
            gun = null;
        }
    }

    void OnShoot()
    {
        isHoldingShoot = true;
    }

    // Update is called once per frame
    void OnShootRelease()
    {
        isHoldingShoot=false;
    }

    void OnReload()
    {
        if (gun != null)
            gun.TryReload();
    }

    void Update()
    {
        if (isHoldingShoot && gun != null)
            gun.Shoot();
    }
}
