using UnityEngine;

public class ForTabletka : MonoBehaviour
{
    public float speed = 1.0f; // �������� ��������
    public float speed2 = 1.0f; // �������� ��������
    private float z = 1.3f;
    private float y = 1.54f;

    void Start()
    {
        print("Hello");
    }

    void Update()
    {
        // ���������� ����������� ��������
        Vector3 moveDirection = new Vector3(0, 0, -speed * Time.deltaTime);

        // ���������� ������
        transform.Translate(moveDirection);

        // ��������� z
        z += moveDirection.z;

        // ��������� ������� ��������� ��������
        if (z <= -3.2f)
        {
            // ������������� z = -1.3f, ����� ������ �� ���� ������
            z = -3.2f;
            // ������������� ��������
            speed = 0;


        }

        //Vector3 moveTabletka = new Vector3(0, speed2 * Time.deltaTime, 0);
        //
        //// ���������� ������
        //transform.Translate(moveTabletka);
        //
        //// ��������� z
        //y -= moveTabletka.y;
        //
        //// ��������� ������� ��������� ��������
        //if (y <= 1.6f)
        //{
        //    // ������������� z = -1.3f, ����� ������ �� ���� ������
        //    y = 1.6f;
        //    // ������������� ��������
        //    speed2 = 0;
        //}
        //
    }
}