using Sandbox;
using System;
using System.Linq;

namespace PCT
{
	partial class PCTPlayer : Player
	{
		public override void Respawn()
		{
			base.Respawn();

			SetModel("models/citizen/citizen.vmdl");
		
			Dress();

			Controller = new WalkController();
			Animator = new StandardPlayerAnimator();
			CameraMode = new FixedCamera();
		}
	}
}
