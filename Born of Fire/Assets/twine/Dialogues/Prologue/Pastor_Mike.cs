﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Pastor_Mike.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Pastor_Mike: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("curse", () => this.@curse, val => this.@curse = val);
		}

		public StoryVar @curse;
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
	public readonly HOOK macros2;
	public readonly DialogueEnder macros3;
	public readonly GlobalVarMacros macros4;

	@Pastor_Mike()
	{
		this.StartPassage = "Introduction";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };
		macros2 = new HOOK() { Story = this };
		macros3 = new DialogueEnder() { Story = this };
		macros4 = new GlobalVarMacros() { Story = this };

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
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
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
		macros3.EndDialogue("Good boy!");
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
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Sinking Foundation?\"", "\"Sinking Foundation?\"", null);
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
		macros3.EndDialogue("Harder, Daddy!");
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
		yield return lineBreak();
		yield return link("\"What's that painting of behind you?\"", "Painting", null);
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
		macros3.EndDialogue("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
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
		yield return lineBreak();
		Vars.curse  = true;
		yield return lineBreak();
		macros4.ExportVar("curse");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		macros3.EndDialogue("Coswallop in my opinion!");
		yield break;
	}


	// .............
	// #11: Painting

	void passage11_Init()
	{
		this.Passages[@"Painting"] = new StoryPassage(@"Painting", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("The pastor steps aside, allowing you to further investigate the painting. It depicts the construction of a church, presumably the church which was recently destroyed by the fire. Most of it is only scaffolding, but the general frame of the church is visible. A cross is visible at the top, upon which the artist has dramatically placed a pillar of light...");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("...", "Painting2", null);
		yield break;
	}


	// .............
	// #12: Painting2

	void passage12_Init()
	{
		this.Passages[@"Painting2"] = new StoryPassage(@"Painting2", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("The pastor begins talking.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("\"Ah, yes, a marvelous work, is it not? Painted at the same time that the church was constructed nearly one hundred years ago.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("At the edges of the frame men can be seen working in teams to cart away several large, pointed stones, each about the height and width of a twelve-year-old child. Some of the stones have strange markings in them.");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What's with the stones?\"", "\"What's with the stones?\"", null);
		yield break;
	}


	// .............
	// #13: ""What's with the stones?""

	void passage13_Init()
	{
		this.Passages[@"""What's with the stones?"""] = new StoryPassage(@"""What's with the stones?""", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("\"The hill where the church was built was covered in a set of strange rock formations. Many of the hills in these parts were. Theories about them vary wildely, most of them hogwash. Aliens, Native American burial grounds, Satanic temples. The locals have wild imaginations. My guess? Probably just some geological quirk specific to the area.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Fascinating.\"", "\"Fascinating.\"", null);
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"What's wrong with the burial ground theory?\"", "\"What's wrong with the burial ground theory?\"", null);
		yield break;
	}


	// .............
	// #14: ""Fascinating.""

	void passage14_Init()
	{
		this.Passages[@"""Fascinating."""] = new StoryPassage(@"""Fascinating.""", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("\"Not when you're trying to build a church, unfortunately. The builders had to remove them in order to work with a flat foundation. A bit of a shame, really.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Where did they dispose of the stones?\"", "\"Where did they dispose of the stones?\"", null);
		yield break;
	}


	// .............
	// #15: ""What's wrong with the burial ground theory?""

	void passage15_Init()
	{
		this.Passages[@"""What's wrong with the burial ground theory?"""] = new StoryPassage(@"""What's wrong with the burial ground theory?""", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("\"Carbon dating. The carvings are too old to have been made by humans, at least in our current understanding of paleantology.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Where did they dispose of the stones?\"", "\"Where did they dispose of the stones?\"", null);
		yield break;
	}


	// .............
	// #16: ""Where did they dispose of the stones?""

	void passage16_Init()
	{
		this.Passages[@"""Where did they dispose of the stones?"""] = new StoryPassage(@"""Where did they dispose of the stones?""", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return text("\"Depends. Some of them were smashed to gravel. Others were incorperated into the foundations of the church. Probably not the best idea, given the buildings later \"sinking foundation\" problem\".");
		yield return lineBreak();
		yield return lineBreak();
		macros2.OpenCrawlspace("Obre...Picinyio");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Sinking Foundation?\"", "\"Sinking Foundation?\"", null);
		yield break;
	}


	// .............
	// #17: ""Sinking Foundation?""

	void passage17_Init()
	{
		this.Passages[@"""Sinking Foundation?"""] = new StoryPassage(@"""Sinking Foundation?""", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("\"Yeah, apparently the ground beneath the church is unstable. Parts of it started sagging below other parts, adding shearing stress to the building. It was only a matter of time before the whole thing collapsed, or fell into a sink hole.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Could this have affected the gas lines? Maybe triggering an explosion or something?\"", "IDTS", null);
		yield break;
	}


}