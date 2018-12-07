using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Cradle;

public class GlobalVariables : MonoBehaviour {

    public static GlobalVariables instance;
    static bool initialized;

    private Dictionary<string, StoryVar> globals;

    private void Awake()
    {
        if(!initialized) {
            Initialize();
            instance = this;
            initialized = true;
        } else {
            Destroy(this);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static StoryVar GetVariable(string name) {
        if (!instance.globals.ContainsKey(name)) {
            StoryVar dummy = StoryVar.Empty;

            instance.globals.Add(name, dummy);
        }

        return instance.globals[name].Duplicate();
    }

    public static void SetVariable(string name, StoryVar val) {
        if(instance.globals.ContainsKey(name)) {
            instance.globals[name] = val.Duplicate();
        } else {
            instance.globals.Add(name, val.Duplicate());
        }

        //Save Game
    }

    void Initialize() {
        globals = new Dictionary<string, StoryVar>();
    }
}


public class GlobalVarMacros : RuntimeMacros {

    [RuntimeMacro]
    public void ExportVar(string varname) {
        StoryVar toexport = this.Story.Vars[varname];

        GlobalVariables.SetVariable(varname, toexport);
    }

    [RuntimeMacro]
    public void ImportVar(string varname) {
        StoryVar globval = GlobalVariables.GetVariable(varname);

        this.Story.Vars[varname] = globval;
    }
}