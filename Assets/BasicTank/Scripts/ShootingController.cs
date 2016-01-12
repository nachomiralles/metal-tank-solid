using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 2;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
            bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
            Destroy(bala.gameObject, 5);
        }
	}
}
