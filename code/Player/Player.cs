using Sandbox;
using System;
using System.Linq;

namespace PCT
{
	partial class PCTPlayer : Player
	{
		public Clothing.Container Clothing = new();

		public PCTPlayer() 
		{
		}

		public PCTPlayer(Client cl)
		{
			Clothing.LoadFromClient(cl);
		}

		public override void Respawn()
		{
			base.Respawn();

			SetModel("models/citizen/citizen.vmdl");
		
			Controller = new WalkController();
			Animator = new StandardPlayerAnimator();
			CameraMode = new FixedCamera();

			Clothing.DressEntity(this);
		}
	}
}
