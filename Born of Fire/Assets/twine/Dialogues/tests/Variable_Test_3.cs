﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Variable_Test_3.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Variable_Test_3: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("var", () => this.@var, val => this.@var = val);
			VarDef("disp", () => this.@disp, val => this.@disp = val);
		}

		public StoryVar @var;
		public StoryVar @disp;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;
	public readonly DialogueEnder macros2;
	public readonly GlobalVarMacros macros3;

	@Variable_Test_3()
	{
		this.StartPassage = "Start";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new DialogueEnder() { Story = this };
		macros3 = new GlobalVarMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Start

	void passage1_Init()
	{
		this.Passages[@"Start"] = new StoryPassage(@"Start", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		macros3.ImportVar("var");
		yield return lineBreak();
		yield return text("Here's an incrementer!");
		yield return lineBreak();
		yield return link("Increment", "Increment", null);
		yield break;
	}


	// .............
	// #2: Increment

	void passage2_Init()
	{
		this.Passages[@"Increment"] = new StoryPassage(@"Increment", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		Vars.@var  = Vars.@var + 1;
		yield return lineBreak();
		macros3.ExportVar("var");
		yield return lineBreak();
		Vars.disp  = "Value is: " + macros1.text(Vars.@var);
		yield return lineBreak();
		yield return text(Vars.disp);
		yield return lineBreak();
		yield return link("Continue.", "Loop", null);
		yield return lineBreak();
		yield return link("Be done.", "End", null);
		yield break;
	}


	// .............
	// #3: Loop

	void passage3_Init()
	{
		this.Passages[@"Loop"] = new StoryPassage(@"Loop", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("Here's an incrementer!");
		yield return lineBreak();
		yield return link("Increment", "Increment", null);
		yield break;
	}


	// .............
	// #4: End

	void passage4_Init()
	{
		this.Passages[@"End"] = new StoryPassage(@"End", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		macros2.EndDialogue("plz");
		yield break;
	}


}