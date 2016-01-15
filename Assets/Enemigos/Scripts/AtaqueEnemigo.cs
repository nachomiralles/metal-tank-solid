using UnityEngine;
using System.Collections;

public class AtaqueEnemigo : MonoBehaviour {


    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 2;
    private bool modoDisparoActivado = false;

    public void ActivarModoDisparo()
    {
        modoDisparoActivado = true;
        InvokeRepeating("disparar", 3, 1.0F);
    }

    public void DesactivarModoDisparo()
    {
        modoDisparoActivado = false;
        CancelInvoke("disparar");
    }

    private void disparar()
    {
        Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
        bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
        Destroy(bala.gameObject, 1);
    }

    public bool getModoDisparoActivado()
    {
        return modoDisparoActivado;
    }
}
