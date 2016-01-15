using UnityEngine;
using System.Collections;

public class MoverEnemigo : MonoBehaviour
{
    public Transform punto1;
    public Transform punto2;
    private Transform objetivo;
    private Transform jugador;
    private bool persiguiendo = false;
    private bool disparando = false;
    private CharacterController controller;

    private int velocidadDisparo = 2;
    public Transform proyectil;
    public Transform posicionInicialBala;

    public float speed;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        objetivo = punto2;
    }

    void Update()
    {
        print(Vector3.Distance(transform.position, objetivo.position));
        if (!persiguiendo)
        {
            if (Vector3.Distance(transform.position, punto1.position) < 2.0f)
            {
                objetivo = punto2;
            }
            else if (Vector3.Distance(transform.position, punto2.position) < 2.0f)
            {
                objetivo = punto1;
            }
        }

        float step = speed * Time.deltaTime;
        transform.LookAt(objetivo,new Vector3(0,1,0));
        controller.SimpleMove(transform.forward * step);

        if (persiguiendo && !disparando)
        {
            disparando = true;
            InvokeRepeating("Atacar", 5, 1.0F);
        }

        if (persiguiendo)
        {
            if (Vector3.Distance(transform.position, objetivo.position) > 30.0f)
            {
                CancelInvoke("Atacar");
                disparando = false;
                persiguiendo = false;
                CambiarObjetivo(punto2);
            }
        }

        
    }

    public void CambiarObjetivo(Transform nuevoObjetivo)
    {
        persiguiendo = true;
        objetivo = nuevoObjetivo;
        transform.LookAt(objetivo);
    }

    private void Atacar()
    {
       
        Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
        bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
        Destroy(bala.gameObject, 1);
       


    }
}
