using UnityEngine;
using System.Collections;

public class AtaqueBala : MonoBehaviour
{
    private Puntuacion scriptPuntuacion;
    private bool colisionando = false;

    void Start()
    {
        scriptPuntuacion = GameObject.Find("PlayerTank").GetComponent<Puntuacion>();
    }

    void Update()
    {
        colisionando = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            if (colisionando) return;
            colisionando = true;
            ScriptDestruir des = other.gameObject.GetComponent<ScriptDestruir>();
            des.Destruir("Enemigo");
            scriptPuntuacion.SumarTanque();

            //Application.LoadLevel("EscenaFinPierdes");

        }
    }
}
