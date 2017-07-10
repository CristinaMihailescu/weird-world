using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Interactable {

    public string npcName;
    public string[] dialogue;

	public override void interact()
    {
        DialogueSystem.Instance.addNewDialogue(dialogue, npcName);
        Debug.Log("Interacting with NPC.");
    }
}
