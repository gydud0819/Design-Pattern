using UnityEngine;

public class ShotGun_A : Weapon
{
    public override void Fire()
    {
        Instantiate(bullet, bulletPoint.position, transform.rotation);
        Debug.Log("ShotGun_A Fire");
    }
}
