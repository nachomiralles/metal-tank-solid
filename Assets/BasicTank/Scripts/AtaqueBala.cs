using UnityEngine;
using System.Collections;

public class AtaqueBala : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            ScriptDestruir des = other.gameObject.GetComponent<ScriptDestruir>();
            des.Destruir("Enemigo");

            //Application.LoadLevel("EscenaFinPierdes");

        }
    }
}
