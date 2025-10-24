using UnityEngine;

public class ShotGun_B : Weapon
{
    public override void Fire()
    {
        Instantiate(bullet, bulletPoint.position, transform.rotation);
        Debug.Log("ShotGun_B Fire");
    }

    
}
