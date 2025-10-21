using Unity.Properties;
using UnityEngine;

public class Bat : MonoBehaviour
{
    // position : yรเ -1 ~ 1
   [SerializeField] private float speed = 1f;


    private void Update()
    {
        float position = Mathf.PingPong(Time.time * speed, 2f) - 1f;
        transform.position = new Vector3(transform.position.x, position, transform.position.z);
        if (GameManager.Instance.State == false) { return; }
      
    }
}
