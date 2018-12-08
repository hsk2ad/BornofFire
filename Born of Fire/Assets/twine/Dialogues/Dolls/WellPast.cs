﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: WellPast.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @WellPast: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@WellPast()
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
		passage5_Init();
		passage6_Init();
		passage7_Init();
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
		yield return text("You open your eyes, a massive headache right under your forehead.");
		yield return lineBreak();
		yield return text("Your body aches, and feels as though it was stretched through a grate.");
		yield return lineBreak();
		yield return text("Lifting your chest off the ground, propped up by your elbows, you look forward, trying not to turn your head and provoke your nasty migraine.");
		yield return lineBreak();
		yield return text("Around you is the well you climbed down earlier, but something seems off.");
		yield return lineBreak();
		yield return link("Examine the walls.", "Walls", null);
		yield return lineBreak();
		yield return link("Look up.", "LookUp", null);
		yield break;
	}


	// .............
	// #2: Walls

	void passage2_Init()
	{
		this.Passages[@"Walls"] = new StoryPassage(@"Walls", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("The first thing you notice is the creeping feeling of cold snaking up your body.");
		yield return lineBreak();
		yield return text("Water.");
		yield return lineBreak();
		yield return text("Water in the well. Water on the walls.");
		yield return lineBreak();
		yield return text("Confusion strikes you, the walls are slick where they had been dry, and pristine where they had been weathered.");
		yield return lineBreak();
		yield return text("A chilling feeling creeps up your spine.");
		yield return lineBreak();
		yield return text("Your hair stands on end.");
		yield return lineBreak();
		macros2.SetSpeaker("???");
		yield return lineBreak();
		yield return text("\"Come. Come.\"");
		yield return lineBreak();
		using (Group("em", true)) {
			yield return text("giggles");
		}
		yield return lineBreak();
		macros2.SetSpeaker("");
		yield return lineBreak();
		yield return link("What the fuck?...", "Fall", null);
		yield break;
	}


	// .............
	// #3: LookUp

	void passage3_Init()
	{
		this.Passages[@"LookUp"] = new StoryPassage(@"LookUp", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text("The first thing you notice is the creeping feeling of cold snaking up your body.");
		yield return lineBreak();
		yield return text("Water.");
		yield return lineBreak();
		yield return text("Water in the well. Water on the walls.");
		yield return lineBreak();
		yield return text("Confusion strikes you. The six feet you climbed down has turned into an infinite pit. Above you is a dot of sky.");
		yield return lineBreak();
		yield return text("A chilling feeling creeps up your spine.");
		yield return lineBreak();
		yield return text("Your hair stands on end.");
		yield return lineBreak();
		macros2.SetSpeaker("???");
		yield return lineBreak();
		yield return text("\"Come. Come.\"");
		yield return lineBreak();
		using (Group("em", true)) {
			yield return text("giggles");
		}
		yield return lineBreak();
		macros2.SetSpeaker("");
		yield return lineBreak();
		yield return link("What the fuck?...", "Fall", null);
		yield break;
	}


	// .............
	// #4: Fall

	void passage4_Init()
	{
		this.Passages[@"Fall"] = new StoryPassage(@"Fall", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("A scream.");
		yield return lineBreak();
		yield return text("Above you, the figure of a girl falling.");
		yield return lineBreak();
		yield return text("Her body flails side to side, knocking itself against the well walls,");
		yield return lineBreak();
		yield return text("accelerating closer and closer to you.");
		yield return lineBreak();
		yield return link("Attempt to catch her.", "Catch", null);
		yield return lineBreak();
		yield return link("Shield yourself.", "Shield", null);
		yield break;
	}


	// .............
	// #5: Catch

	void passage5_Init()
	{
		this.Passages[@"Catch"] = new StoryPassage(@"Catch", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("You hold out your arms to try and catch the falling girl.");
		yield return lineBreak();
		yield return text("She hits your arms with an impactful and sickening crunch.");
		yield return lineBreak();
		yield return text("Your vision flashes with images of a lake, a drowning girl, a fire.");
		yield return lineBreak();
		yield return link("Then... nothing.", "End", null);
		yield break;
	}


	// .............
	// #6: Shield

	void passage6_Init()
	{
		this.Passages[@"Shield"] = new StoryPassage(@"Shield", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("You duck and cover your head to protect yourself.");
		yield return lineBreak();
		yield return text("She hits your body with an impactful and sickening crunch.");
		yield return lineBreak();
		yield return text("Pain flares through your spine.");
		yield return lineBreak();
		yield return text("Your vision flashes with images of a lake, a drowning girl, a fire.");
		yield return lineBreak();
		yield return link("Then... nothing.", "End", null);
		yield break;
	}


	// .............
	// #7: End

	void passage7_Init()
	{
		this.Passages[@"End"] = new StoryPassage(@"End", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		macros2.EndDialogue("end");
		yield break;
	}


}