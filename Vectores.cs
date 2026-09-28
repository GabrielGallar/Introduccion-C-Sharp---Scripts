using UnityEngine;

public class Vectores : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;

    void OnValidate()
    {
        Debug.Log("Magnitudes vector1-vector2: " + vector1.magnitude + " " + vector2.magnitude);
        Debug.Log("Angulo entre los 2 vectores: " + Vector3.Angle(vector1, vector2));
        Debug.Log("Distancia entre ellos: " + Vector3.Distance(vector1, vector2));
        if (vector1.y > vector2.y)
        {
            Debug.Log("El vector1 está a una altura mayor");
        }
        else if (vector1.y < vector2.y)
        {
            Debug.Log("El vector2 está a una altura mayor");
        }
        else
        {
            Debug.Log("Los vectores están a una misma altura");
        }
    }    
    
}
