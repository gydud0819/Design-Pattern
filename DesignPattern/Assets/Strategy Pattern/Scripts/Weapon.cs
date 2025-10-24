using Unity.VisualScripting;
using UnityEngine;

abstract public class Weapon : MonoBehaviour
{
    [SerializeField] protected Transform bulletPoint;
    [SerializeField] protected GameObject bullet;
    
    abstract public void Fire();
}
