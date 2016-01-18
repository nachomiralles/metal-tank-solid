using UnityEngine;
using System.Collections;

public class AtaqueBalaEnemigo : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScriptDestruir des = other.gameObject.GetComponent<ScriptDestruir>();
            //this.GetComponentInParent<NavigatorMovement>().ParaDePerseguir();

            des.Destruir("Player");

            //Application.LoadLevel("EscenaFinPierdes");

        }
    }
}
