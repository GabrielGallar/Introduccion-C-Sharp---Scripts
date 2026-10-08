using UnityEngine;

public class DetectarDesplazamiento : MonoBehaviour
{
    public Vector3 desplazamiento; 
    private Vector3 posicionInicial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") == 1) {
            transform.position = posicionInicial + desplazamiento;
        }
    }
}
