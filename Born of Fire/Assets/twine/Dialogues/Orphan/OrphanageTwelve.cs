﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: OrphanageTwelve.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @OrphanageTwelve: Cradle.StoryFormats.Harlowe.HarloweStory
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
	public readonly HOOK macros2;
	public readonly DialogueEnder macros3;
	public readonly GlobalVarMacros macros4;

	@OrphanageTwelve()
	{
		this.StartPassage = "Facility wit Orphan";

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
	}

	// ---------------
	#endregion

	// .............
	// #1: Facility wit Orphan

	void passage1_Init()
	{
		this.Passages[@"Facility wit Orphan"] = new StoryPassage(@"Facility wit Orphan", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("George doesn't seem to notice when you approach. He looks to be almost catotonic, standing over the motionless bodies of the two government men.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Eventually, he looks up, quickly leveling a pistol at  your chest.");
		yield return lineBreak();
		yield return lineBreak();
		macros3.SetSpeaker("George");
		yield return lineBreak();
		yield return text("\"Wh-what are you doing here?!\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Relax, George. I'm on your side. I know what they did to you and the other orphans.\" ", " 2", null);
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
		yield return text("\"No...No you don't. You have no idea.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I read the files. I'm sorry for what you've been through, George.\" ", " 3", null);
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
		yield return text("\"Don't act like you give a damn! I'm sick of people pretending they care, when really they'd sooner feed you to the dogs than try to actually change things!\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"You're in shock, George. You need to calm down.\" ", " 4", null);
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
		yield return text("\"Shock? From killing these guys? Please. I stopped feeling anything like that a long time ago.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"They exposed you to a lot of violent movies and drugs, right?\" ", " 5", null);
		yield break;
	}


	// .............
	// #5:  5

	void passage5_Init()
	{
		this.Passages[@" 5"] = new StoryPassage(@" 5", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("\"Hah, that's not even the half of it. What they did to us couldn't be described any other way beside as torture.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"I understand that, George. But together, we can expose them. So just put down the gun. ", " 6", null);
		yield break;
	}


	// .............
	// #6:  6

	void passage6_Init()
	{
		this.Passages[@" 6"] = new StoryPassage(@" 6", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return text("\"Sorry, can't do any of that. I'm planning to take this place down once and for all, like I should have the first time.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"You're not saying...you started the first fire?\" ", " 7", null);
		yield break;
	}


	// .............
	// #7:  7

	void passage7_Init()
	{
		this.Passages[@" 7"] = new StoryPassage(@" 7", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text("\"Very perceptive of you, detective. I might have messed up the first time, but I won't make that mistake again. I'll see this through to the end.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"You don't have to do this.\" ", " 8", null);
		yield break;
	}


	// .............
	// #8:  8

	void passage8_Init()
	{
		this.Passages[@" 8"] = new StoryPassage(@" 8", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return text("\"Oh, but I do. Who else would do it? No, I need to make sure all of this research, all of this torture...I need to make sure it's gone forever.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"If we brought this to the press, the government would be forced to stop the experiments.\" ", " 9", null);
		yield return lineBreak();
		yield return link("\"What about the town? Do you want to put them through another fire?\" ", " 9.1", null);
		yield return lineBreak();
		yield break;
	}


	// .............
	// #9:  9

	void passage9_Init()
	{
		this.Passages[@" 9"] = new StoryPassage(@" 9", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("\"Hmm...You have a point there. But I'm not changing my mind. This is the only way to be sure. And this is all I'm good for, anyways...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"That's not true. You can change, George. You don't have to be a weapon.\" ", " 10", null);
		yield break;
	}


	// .............
	// #10:  9.1

	void passage10_Init()
	{
		this.Passages[@" 9.1"] = new StoryPassage(@" 9.1", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("\"Why should I care? After all, I'm just a human weapon! All I'm good for is violence.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"You're more than that, George.\" ", " 10.1", null);
		yield break;
	}


	// .............
	// #11:  10

	void passage11_Init()
	{
		this.Passages[@" 10"] = new StoryPassage(@" 10", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("\"But that's all I am. A human killing machine. A weapon.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"You're more than that. You have your whole life ahead of you to change who you are. But if you go on with this, you won't ever get the chance.\" ", " 11", null);
		yield break;
	}


	// .............
	// #12:  11

	void passage12_Init()
	{
		this.Passages[@" 11"] = new StoryPassage(@" 11", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("\"...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Give me the gun, George.\" ", " EndDia", null);
		yield break;
	}


	// .............
	// #13:  EndDia

	void passage13_Init()
	{
		this.Passages[@" EndDia"] = new StoryPassage(@" EndDia", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		macros3.ChangeScene("Exp5_Diner");
		yield break;
	}


	// .............
	// #14:  10.1

	void passage14_Init()
	{
		this.Passages[@" 10.1"] = new StoryPassage(@" 10.1", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("\"No, I'm not! After what I've done...not just to these guys but so many others...I can't go back.\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"If you do this, you're only proving their point. You're showing that you're nothing more than a weapon. But you aren't. You can change.\" ", " 11.1", null);
		yield break;
	}


	// .............
	// #15:  11.1

	void passage15_Init()
	{
		this.Passages[@" 11.1"] = new StoryPassage(@" 11.1", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("\"...\"");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("\"Give me the gun, George.\" ", " EndDia", null);
		yield break;
	}


}