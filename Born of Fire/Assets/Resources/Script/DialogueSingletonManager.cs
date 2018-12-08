using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSingletonManager {

    static bool DialogueRunning = false;

    public static bool IsAvailable() {
        return !DialogueRunning;
    }

    public static void SetDialogueRunning() {
        DialogueRunning = true;
    }

    public static void EndDialogueRunning() {
        DialogueRunning = false;
    }
}
