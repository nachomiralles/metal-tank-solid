using UnityEngine;
using System.Collections;

public class RecogerMoneda : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Puntuacion>().SumarMoneda();
            Destroy(this.gameObject);
        }
    }
}
