using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

    private int puntosActuales = 0;
    private int puntosNecesarios = 3;

    public void SumarMoneda()
    {
        puntosActuales++;
        print("Llevas " + puntosActuales + " monedas recogidas.");
        if (puntosActuales == puntosNecesarios)
        {
            print("Has ganado");
        }
    }

}
