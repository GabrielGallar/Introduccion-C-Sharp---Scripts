using UnityEngine;

public class GirarYMoverAdelante : MonoBehaviour
{
    public float speed, rotateSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 1.5f;
        rotateSpeed = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * rotateSpeed * Time.deltaTime, 0);
        transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
        Debug.DrawRay(transform.position, transform.forward * 2, Color.red);
    }
}
