using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class UISceneButton : MonoBehaviour, IPointerClickHandler {

    public string ToGoTo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerClick(PointerEventData pedata) {
        Debug.Log("works....");
        if (pedata.button == PointerEventData.InputButton.Left) {

            SceneTransition.GoToScene(ToGoTo);
        }
    }
}
