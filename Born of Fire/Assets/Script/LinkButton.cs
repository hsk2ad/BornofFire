using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

using Cradle;
using Cradle.StoryFormats.Harlowe;

public class LinkButton : MonoBehaviour, IPointerClickHandler
{

    public static readonly Color ACTIVE_COLOR = new Color((77f / 255f), (219f / 255f), (212f / 255f));
    public static readonly Color INACTIVE_COLOR = new Color(1, 1, 1);

    public delegate void ClickFunction();

    public Text textbox;

    string text;

   public bool live;

    public ClickFunction onclick;

    // Use this for initialization
    void Start()
    {
        //Activate();
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
        if(!live) {
            return;
        }
        if (pedata.button == PointerEventData.InputButton.Left) {
            Debug.Log("point");
            onclick();
        }
    }

    public void Initialize(ClickFunction _del, string _text) {
        SetDelegate(_del);

        text = _text;

        Activate();
    }

    public void Activate() {
        textbox.text = text;
        textbox.color = ACTIVE_COLOR;
        live = true;
    }

    public void Deactivate(bool wasSelected = false) {
        if(!wasSelected) {
            textbox.text = "//" + text;
        }
        live = false;
        textbox.color = INACTIVE_COLOR;
    }
}
