using UnityEngine;

public class ForTabletka : MonoBehaviour
{
    public float speed = 1.0f; // Скорость движения
    public float speed2 = 1.0f; // Скорость движения
    private float z = 1.3f;
    private float y = 1.54f;

    void Start()
    {
        print("Hello");
    }

    void Update()
    {
        // Определяем направление движения
        Vector3 moveDirection = new Vector3(0, 0, -speed * Time.deltaTime);

        // Перемещаем объект
        transform.Translate(moveDirection);

        // Уменьшаем z
        z += moveDirection.z;

        // Проверяем условие остановки движения
        if (z <= -3.2f)
        {
            // Устанавливаем z = -1.3f, чтобы объект не ушел дальше
            z = -3.2f;
            // Останавливаем движение
            speed = 0;


        }

        //Vector3 moveTabletka = new Vector3(0, speed2 * Time.deltaTime, 0);
        //
        //// Перемещаем объект
        //transform.Translate(moveTabletka);
        //
        //// Уменьшаем z
        //y -= moveTabletka.y;
        //
        //// Проверяем условие остановки движения
        //if (y <= 1.6f)
        //{
        //    // Устанавливаем z = -1.3f, чтобы объект не ушел дальше
        //    y = 1.6f;
        //    // Останавливаем движение
        //    speed2 = 0;
        //}
        //
    }
}