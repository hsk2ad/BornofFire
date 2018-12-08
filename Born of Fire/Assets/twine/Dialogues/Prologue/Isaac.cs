﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Isaac.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Isaac: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
		}

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

	@Isaac()
	{
		this.StartPassage = "Nothing";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new DialogueEnder() { Story = this };
		macros3 = new GlobalVarMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Nothing

	void passage1_Init()
	{
		this.Passages[@"Nothing"] = new StoryPassage(@"Nothing", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("\"I'm not saying anything without a lawer.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Very well.\"", "end", null);
		yield return lineBreak();
		yield return link("\"You're saying something now.\"", "...", null);
		yield break;
	}


	// .............
	// #2: end

	void passage2_Init()
	{
		this.Passages[@"end"] = new StoryPassage(@"end", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		macros2.EndDialogue("...");
		yield break;
	}


	// .............
	// #3: ...

	void passage3_Init()
	{
		this.Passages[@"..."] = new StoryPassage(@"...", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("\"...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("...", "....", null);
		yield break;
	}


	// .............
	// #4: ....

	void passage4_Init()
	{
		this.Passages[@"...."] = new StoryPassage(@"....", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("...");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("...", ".....", null);
		yield break;
	}


	// .............
	// #5: .....

	void passage5_Init()
	{
		this.Passages[@"....."] = new StoryPassage(@".....", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("............................................");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("...", "...", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Very well, then.\"", "end", null);
		yield break;
	}


}