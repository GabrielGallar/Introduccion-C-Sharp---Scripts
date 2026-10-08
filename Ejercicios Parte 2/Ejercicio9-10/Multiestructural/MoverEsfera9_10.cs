using UnityEngine;

public class MoverEsfera : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 1.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W)))
        {
            transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        }
        
    }
}
