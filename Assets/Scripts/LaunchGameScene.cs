using UnityEngine;
using System.Collections;

public class LaunchGameScene : MonoBehaviour {

    public void OnClick()
    {
        
        print("Hola");
        Application.LoadLevel("EscenaDeJuego.");
    }

}
