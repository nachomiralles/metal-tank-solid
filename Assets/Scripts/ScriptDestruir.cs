using UnityEngine;
using System.Collections;

public class ScriptDestruir : MonoBehaviour {

    public ParticleSystem explosion;

    private GameObject[] todosLosEnemigos;
    public Transform posicionFinalCamara;

     
    public void Destruir(string muerto)
    {
        Instantiate(explosion, transform.position, transform.rotation);

        if (muerto == "Enemigo")
        {
            Destroy(this.gameObject);
        }

        if (muerto == "Player")
        {
            todosLosEnemigos = GameObject.FindGameObjectsWithTag("Enemigo");
            for (var i = 0; i < todosLosEnemigos.Length; i++)
            {
                if (todosLosEnemigos[i])
                {
                    todosLosEnemigos[i].GetComponent<NavigatorMovement>().ParaDePerseguir();
                }
            }
            CharacterController controlador = this.gameObject.GetComponent<CharacterController>();
            MovementController scriptMovimiento = this.gameObject.GetComponent<MovementController>();
            ShootingController scriptDisparo = this.gameObject.GetComponent<ShootingController>();
            scriptMovimiento.enabled = false;
            controlador.enabled = false;
            scriptDisparo.enabled = false;

            var tankRenderer = transform.Find("TankRenderers");
            Destroy(tankRenderer.gameObject);

            Camera.main.transform.position = posicionFinalCamara.position;
            Camera.main.transform.rotation = posicionFinalCamara.rotation;

        }

    }
}
