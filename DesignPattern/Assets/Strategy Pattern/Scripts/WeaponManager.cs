using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] int weaponCount;
    [SerializeField] List<Weapon> weapons;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        weapons[weaponCount].Fire();
    }

    void Swap()
    {
        weapons[weaponCount].gameObject.SetActive(false);

        weaponCount = (weaponCount + 1) % weapons.Count;

        weapons[weaponCount].gameObject.SetActive(true);

    }

}
