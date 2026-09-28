using UnityEngine;


public class CambiarColor : MonoBehaviour
{
    public int framesEspera = 120;
    private Renderer renderizado;
    private Color colorNuevo;
    void Start()
    {
        colorNuevo = new Vector4 (Random.value, Random.value, Random.value);

        renderizado = GetComponent<Renderer>();
        if (renderizado == null)
        {
            Debug.LogError("No hay un Renderer");
            return;
        }
        renderizado.material.color = colorNuevo; 
        
    }

    void Update ()
    {
        if (Time.frameCount % framesEspera == 0)
        {
            int posicion = Random.Range(0,3);
            if (posicion == 0)
            {
                colorNuevo.r = Random.value;
            }
            if (posicion == 1)
            {
                colorNuevo.g = Random.value;
            }
            else
            {
                colorNuevo.b = Random.value;
            }
            renderizado.material.color = colorNuevo;
        }

    }
    
}
