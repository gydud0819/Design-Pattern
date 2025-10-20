using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // rotation : y축 회전
    [SerializeField] private float speed = 50f;
     
    private void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
       
          // 주기적으로 값을 반복시키는 데 사용되는 함수 
            // t : 시간이나 변화하는 값(Time.time), length : 반복할 범위
    }
}
