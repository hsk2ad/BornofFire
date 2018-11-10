using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Dialogue))]
public class UIDialogueTrigger : MonoBehaviour, IPointerClickHandler {

    public Dialogue[] DialoguesToTrigger;

    public bool cycles = false;

    int counter = 0;

    Dialogue currentDialogue;

    // Use this for initialization
    void Start() {
        if (DialoguesToTrigger.Length > 0) {

        }
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnPointerClick(PointerEventData pedata) {
        if(pedata.button == PointerEventData.InputButton.Left) {
            Debug.Log("ENENNERNENATGFGSD");

            if (currentDialogue != null && currentDialogue.open) {
                return;
            }
            int realCount = cycles ? (counter % DialoguesToTrigger.Length) : (Mathf.Min(counter, DialoguesToTrigger.Length - 1));
            if (realCount < 0) {
                return;
            }

            currentDialogue = DialoguesToTrigger[realCount];
            currentDialogue.OpenDialogueWindow();
            counter++;
        }
    }
}
