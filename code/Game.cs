using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PCT
{
	public partial class PCTGame : Game
	{
		public static PCTGame Instance {get; private set;}

		public PCTGame() 
		{
			Instance = this;

			if (IsServer) 
			{
				// _ = new PCTHud();
			}
		}

		public override void ClientJoined( Client cl )
		{
			base.ClientJoined( cl );

			var player = new PCTPlayer();
			player.Respawn();
			
			cl.Pawn = player;
		}
	}
}
