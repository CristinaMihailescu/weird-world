using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {

    public static DialogueSystem Instance { get; set; }

    public List<string> dialogueLines;
    public string npcName;
    public GameObject dialoguePanel;

    Button continueButton;
    Text dialogueText, nameText, continueButtonText;
    int dialogueIndex;

	void Awake () {
        continueButton = dialoguePanel.transform.Find("Continue").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.Find("Text").GetComponent<Text>();
        nameText = dialoguePanel.transform.Find("Name").GetChild(0).GetComponent<Text>();
        continueButtonText = dialoguePanel.transform.Find("Continue").Find("Text").GetComponent<Text>();

        continueButton.onClick.AddListener(delegate { continueDialog(); });

        dialoguePanel.SetActive(false);

		if(Instance != null && Instance != this)
        {
            DestroyObject(Instance);
        }
        else
        {
            Instance = this;
        }
	}
	
	public void addNewDialogue (string[] dialogue, string npcName) {
        dialogueIndex = 0;

        this.npcName = npcName;

        dialogueLines = new List<string>(dialogue.Length);
        dialogueLines.AddRange(dialogue);

        createDialog();
	}

    public void createDialog()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;

        if(dialogueLines.Count == 1)
        {
            continueButtonText.text = "Got it!";
        }
        dialoguePanel.SetActive(true);        
    }

    public void continueDialog()
    {
        if (dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
    
            if (dialogueIndex == dialogueLines.Count - 1)
            {
                continueButtonText.text = "Got it!";
            }
        }
        else
        {
            dialoguePanel.SetActive(false);
            continueButtonText.text = "Continue";
        }
    }
}
