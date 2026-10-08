using UnityEngine;

public class MirarAEsfera : MonoBehaviour
{
    private GameObject laEsfera;
    private Vector3 direction, posicionEsfera;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 1.5f;
        laEsfera = GameObject.FindWithTag("Esfera");
        posicionEsfera = laEsfera.transform.position;
        posicionEsfera.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(posicionEsfera);
        direction = posicionEsfera - transform.position;
        direction = direction.normalized;
        transform.Translate(direction * Time.deltaTime * speed, Space.World);
    }
}
