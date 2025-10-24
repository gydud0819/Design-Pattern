using UnityEngine;

public class ShotGun_C : Weapon
{
    public override void Fire()
    {
        Instantiate(bullet, bulletPoint.position, transform.rotation);
        Debug.Log("ShotGun_C Fire");
    }

    
}
