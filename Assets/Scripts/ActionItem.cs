using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionItem : Interactable {

    public override void interact()
    {
        base.interact();
        Debug.Log("Interracting with base action item.");
    }
}
