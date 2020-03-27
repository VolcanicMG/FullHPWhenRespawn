using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics.Shaders;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.Localization;
using Microsoft.Xna.Framework.Graphics;
using System.IO;
using Microsoft.Xna.Framework.Input;
using Terraria.UI;


namespace FullHPWhenRespawn
{
	public class FullHPWhenRespawn : Mod
	{
		public FullHPWhenRespawn()
		{
			Player player = Main.player[Main.myPlayer];
			
		}

		public int Timer;
		public bool go = false;
		public bool isded = false;

		public override void MidUpdatePlayerNPC()
		{
			Player player = Main.player[Main.myPlayer];


			//Main.NewText(go);
			//Main.NewText(Timer);

			if(player.dead)
			{
				isded = true;
				//Console.WriteLine("We made it to death");
			}

			if (player.respawnTimer == 1 && isded == true)
			{
				
				go = true;
				
			}

			if(go == true)
			{
				Timer++;
				
			}

			if (Timer == 5)
			{

				// Our timer has finished, do something here:
				//Console.WriteLine("We made it revive time");
				player.statLife = player.statLifeMax2;

				Timer = 0;
				go = false;
				isded = false;




			}

			base.MidUpdatePlayerNPC();

		}


	}

}