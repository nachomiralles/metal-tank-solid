using UnityEngine;
using System.Collections;

public class NavigatorMovement : MonoBehaviour
{

    public Transform objetivoInicial;
    private Transform objetivo;
    private NavMeshAgent agente;
    private bool persiguiendo = false;
    private AtaqueEnemigo scriptAtaque;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        scriptAtaque = GetComponent<AtaqueEnemigo>();
        objetivo = objetivoInicial;
    }

    void Update()
    {
        agente.SetDestination(objetivo.position);
    }

   /*public void setPersiguiendo(bool p)
    {
        if (!p)
        {
            this.SetNewObjective(objetivoInicial);
        }
        else if (p)
        {
            CancelInvoke("ParaDePerseguir");
            if (!scriptAtaque.getModoDisparoActivado())
            {
                scriptAtaque.ActivarModoDisparo();
            }
            Invoke("ParaDePerseguir", 5.0f);
        }
        persiguiendo = p;
    }*/

    public void Perseguir(Transform nuevoObjetivo)
    {
        CancelInvoke("ParaDePerseguir");
        if (!scriptAtaque.getModoDisparoActivado())
        {
            scriptAtaque.ActivarModoDisparo();
        }
        Invoke("ParaDePerseguir", 5.0f);
        objetivo = nuevoObjetivo;
        persiguiendo = true;
    }

    public bool estaPersiguiendo()
    {
        return persiguiendo;
    }

    public void SetNewObjective(Transform newOjective)
    {
        objetivo = newOjective;
    }

    public void ParaDePerseguir()
    {
        // this.setPersiguiendo(false);
        objetivo = objetivoInicial;
        scriptAtaque.DesactivarModoDisparo();
        persiguiendo = false;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            ScriptDestruir des = other.gameObject.GetComponent<ScriptDestruir>();
            des.Destruir("Player");
            
        }
    }

}
