using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Cradle;
using Cradle.StoryFormats.Harlowe;

public class LinkButton : MonoBehaviour
{

    public delegate void ClickFunction();

    public ClickFunction onclick;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetDelegate(ClickFunction del) {
        onclick = del;
    }

    private void OnMouseDown()
    {
        onclick();
    }
}
