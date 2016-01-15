using UnityEngine;
using System.Collections;

public class AtaqueBalaEnemigo : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.LoadLevel("EscenaFinPierdes");

        }
    }
}
