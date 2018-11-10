using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {


    public Dialogue[] DialoguesToTrigger;

    public bool cycles = false;

    int counter = 0;

    Dialogue currentDialogue;

	// Use this for initialization
	void Start () {
        if(DialoguesToTrigger.Length > 0) {

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown() {

        Debug.Log("ENENNERNENATGFGSD");

        if(currentDialogue != null && currentDialogue.open) {
            return;
        }
        int realCount = cycles ? (counter % DialoguesToTrigger.Length) : (Mathf.Min(counter, DialoguesToTrigger.Length - 1));
        if(realCount < 0) {
            return;
        }

        currentDialogue = DialoguesToTrigger[realCount];
        currentDialogue.OpenDialogueWindow();
        counter++;
    }
}
