using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Cradle;
using Cradle.StoryFormats.Harlowe;

public class Dialogue : MonoBehaviour {

#region Fields
    public Story story;

    public GameObject textTemplate;
    public GameObject linkTemplate;
    public GameObject linebreakTemplate;
    public GameObject spacerTemplate;

    public GameObject dialogueContainer;

    public ScrollRect consoleScroll;

    public float updateTime = 20;
    public float updateBuffer = 0;

    bool scrolling;

    bool open;

    Queue<QueuedAction> queue;
#endregion

    // Use this for initialization
    void Start () {

        if(textTemplate == null) {
            textTemplate = Resources.Load(@"Prefabs/Text") as GameObject;
        }

        if (linkTemplate == null) {
            linkTemplate = Resources.Load(@"Prefabs/Link") as GameObject;
        }

        if (linebreakTemplate == null) {
            linebreakTemplate = Resources.Load(@"Prefabs/Text") as GameObject;
        }

        if (spacerTemplate == null) {
           spacerTemplate = Resources.Load(@"Prefabs/DialogueSpacer") as GameObject;
        }

        if (dialogueContainer == null || consoleScroll == null) {
            GameObject holder = GameObject.Find("DialogueHolder");
            dialogueContainer = holder.transform.GetChild(0).gameObject;
            consoleScroll = holder.GetComponent<ScrollRect>();
        }
        story.OnOutput += Display;

        scrolling = false;
        queue = new Queue<QueuedAction>();
        StartCoroutine(ProcessQueue());

        open = false;

        //this.story.Begin();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) {
            EndDialogue();
        } else if(Input.GetKeyDown(KeyCode.Space)) {
            OpenDialogueWindow();
        }
	}

    public void Display(StoryOutput output) {

        QueuedAction action = GenerateQueueAction(output);

        queue.Enqueue(action);
    }

    public void EndDialogue() {
        QueuedEnding ending = new QueuedEnding();

        queue.Enqueue(ending);
    }

    public void CloseDialogueWindow() {
        consoleScroll.verticalNormalizedPosition = 1;
        //if (!open) return;
        for (int i = dialogueContainer.transform.childCount - 1; i >= 0; i--) {
            Destroy(dialogueContainer.transform.GetChild(i).gameObject);
        }
        dialogueContainer.transform.DetachChildren();
        GameObject spacer = Instantiate(spacerTemplate) as GameObject;
        spacer.transform.SetParent(dialogueContainer.transform);
        dialogueContainer.SetActive(false);
        story.Reset();
        open = false;
    }

    public void OpenDialogueWindow() {
        if (open) return;
        dialogueContainer.SetActive(true);
        story.Begin();
        open = true;
    }

    public void DoLink(StoryLink link) {
        LinkButton[] links = GetComponentsInChildren<LinkButton>();
        for (int i = 0; i < links.Length; i++) {
            if(links[i].live) {
                QueuedRemoveElement removeAction = new QueuedRemoveElement(links[i].gameObject);
                queue.Enqueue(removeAction);
            }
        }
        this.story.DoLink(link);
    }

    QueuedAction GenerateQueueAction(StoryOutput output) {
        if(output is StoryText) {
            GameObject textElement = Instantiate(textTemplate);

            QueuedDisplayText action = new QueuedDisplayText(textElement, output);

            return action;
        } else if(output is StoryLink) {
            GameObject newLinkElement = Instantiate(linkTemplate);

            LinkButton link = newLinkElement.GetComponent<LinkButton>();

            link.Initialize(() => {
                link.Deactivate(true);
                this.DoLink((StoryLink)output);
            }, output.Text);

            return new QueuedDisplayLink(newLinkElement, (StoryLink)output);
        }
        return new EmptyQueueAction();
    }

    public IEnumerator ScrollToBottom() {
        if (scrolling)
        {
            yield break;
        }
        scrolling = true;

        Canvas.ForceUpdateCanvases();

        float scrollDif = consoleScroll.verticalNormalizedPosition;

        for (int t = 0; t < updateTime; t++) {
            consoleScroll.verticalNormalizedPosition = (Mathf.Cos((Mathf.PI * t) / (updateTime)) + 1) * scrollDif;
            yield return null;
        }
        consoleScroll.verticalNormalizedPosition = 0;
        scrolling = false;
    }

    public IEnumerator QueueElementBuffer() {
        yield return new WaitForSeconds(updateBuffer);
    }

    IEnumerator ProcessQueue() {
        while(true) {
            if(queue.Count > 0) {
                QueuedAction action = queue.Dequeue();

                yield return StartCoroutine(action.PerformAction(this));

                yield return StartCoroutine(QueueElementBuffer());
            }
            yield return null;
        }
    }
}


abstract class QueuedAction {

    public abstract IEnumerator PerformAction(Dialogue d);

}

class EmptyQueueAction : QueuedAction {
    public override IEnumerator PerformAction(Dialogue d)
    {
        yield return null;
    }
}

class QueuedDisplayText : QueuedAction {
    public Text field;
    public Text spacer;
    public string text;

    public QueuedDisplayText(GameObject _newTextElement, StoryOutput _output) {
        field = _newTextElement.GetComponent<Text>();
        text = _output.Text;
        field.text = text;
        _newTextElement.SetActive(false);
    }

    public override IEnumerator PerformAction(Dialogue d) {
        field.gameObject.SetActive(true);

        field.gameObject.transform.SetParent(d.dialogueContainer.transform);

        yield return d.StartCoroutine(d.ScrollToBottom());
    }
}

class QueuedDisplayLink : QueuedAction {
    public Text field;
    public string text;

    public QueuedDisplayLink(GameObject _newTextElement, StoryLink link) {
        field = _newTextElement.GetComponent<Text>();
        field.text = link.Text;
        text = link.Text;
        _newTextElement.SetActive(false);
    }

    public override IEnumerator PerformAction(Dialogue d) {
        field.gameObject.SetActive(true);

        field.gameObject.transform.SetParent(d.dialogueContainer.transform);

        yield return d.StartCoroutine(d.ScrollToBottom());
    }
}

class QueuedRemoveElement : QueuedAction {
    public GameObject toDelete;

    public QueuedRemoveElement(GameObject _toDelete) {
        toDelete = _toDelete;
    }

    public override IEnumerator PerformAction(Dialogue d) {
        toDelete.SetActive(false);
        yield return d.StartCoroutine(d.ScrollToBottom());
        GameObject.Destroy(toDelete);
    }
}

class QueuedEnding : QueuedAction {
    public override IEnumerator PerformAction(Dialogue d) {
        Debug.Log("Ending!");
        d.CloseDialogueWindow();
        yield return null;
    }
}