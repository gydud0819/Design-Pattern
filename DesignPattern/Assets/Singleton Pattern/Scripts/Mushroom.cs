using UnityEngine;

public class Mushroom : MonoBehaviour
{
    // rotation : y�� ȸ��
    [SerializeField] private float speed = 50f;
     
    private void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
       
          // �ֱ������� ���� �ݺ���Ű�� �� ���Ǵ� �Լ� 
            // t : �ð��̳� ��ȭ�ϴ� ��(Time.time), length : �ݺ��� ����
    }
}
