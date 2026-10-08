using UnityEngine;
using UnityEngine.InputSystem;

public class MapearFire : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") == 1)
        {
            if (Input.GetKey(KeyCode.H)) 
            {
                Debug.Log("Accionada la función Fire con H");
            }
        }
    }
}
