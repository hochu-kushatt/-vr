using UnityEngine;
using UnityEngine.EventSystems;

public class ForRobot : MonoBehaviour
{
    public float speed = 1.0f; // Скорость движения
    public float speed2 = 1.0f; // Скорость движения
    private float x = 9.3f;
    private float z = -1.3f;


    void Start()
    {
        print("Hello");
    }

    void Update()
    {
        // Определяем направление движения
        Vector3 moveDirection = new Vector3(-speed * Time.deltaTime, 0, 0);

        // Перемещаем объект
        transform.Translate(moveDirection);

        // Уменьшаем z
        x -= moveDirection.x;

        // Проверяем условие остановки движения
        if (x >= 11.9f)
        {
            // Устанавливаем z = -1.3f, чтобы объект не ушел дальше
            x = 11.9f;
            // Останавливаем движение
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