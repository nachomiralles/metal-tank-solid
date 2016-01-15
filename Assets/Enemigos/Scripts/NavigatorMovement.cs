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

    public void setPersiguiendo(bool p)
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
    }

    public bool estaPersiguiendo()
    {
        return persiguiendo;
    }

    public void SetNewObjective(Transform newOjective)
    {

        objetivo = newOjective;
    }

    private void ParaDePerseguir()
    {
        this.setPersiguiendo(false);
        scriptAtaque.DesactivarModoDisparo();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            print("Te toco");
            Application.LoadLevel("EscenaFinPierdes");
        }
    }


}
