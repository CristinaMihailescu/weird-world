using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : Interactable {

    public override void interact()
    {
        base.interact();
        Debug.Log("Interacting with item.");
    }
}
