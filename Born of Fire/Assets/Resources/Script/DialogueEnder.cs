using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;

public class DialogueEnder : RuntimeMacros {

    [RuntimeMacro]
    public void EndDialogue(string blah) {
        this.Story.SendMessage("EndDialogue");
    }

    [RuntimeMacro]
    public void ChangeScene(string newSceneName) {
        SceneTransition.GoToScene(newSceneName);
    }

    [RuntimeMacro]
    public void SetSpeaker(string speakerName) {
        this.Story.SendMessage("SetSpeaker", speakerName);
    }
}
