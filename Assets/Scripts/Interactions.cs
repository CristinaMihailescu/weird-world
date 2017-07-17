using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactions : MonoBehaviour {

    NavMeshAgent playerAgent;

	void Start () {
        playerAgent = GetComponent<NavMeshAgent>();
	}

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        { //left click pressed? && not click on UI element?
            getInteraction();
        }
    }

    void getInteraction()
    {
        Ray iRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(iRay.origin, iRay.direction * 10, Color.yellow);
        RaycastHit iInfo;
        if(Physics.Raycast(iRay, out iInfo, Mathf.Infinity)) //ce lovesc stochez in iInfo
        {
            GameObject iObject = iInfo.collider.gameObject; //the object that we hit with the raycast
            //things like ground are not interactable
            if (iObject.tag == "Interactable Object")
            {
                iObject.GetComponent<Interactable>().moveToInteraction(playerAgent);
            }
            else //move player
            {
                playerAgent.stoppingDistance = 0f;
                playerAgent.destination = iInfo.point;
            }
            DialogueSystem.Instance.setInactive();
        }
    }
}
