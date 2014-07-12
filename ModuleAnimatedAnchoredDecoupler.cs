// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using KSP;
using UnityEngine;

namespace AnimatedDecouplers
{
	public class ModuleAnimatedAnchoredDecoupler : ModuleAnchoredDecoupler
	{
		[KSPField()]
		public string animationName;
		
		protected Animation[] anims;
		
		public ModuleAnimatedAnchoredDecoupler ():
		base()
		{
		}

		public override void OnStart (StartState state)
		{
			print ("ModuleAnimatedAnchoredDecoupler.OnStart(), isDecoupled = " + isDecoupled.ToString ());
			anims = part.FindModelAnimators(animationName);
			if (anims == null || anims.Length == 0)
			{
				print ("ModuleAnimatedAnchoredDecoupler: Animations not found");
			}
			else
			{

			}
			base.OnStart (state);
		}
		
		public override void OnActive()
		{
			print ("ModuleAnimatedAnchoredDecoupler.OnActive() start; isDecoupled = " + this.isDecoupled.ToString ());
			base.OnActive ();
			print ("ModuleAnimatedAnchoredDecoupler.OnActive() finished; isDecoupled = " + this.isDecoupled.ToString ());
			if (this.isDecoupled && (object)anims != null) 
			{
				try
				{
					// This probably doesn't work as is; just a placeholder really
					anims[0].Play (animationName);
				}
				catch (Exception e)
				{
					Debug.Log ("ModuleAnimatedAnchoredDecoupler error! " + e.Message);
				}
			}
		}
	}
}
