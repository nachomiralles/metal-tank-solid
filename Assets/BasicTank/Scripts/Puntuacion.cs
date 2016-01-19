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

    void Start()
    {
        cantidadMonedas.text = cantidadMonedasActuales.ToString();
        cantidadTanques.text = cantidadTanquesActuales.ToString();
    }

    public void SumarMoneda()
    {
        cantidadMonedasActuales++;
        cantidadMonedas.text = cantidadMonedasActuales.ToString();
        if (cantidadMonedasActuales == cantidadMonedasNecesarias)
        {
            Victoria();
        }
    }

    public void SumarTanque()
    {
        cantidadTanquesActuales++;
        cantidadTanques.text = cantidadTanquesActuales.ToString();
        if (cantidadTanquesActuales == cantidadTanquesNecesarios)
        {
            Victoria();
        }
    }

    private void Victoria()
    {
        print("Has Ganado!");
    }

}
