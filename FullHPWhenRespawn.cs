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

		}
	}

	public class ModdedPlayer : ModPlayer
	{
		public bool wasDead;
		public override void UpdateDead()
		{
			wasDead = true;
		}

        public override void PostUpdate()
        {
			if (wasDead)
			{
				Player.statLife = Player.statLifeMax2;
				wasDead = false;
			}
		}
	}

}