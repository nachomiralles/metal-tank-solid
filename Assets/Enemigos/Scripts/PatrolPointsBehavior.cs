using UnityEngine;
using System.Collections;

public class PatrolPointsBehavior : MonoBehaviour
{

    public Transform otherPatrolPoint;
    public Transform tank;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == tank)
        {
            NavigatorMovement agenteEnemigo = other.gameObject.GetComponent<NavigatorMovement>();
            if(!agenteEnemigo.estaPersiguiendo())
                agenteEnemigo.SetNewObjective(otherPatrolPoint);
        }
    }
}