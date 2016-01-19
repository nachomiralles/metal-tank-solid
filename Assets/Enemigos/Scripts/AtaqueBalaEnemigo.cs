using UnityEngine;
using System.Collections;

public class AtaqueBalaEnemigo : MonoBehaviour {
    private bool colisionando = false;
    void Update()
    {
        colisionando = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (colisionando) return;
            colisionando = true;
            ScriptDestruir des = other.gameObject.GetComponent<ScriptDestruir>();
            //this.GetComponentInParent<NavigatorMovement>().ParaDePerseguir();

            des.Destruir("Player");

            //Application.LoadLevel("EscenaFinPierdes");

        }
    }


}
