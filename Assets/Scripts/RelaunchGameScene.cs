using UnityEngine;
using System.Collections;

public class RelaunchGameScene : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("EscenaInicio");
        }
    }
}
