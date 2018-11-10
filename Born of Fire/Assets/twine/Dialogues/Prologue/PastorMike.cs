﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: PastorMike.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @PastorMike: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@PastorMike()
	{
		this.StartPassage = "Introduction";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new DialogueEnder() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Introduction

	void passage1_Init()
	{
		this.Passages[@"Introduction"] = new StoryPassage(@"Introduction", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("\"Hello. What brings you to the House of God today?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I'm the detective they sent to figure out how the fire started.\"", "But why?", null);
		yield return lineBreak();
		yield return link("\"I just want to help in any way I can.\"", "Good.", null);
		yield return lineBreak();
		yield return link("\"What do you know about the old church?\"", "Ah", null);
		yield break;
	}


	// .............
	// #2: But why?

	void passage2_Init()
	{
		this.Passages[@"But why?"] = new StoryPassage(@"But why?", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("\"And you think you might find answers here?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I need to interview a few of the people here.\"", "Careful", null);
		yield return lineBreak();
		yield return link("\"I want to ask you a few questions about this town\"", "AskAway", null);
		yield break;
	}


	// .............
	// #3: Good.

	void passage3_Init()
	{
		this.Passages[@"Good."] = new StoryPassage(@"Good.", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("\"We could always use more hands. Some of these people lost their entire livelihoods in the fire.\"");
		yield return lineBreak();
		yield return lineBreak();
		macros2.EndDialogue("Good boy!");
		yield break;
	}


	// .............
	// #4: Ah

	void passage4_Init()
	{
		this.Passages[@"Ah"] = new StoryPassage(@"Ah", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("\"Ah. A beautiful structure. It's a shame we couldn't afford to maitain it. Between the mold, the rust, the asthbestos and the sinking foundation, you can only fight mortality for so long.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What about the gas lines? Did they have any problems?\"", "IDTS", null);
		yield break;
	}


	// .............
	// #5: Careful

	void passage5_Init()
	{
		this.Passages[@"Careful"] = new StoryPassage(@"Careful", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"Well go ahead. Just keep in mind that these people have been through something traumatic, so choose you words wisely.\"");
		yield return lineBreak();
		yield return lineBreak();
		macros2.EndDialogue("Harder, Daddy!");
		yield break;
	}


	// .............
	// #6: AskAway

	void passage6_Init()
	{
		this.Passages[@"AskAway"] = new StoryPassage(@"AskAway", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("\"Ask away.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What do you know about the old church?\"", "Ah", null);
		yield return lineBreak();
		yield return link("\"What do you know about the history of this town?\"", "History", null);
		yield break;
	}


	// .............
	// #7: IDTS

	void passage7_Init()
	{
		this.Passages[@"IDTS"] = new StoryPassage(@"IDTS", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("\"The gas was broken even before I started preaching there. There were always more urgent matters to deal with. When I got put in charge I had it permenately disabled for safety reasons.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"So it couldn't have started the fire?\"", "Nope", null);
		yield break;
	}


	// .............
	// #8: Nope

	void passage8_Init()
	{
		this.Passages[@"Nope"] = new StoryPassage(@"Nope", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("\"Even if one of the pipes broke open, there wouldn't be any gas to leak out.\"");
		yield return lineBreak();
		yield return lineBreak();
		macros2.EndDialogue("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
		yield break;
	}


	// .............
	// #9: History

	void passage9_Init()
	{
		this.Passages[@"History"] = new StoryPassage(@"History", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("\"Let's see. Founded by Anston Blackwood. Officially chartered in 1789. Survived one hundred eighty winters, through war and famine alike. Population never rose above 700. Recently suffered a reasonably sized fire, which they will no doubt recover from.\"");
		yield return lineBreak();
		yield return text("\"Anything in particular?\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Any mysterious deaths or disasters in that time?", "Some.", null);
		yield break;
	}


	// .............
	// #10: Some.

	void passage10_Init()
	{
		this.Passages[@"Some."] = new StoryPassage(@"Some.", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("\"Every town has its stories. We've had other fires, and other tragedies. The locals sometimes talk about the town being \"cursed\", but it's all just superstition, I assure you.\"");
		yield return lineBreak();
		yield return lineBreak();
		macros2.EndDialogue("Coswallop in my opinion!");
		yield break;
	}


}