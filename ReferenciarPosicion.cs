using UnityEngine;
using UnityEngine.Animations;

public class ReferenciarPosicion : MonoBehaviour
{    
    private Vector3 posicion_inical;
    void Start()
    {
        posicion_inical = transform.position;
        Debug.Log("Posición inicial de la esfera " + posicion_inical);
    }

    void Update()
    {
        if (posicion_inical != transform.position)
        {
            Debug.Log("Posición nueva de la esfera " + transform.position);
            posicion_inical = transform.position;
        }
    }
    
}
