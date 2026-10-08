using UnityEngine;

public class MoverDireccion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 moveDirection; 
    public float speed;
    void Start()
    {
        speed = 1.5f;
        transform.position = new (transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //Ejes locales
        transform.Translate(moveDirection.x * speed * Time.deltaTime, moveDirection.y * Time.deltaTime * speed, moveDirection.z * speed * Time.deltaTime);
        //Ejes Globales
        //transform.Translate(moveDirection.x * speed * Time.deltaTime, moveDirection.y * Time.deltaTime * speed, moveDirection.z * speed * Time.deltaTime, Space.World);
    }
}
