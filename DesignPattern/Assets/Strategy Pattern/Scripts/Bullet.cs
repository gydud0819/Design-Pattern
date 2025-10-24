using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int speed = 10;

    [SerializeField] Transform createPosition;

    private void Awake()
    {
        
    }
    private void Start()
    {
        Destroy(gameObject, 2);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }



}
