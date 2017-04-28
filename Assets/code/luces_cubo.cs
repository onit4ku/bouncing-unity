using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luces_cubo : MonoBehaviour
{
    private Rigidbody body;

    // Use this for initialization
    void Start()
    {

    }
    void Awake()
    {
        body = gameObject.GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void CambiarLuz() {
        Light luz = gameObject.GetComponent<Light>();

        Color color = new Color();

        color.r = Random.Range(0.0f, 1.0f);

        color.g = Random.Range(0.0f, 1.0f);

        color.b = Random.Range(0.0f, 1.0f);

        luz.color = color;

    }


    void AplicarFuerza() {
        Vector3 fuerza = new Vector3();

        fuerza.x = Random.Range(-10.0f, 10.0f);                            
        fuerza.y = Random.Range(-10.0f, 10.0f);                         
        fuerza.z = Random.Range(-10.0f, 10.0f);

        body.AddForce(fuerza, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        CambiarLuz();
        if (collision.gameObject.tag == "Suelo")
        {
            AplicarFuerza();

        }
    }
}
