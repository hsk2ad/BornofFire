using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Dialogue))]
public class ScriptAutoPlayer : MonoBehaviour {

	// Use this for initialization
    IEnumerator Start () {
        yield return new WaitForEndOfFrame();
        GetComponent<Dialogue>().OpenDialogueWindow();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
