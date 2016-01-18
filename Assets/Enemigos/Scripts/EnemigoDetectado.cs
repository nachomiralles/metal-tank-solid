using UnityEngine;
using System.Collections;

public class EnemigoDetectado : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            NavigatorMovement agenteEnemigo = transform.parent.GetComponent<NavigatorMovement>();
            agenteEnemigo.Perseguir(other.transform);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            NavigatorMovement agenteEnemigo = transform.parent.GetComponent<NavigatorMovement>();
            agenteEnemigo.Perseguir(other.transform);

        }
    }
}
