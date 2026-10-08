using UnityEngine;

public class CalcularVelocidad : MonoBehaviour
{
    public float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        velocidad = 1;   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        { 
            string teclaPulsada;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                teclaPulsada = "UpArrow";
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                teclaPulsada = "DownArrow";
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                teclaPulsada = "RightArrow";
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                teclaPulsada = "LeftArrow";
            }
            else
            {
                teclaPulsada = " ";
            }
            
            if (teclaPulsada != " ") 
            {
                Debug.Log(teclaPulsada + " Vertical: " + velocidad * Input.GetAxis("Vertical") + " Horizontal: " + velocidad * Input.GetAxis("Horizontal"));
            } 
        }   
    }
}
