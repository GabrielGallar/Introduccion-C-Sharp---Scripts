using UnityEngine;

public class MoverCubo : MonoBehaviour
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
        if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        }
        
    }
}
