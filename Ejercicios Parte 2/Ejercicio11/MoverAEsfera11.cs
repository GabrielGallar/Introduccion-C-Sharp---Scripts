using UnityEngine;

public class MoverAEsfera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private GameObject laEsfera;
    private Vector3 direction;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 1.5f;
        laEsfera = GameObject.FindWithTag("Esfera");
    }

    // Update is called once per frame
    void Update()
    {
        direction = laEsfera.transform.position - transform.position;
        direction.y = 0;
        direction = direction.normalized;
        transform.Translate(direction * Time.deltaTime * speed, Space.World);
    }
}
