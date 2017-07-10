using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : ActionItem {

    public string[] dialogue;

    public override void interact()
    {
        base.interact();
        DialogueSystem.Instance.addNewDialogue(dialogue, "Sign");
        Debug.Log("Interacting with sign post.");
    }
}
