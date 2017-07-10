using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour { //obiectul cu care vreau sa interactionez

    public UnityEngine.AI.NavMeshAgent playerAgent;

    public virtual void moveToInteraction(UnityEngine.AI.NavMeshAgent playerAgent)
    {
        this.playerAgent = playerAgent; //playerul in sine
        playerAgent.destination = this.transform.position;

        interact();
    }

    public virtual void interact()
    {
        Debug.Log("Interacting with base class.");
    }
}
