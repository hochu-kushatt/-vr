using UnityEngine;
using UnityEngine.EventSystems;

public class ForRobot : MonoBehaviour
{
    public float speed = 1.0f; // �������� ��������
    public float speed2 = 1.0f; // �������� ��������
    private float x = 9.3f;
    private float z = -1.3f;


    void Start()
    {
        print("Hello");
    }

    void Update()
    {
        // ���������� ����������� ��������
        Vector3 moveDirection = new Vector3(-speed * Time.deltaTime, 0, 0);

        // ���������� ������
        transform.Translate(moveDirection);

        // ��������� z
        x -= moveDirection.x;

        // ��������� ������� ��������� ��������
        if (x >= 11.9f)
        {
            // ������������� z = -1.3f, ����� ������ �� ���� ������
            x = 11.9f;
            // ������������� ��������
            speed = 0;

            Vector3 moveDirection2 = new Vector3(0, 0, speed2 * Time.deltaTime);
            transform.Translate(moveDirection2);
            z -= moveDirection2.z;
            if (z <= -3.2f)
            {
                z = -3.2f;
                speed2 = 0;
            }
        }


       
    }
}