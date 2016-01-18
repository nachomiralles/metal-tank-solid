using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 2;
    private GameObject[] todosLosEnemigos;

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

            ActivarPersecucion();
        }
	}

    void ActivarPersecucion()
    {
        todosLosEnemigos = GameObject.FindGameObjectsWithTag("Enemigo");
        for (var i = 0; i < todosLosEnemigos.Length; i++)
        {
            if (todosLosEnemigos[i])
            {
                todosLosEnemigos[i].GetComponent<NavigatorMovement>().Perseguir(this.transform);
            }
        }
    }
}
