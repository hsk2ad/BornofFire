using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Cradle;
using Cradle.StoryFormats.Harlowe;

public class Dialogue : MonoBehaviour {

    public Story story;

    public GameObject textTemplate;
    public GameObject linkTemplate;
    public GameObject linebreakTemplate;

    public GameObject DialogueContainer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Display(StoryOutput output) {
        GameObject UIchild = GenerateUIElement(output);
        AppendToConsole(UIchild);
    }
     
    public void DoLink(StoryLink link) {

    }

    GameObject GenerateUIElement(StoryOutput output) {
        if(output is StoryText) {
            GameObject newTextElement = Instantiate(textTemplate);
            Text visibleText = newTextElement.GetComponent<Text>();
            visibleText.text = output.Text;

            return newTextElement;
        } else if(output is StoryLink) {
            GameObject newLinkElement = Instantiate(linkTemplate);
            Text visibleText = newLinkElement.GetComponent<Text>();
            visibleText.text = output.Text;

            LinkButton link = newLinkElement.GetComponent<LinkButton>();
            link.SetDelegate(() => {
                DoLink((StoryLink)output);
            });

            return newLinkElement;
        } else if(output is LineBreak) {
            GameObject newLinebreakElement = Instantiate(linebreakTemplate);

            return newLinebreakElement;
        }
        return null;
    }

    void AppendToConsole(GameObject uiElement) {

    }
}
