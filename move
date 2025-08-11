using UnityEngine;

public class Move : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Створення нової позиції для персонажа (координата з якого він стартує та координати)
        Vector3 newPosition;
        //Чотке пояснення ДЕ зараз стоїть персонаж щоб надалі його рухати від координати
        newPosition = transform.position;

        newPosition.x -= speed * Time.deltaTime;

        transform.position = newPosition;

    }
}
