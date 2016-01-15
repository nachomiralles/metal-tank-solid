using UnityEngine;
using System.Collections;

public class ObjetivoAlcanzado : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        else if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
