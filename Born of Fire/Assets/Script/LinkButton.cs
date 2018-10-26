using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using Cradle;
using Cradle.StoryFormats.Harlowe;

public class LinkButton : MonoBehaviour, IPointerClickHandler
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

    public void OnMouseDown()
    {
        Debug.Log("click.");
        onclick();
    }

    public void OnPointerClick(PointerEventData pedata) {
        if (pedata.button == PointerEventData.InputButton.Left) {
            Debug.Log("point");
            onclick();
        }
    }
}
