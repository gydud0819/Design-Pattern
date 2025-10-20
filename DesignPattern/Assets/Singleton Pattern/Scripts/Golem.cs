using Unity.VisualScripting;
using UnityEngine;

public class Golem : MonoBehaviour
{
    // size : 0 ~ 1
    [SerializeField] Vector3 size;
    [SerializeField] private float min = 1f;

  
    private void Update()
    {
        float scale = Mathf.PingPong(Time.time, min);
        transform.localScale = new Vector3(scale, scale, scale);
       

    }
}
