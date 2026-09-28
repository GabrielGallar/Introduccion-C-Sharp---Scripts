using UnityEngine;

public class MedirDistancias : MonoBehaviour
{
    private Vector3 posicionCilindro, posicionCubo, posicion;
    private GameObject elCilindro, elCubo;
    void Start()
    {
        elCilindro = GameObject.FindWithTag("Cilindro");
        elCubo = GameObject.FindWithTag("Cubo");
        posicion = transform.position;
        posicionCilindro = elCilindro.transform.position;
        posicionCubo = elCubo.transform.position;
        MedimosDistancias(posicionCilindro, posicionCubo);   
    }
    void MedimosDistancias(Vector3 posicionCilindro, Vector3 posicionCubo)
    {
        float distanciaCilindro = Vector3.Distance(posicionCilindro, transform.position);
        float distanciaCubo = Vector3.Distance(posicionCubo, transform.position);
        Debug.Log("Distancia del Cilindro: " + distanciaCilindro);
        Debug.Log("Distancia del Cubo: " + distanciaCubo);
    }

    void Update()
    {
        if (elCilindro.transform.position != posicionCilindro || elCubo.transform.position != posicionCubo || transform.position != posicion)
        {
            MedimosDistancias(elCilindro.transform.position, elCubo.transform.position);
            posicionCilindro = elCilindro.transform.position;
            posicionCubo = elCubo.transform.position;
            posicion = transform.position;
        }
    }
    
    
}
