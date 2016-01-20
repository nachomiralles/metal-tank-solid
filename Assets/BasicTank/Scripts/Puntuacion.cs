using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Puntuacion : MonoBehaviour {

    private int cantidadMonedasActuales = 0;
    private int cantidadTanquesActuales = 0;

    private int cantidadMonedasNecesarias = 4;
    private int cantidadTanquesNecesarios = 8;


    public Text cantidadMonedas;
    public Text cantidadTanques;

    private GameObject[] todosLosEnemigos;
    public Transform posicionFinalCamara;

    public GameObject canvasGanas;

    void Start()
    {
        cantidadMonedas.text = cantidadMonedasActuales.ToString() + "/" + cantidadMonedasNecesarias.ToString();
        cantidadTanques.text = cantidadTanquesActuales.ToString() + "/" + cantidadTanquesNecesarios.ToString();
    }

    public void SumarMoneda()
    {
        cantidadMonedasActuales++;
        cantidadMonedas.text = cantidadMonedasActuales.ToString() + "/" + cantidadMonedasNecesarias.ToString();
        if (cantidadMonedasActuales == cantidadMonedasNecesarias)
        {
            Victoria();
        }
    }

    public void SumarTanque()
    {
        cantidadTanquesActuales++;
        cantidadTanques.text = cantidadTanquesActuales.ToString() + "/" + cantidadTanquesNecesarios.ToString();
        if (cantidadTanquesActuales == cantidadTanquesNecesarios)
        {
            Victoria();
        }
    }

    private void Victoria()
    {
        canvasGanas.SetActive(true);


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

        

        Camera.main.transform.position = posicionFinalCamara.position;
        Camera.main.transform.rotation = posicionFinalCamara.rotation;


    }

}
