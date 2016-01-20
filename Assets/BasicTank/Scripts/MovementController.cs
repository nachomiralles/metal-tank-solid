using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{
    private CharacterController controller;
    public float velocidadGiro = 2.0f;
    public float velocidad = 5.0f;
    private Animator anim;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Mover();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("EscenaInicio");
        }

    }

    void Mover()
    {

        transform.Rotate(0, Input.GetAxis("Horizontal") * velocidadGiro, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float velocidadActual = velocidad * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * velocidadActual);

        if (velocidadActual != 0)
            anim.SetBool("moviendose", true);
        else
            anim.SetBool("moviendose", false);

    }
   
}