﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Credits.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Credits: Cradle.StoryFormats.Harlowe.HarloweStory
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

	@Credits()
	{
		this.StartPassage = "Start";

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
		passage18_Init();
		passage19_Init();
		passage20_Init();
		passage21_Init();
		passage22_Init();
		passage23_Init();
		passage24_Init();
		passage25_Init();
		passage26_Init();
		passage27_Init();
		passage28_Init();
		passage29_Init();
		passage30_Init();
		passage31_Init();
		passage32_Init();
		passage33_Init();
		passage34_Init();
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
		yield return text("Credits");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "W", null);
		yield return lineBreak();
		yield return link("Programmers", "P", null);
		yield return lineBreak();
		yield return link("Artists", "A", null);
		yield return lineBreak();
		yield return link("Musicians", "M", null);
		yield break;
	}


	// .............
	// #2: W

	void passage2_Init()
	{
		this.Passages[@"W"] = new StoryPassage(@"W", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "WP", null);
		yield return lineBreak();
		yield return link("Artists", "WA", null);
		yield return lineBreak();
		yield return link("Musicians", "WM", null);
		yield break;
	}


	// .............
	// #3: WP

	void passage3_Init()
	{
		this.Passages[@"WP"] = new StoryPassage(@"WP", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Artists", "WPA", null);
		yield return lineBreak();
		yield return link("Musicians", "WPM", null);
		yield break;
	}


	// .............
	// #4: WPA

	void passage4_Init()
	{
		this.Passages[@"WPA"] = new StoryPassage(@"WPA", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Musicians", "FM", null);
		yield break;
	}


	// .............
	// #5: FM

	void passage5_Init()
	{
		this.Passages[@"FM"] = new StoryPassage(@"FM", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Fin", "Fin", null);
		yield break;
	}


	// .............
	// #6: WA

	void passage6_Init()
	{
		this.Passages[@"WA"] = new StoryPassage(@"WA", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "WAP", null);
		yield return lineBreak();
		yield return link("Musicians", "WAM", null);
		yield break;
	}


	// .............
	// #7: WAP

	void passage7_Init()
	{
		this.Passages[@"WAP"] = new StoryPassage(@"WAP", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Musicians", "FM", null);
		yield break;
	}


	// .............
	// #8: WPM

	void passage8_Init()
	{
		this.Passages[@"WPM"] = new StoryPassage(@"WPM", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Artists", "FA", null);
		yield break;
	}


	// .............
	// #9: FA

	void passage9_Init()
	{
		this.Passages[@"FA"] = new StoryPassage(@"FA", new string[]{  }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Fin", "Fin", null);
		yield break;
	}


	// .............
	// #10: WAM

	void passage10_Init()
	{
		this.Passages[@"WAM"] = new StoryPassage(@"WAM", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "FP", null);
		yield break;
	}


	// .............
	// #11: FP

	void passage11_Init()
	{
		this.Passages[@"FP"] = new StoryPassage(@"FP", new string[]{  }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Fin", "Fin", null);
		yield break;
	}


	// .............
	// #12: WM

	void passage12_Init()
	{
		this.Passages[@"WM"] = new StoryPassage(@"WM", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "WMP", null);
		yield return lineBreak();
		yield return link("Artists", "WMA", null);
		yield break;
	}


	// .............
	// #13: WMP

	void passage13_Init()
	{
		this.Passages[@"WMP"] = new StoryPassage(@"WMP", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Artists", "FA", null);
		yield break;
	}


	// .............
	// #14: WMA

	void passage14_Init()
	{
		this.Passages[@"WMA"] = new StoryPassage(@"WMA", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "FP", null);
		yield break;
	}


	// .............
	// #15: P

	void passage15_Init()
	{
		this.Passages[@"P"] = new StoryPassage(@"P", new string[]{  }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Artists", "PA", null);
		yield return lineBreak();
		yield return link("Writers", "PW", null);
		yield return lineBreak();
		yield return link("Musicians", "PM", null);
		yield break;
	}


	// .............
	// #16: PA

	void passage16_Init()
	{
		this.Passages[@"PA"] = new StoryPassage(@"PA", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "PAW", null);
		yield return lineBreak();
		yield return link("Musicians", "PAM", null);
		yield break;
	}


	// .............
	// #17: PW

	void passage17_Init()
	{
		this.Passages[@"PW"] = new StoryPassage(@"PW", new string[]{  }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Artists", "WPA", null);
		yield return lineBreak();
		yield return link("Musicians", "WPM", null);
		yield break;
	}


	// .............
	// #18: PAW

	void passage18_Init()
	{
		this.Passages[@"PAW"] = new StoryPassage(@"PAW", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Musicians", "FM", null);
		yield break;
	}


	// .............
	// #19: PAM

	void passage19_Init()
	{
		this.Passages[@"PAM"] = new StoryPassage(@"PAM", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "FW", null);
		yield break;
	}


	// .............
	// #20: FW

	void passage20_Init()
	{
		this.Passages[@"FW"] = new StoryPassage(@"FW", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Fin", "Fin", null);
		yield break;
	}


	// .............
	// #21: PM

	void passage21_Init()
	{
		this.Passages[@"PM"] = new StoryPassage(@"PM", new string[]{  }, passage21_Main);
	}

	IStoryThread passage21_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "PMW", null);
		yield return lineBreak();
		yield return link("Artists", "PMA", null);
		yield break;
	}


	// .............
	// #22: PMW

	void passage22_Init()
	{
		this.Passages[@"PMW"] = new StoryPassage(@"PMW", new string[]{  }, passage22_Main);
	}

	IStoryThread passage22_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Artists", "FA", null);
		yield break;
	}


	// .............
	// #23: PMA

	void passage23_Init()
	{
		this.Passages[@"PMA"] = new StoryPassage(@"PMA", new string[]{  }, passage23_Main);
	}

	IStoryThread passage23_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "FW", null);
		yield break;
	}


	// .............
	// #24: A

	void passage24_Init()
	{
		this.Passages[@"A"] = new StoryPassage(@"A", new string[]{  }, passage24_Main);
	}

	IStoryThread passage24_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "AW", null);
		yield return lineBreak();
		yield return link("Programmers", "AP", null);
		yield return lineBreak();
		yield return link("Musicians", "AM", null);
		yield break;
	}


	// .............
	// #25: AW

	void passage25_Init()
	{
		this.Passages[@"AW"] = new StoryPassage(@"AW", new string[]{  }, passage25_Main);
	}

	IStoryThread passage25_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "WAP", null);
		yield return lineBreak();
		yield return link("Musicians", "WAM", null);
		yield break;
	}


	// .............
	// #26: AP

	void passage26_Init()
	{
		this.Passages[@"AP"] = new StoryPassage(@"AP", new string[]{  }, passage26_Main);
	}

	IStoryThread passage26_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "PAW", null);
		yield return lineBreak();
		yield return link("Musicians", "PAM", null);
		yield break;
	}


	// .............
	// #27: AM

	void passage27_Init()
	{
		this.Passages[@"AM"] = new StoryPassage(@"AM", new string[]{  }, passage27_Main);
	}

	IStoryThread passage27_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "AMW", null);
		yield return lineBreak();
		yield return link("Programmers", "AMP", null);
		yield break;
	}


	// .............
	// #28: AMW

	void passage28_Init()
	{
		this.Passages[@"AMW"] = new StoryPassage(@"AMW", new string[]{  }, passage28_Main);
	}

	IStoryThread passage28_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "FP", null);
		yield break;
	}


	// .............
	// #29: AMP

	void passage29_Init()
	{
		this.Passages[@"AMP"] = new StoryPassage(@"AMP", new string[]{  }, passage29_Main);
	}

	IStoryThread passage29_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "FW", null);
		yield break;
	}


	// .............
	// #30: M

	void passage30_Init()
	{
		this.Passages[@"M"] = new StoryPassage(@"M", new string[]{  }, passage30_Main);
	}

	IStoryThread passage30_Main()
	{
		yield return lineBreak();
		yield return text("Nathaniel Saxe");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "MW", null);
		yield return lineBreak();
		yield return link("Programmers", "MP", null);
		yield return lineBreak();
		yield return link("Artists", "MA", null);
		yield break;
	}


	// .............
	// #31: MW

	void passage31_Init()
	{
		this.Passages[@"MW"] = new StoryPassage(@"MW", new string[]{  }, passage31_Main);
	}

	IStoryThread passage31_Main()
	{
		yield return lineBreak();
		yield return text("Caroline Scrafford");
		yield return lineBreak();
		yield return text("Helen Lim");
		yield return lineBreak();
		yield return text("Jimmy Chiou");
		yield return lineBreak();
		yield return text("Kevin Le");
		yield return lineBreak();
		yield return text("Michael Klaczynski");
		yield return lineBreak();
		yield return text("Sam Kim");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Programmers", "WMP", null);
		yield return lineBreak();
		yield return link("Artists", "WMA", null);
		yield break;
	}


	// .............
	// #32: MP

	void passage32_Init()
	{
		this.Passages[@"MP"] = new StoryPassage(@"MP", new string[]{  }, passage32_Main);
	}

	IStoryThread passage32_Main()
	{
		yield return lineBreak();
		yield return text("Jack Herd");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "PMW", null);
		yield return lineBreak();
		yield return link("Artists", "PMA", null);
		yield break;
	}


	// .............
	// #33: MA

	void passage33_Init()
	{
		this.Passages[@"MA"] = new StoryPassage(@"MA", new string[]{  }, passage33_Main);
	}

	IStoryThread passage33_Main()
	{
		yield return lineBreak();
		yield return text("Annie Cao");
		yield return lineBreak();
		yield return text("Saetbyull Park");
		yield return lineBreak();
		yield return text("Shiki Anderson");
		yield return lineBreak();
		yield return text("Sydney Montgomery");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Writers", "AMW", null);
		yield return lineBreak();
		yield return link("Programmers", "AMP", null);
		yield break;
	}


	// .............
	// #34: Fin

	void passage34_Init()
	{
		this.Passages[@"Fin"] = new StoryPassage(@"Fin", new string[]{  }, passage34_Main);
	}

	IStoryThread passage34_Main()
	{
		macros3.ChangeScene("MainMenu");
		yield break;
	}


}