using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class CrawlspaceOpener : MonoBehaviour {

    public static bool open = false;

    public GameObject crawlspace;

	// Use this for initialization
	void Start () {
        crawlspace.SetActive(open);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OPEN() {
        //crawlspace.SetActive(true);
    }
}

public class HOOK : RuntimeMacros {
    [RuntimeMacro]
    public void OpenCrawlspace(string blah) {
        CrawlspaceOpener.open = true;
    }
}