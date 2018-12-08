using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BranchShifter : MonoBehaviour, IPointerClickHandler {

    public UISceneButton toChange;
    public string branchMenuScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData pedata) {
        if (pedata.button == PointerEventData.InputButton.Left) {
            toChange.ToGoTo = branchMenuScene;
        }
    }
}
