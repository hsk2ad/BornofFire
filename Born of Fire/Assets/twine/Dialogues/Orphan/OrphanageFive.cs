﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: OrphanageFive.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @OrphanageFive: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@OrphanageFive()
	{
		this.StartPassage = "Innkeeper at Inn";

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
		passage6_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Innkeeper at Inn

	void passage1_Init()
	{
		this.Passages[@"Innkeeper at Inn"] = new StoryPassage(@"Innkeeper at Inn", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		macros2.SetSpeaker("Innkeeper");
		yield return lineBreak();
		yield return text("\"Morning. Had a busy night, did we?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"That's one way to put it.\" ", " 2", null);
		yield break;
	}


	// .............
	// #2:  2

	void passage2_Init()
	{
		this.Passages[@" 2"] = new StoryPassage(@" 2", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("\"By the way, the sheriff came looking for you earlier. Said he needed to talk.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Good to know. I'll be on my way in just a minute.\" ", " 3", null);
		yield break;
	}


	// .............
	// #3:  3

	void passage3_Init()
	{
		this.Passages[@" 3"] = new StoryPassage(@" 3", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("\"Haven't seen the orphan around today, either. Wonder where he wandered off to?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Beats me.\" ", " 4", null);
		yield return lineBreak();
		yield return link("\"His name is George, you know.\" ", " 4.5", null);
		yield break;
	}


	// .............
	// #4:  4

	void passage4_Init()
	{
		this.Passages[@" 4"] = new StoryPassage(@" 4", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("\"He's a mysterious one, isn't he?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Leave. ", " EndDia", null);
		yield break;
	}


	// .............
	// #5:  4.5

	void passage5_Init()
	{
		this.Passages[@" 4.5"] = new StoryPassage(@" 4.5", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"Whatever you say, detective.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Leave. ", " EndDia", null);
		yield break;
	}


	// .............
	// #6:  EndDia

	void passage6_Init()
	{
		this.Passages[@" EndDia"] = new StoryPassage(@" EndDia", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		macros2.EndDialogue(" ");
		yield break;
	}


}