using Game1;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{

<<<<<<< HEAD
		public static class Texture2DStorage
		{
			// Note that we are not using Game1's ContentLoader here (outside the scope of class methods) since it has not been instantiated yet
			private static Texture2D UpIdleLinkSpriteSheet;
			private static Texture2D UpMovingLinkSpriteSheet;
        private static Texture2D UpUseItemSpriteSheet;
        private static Texture2D DownIdleLinkSpriteSheet;
		private static Texture2D DownMovingLinkSpriteSheet;
        private static Texture2D DownUseItemSpriteSheet;
        private static Texture2D LeftIdleLinkSpriteSheet;
		private static Texture2D LeftMovingLinkSpriteSheet;
        private static Texture2D LeftUseItemSpriteSheet;
        private static Texture2D RightIdleLinkSpriteSheet;
		private static Texture2D RightMovingLinkSpriteSheet;
        private static Texture2D RightUseItemSpriteSheet;
        private static Texture2D UpWoodenSwordLinkSpriteSheet;
		private static Texture2D DownWoodenSwordLinkSpriteSheet;
		private static Texture2D LeftWoodenSwordLinkSpriteSheet;
		private static Texture2D RightWoodenSwordLinkSpriteSheet;

        private static Texture2D UpWoodenArrowSpriteSheet;
        private static Texture2D DownWoodenArrowSpriteSheet;
        private static Texture2D LeftWoodenArrowSpriteSheet;
        private static Texture2D RightWoodenArrowSpriteSheet;
        private static Texture2D BombSpriteSheet;
        private static Texture2D BoomerSpriteSheet;
        private static Texture2D DamagedLinkSpriteSheet;


		// More private static Texture2D fields follow
		// ...

		// static classes have no constructor, but we need a method to initialize the Texture2D fieldsw
		public static void LoadAllTextures(ContentManager content)
			{
				UpIdleLinkSpriteSheet = content.Load<Texture2D>("images/UpIdle");
			UpMovingLinkSpriteSheet = content.Load<Texture2D>("images/UpMoving");
			UpUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponBack");

			LeftIdleLinkSpriteSheet = content.Load<Texture2D>("images/LeftIdle");
			LeftMovingLinkSpriteSheet = content.Load<Texture2D>("images/LeftMoving");
			LeftUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponLeft");

			DownIdleLinkSpriteSheet = content.Load<Texture2D>("images/DownIdle");
			DownMovingLinkSpriteSheet = content.Load<Texture2D>("images/DownMoving");
			DownUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponFront");

			RightIdleLinkSpriteSheet = content.Load<Texture2D>("images/RightIdle");
			RightMovingLinkSpriteSheet = content.Load<Texture2D>("images/RightMoving");
			RightUseItemSpriteSheet = content.Load<Texture2D>("images/UseItemWeapon/UseItemWeaponRight");

			UpWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/UpWoodenSword");
			DownWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/DownWoodenSword");
			LeftWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/LeftWoodenSword");
			RightWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/RightWoodenSword");

			UpWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/UpArrow");
			DownWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/DownArrow");
			LeftWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/LeftArrow");
			RightWoodenArrowSpriteSheet = content.Load<Texture2D>("images/projectile/arrow/RightArrow");

			BombSpriteSheet = content.Load<Texture2D>("images/projectile/Bomb");
			BoomerSpriteSheet = content.Load<Texture2D>("images/projectile/Boomerang");

			DamagedLinkSpriteSheet = content.Load<Texture2D>("images/DamagedLink");


			// More Content.Load calls follow
			//...
		}

		public static void UnloadAllTextures()
			{
				// unload all the Texture2Ds - not needed for the scope of this project
			}

		public static Texture2D GetDamagedLinkSpriteSheet()
		{
			return DamagedLinkSpriteSheet;
		}

		public static Texture2D GetUpIdleLinkSpriteSheet()
		{
			return UpIdleLinkSpriteSheet;
		}

		public static Texture2D GetUpMovingLinkSpriteSheet()
		{
			return UpMovingLinkSpriteSheet;
		}

		public static Texture2D GetUpUseItemLinkSpriteSheet()
		{
			return UpUseItemSpriteSheet;
		}

		

		
		

		public static Texture2D GetDownIdleLinkSpriteSheet()
		{
			return DownIdleLinkSpriteSheet;
		}

		public static Texture2D GetDownMovingLinkSpriteSheet()
		{
			return DownMovingLinkSpriteSheet;
		}

		public static Texture2D GetDownUseItemLinkSpriteSheet()
		{
			return DownUseItemSpriteSheet;
		}

		public static Texture2D GetLeftIdleLinkSpriteSheet()
		{
			return LeftIdleLinkSpriteSheet;
		}

		public static Texture2D GetLeftMovingLinkSpriteSheet()
		{
			return LeftMovingLinkSpriteSheet;
		}

		public static Texture2D GetLeftUseItemLinkSpriteSheet()
		{
			return LeftUseItemSpriteSheet;
		}

		public static Texture2D GetRightIdleLinkSpriteSheet()
		{
			return RightIdleLinkSpriteSheet;
		}

		public static Texture2D GetRightMovingLinkSpriteSheet()
		{
			return RightMovingLinkSpriteSheet;
		}

		public static Texture2D GetRightUseItemLinkSpriteSheet()
		{
			return RightUseItemSpriteSheet;
		}

		public static Texture2D GetUpWoodenSwordLinkSpriteSheet()
		{
			return UpWoodenSwordLinkSpriteSheet;
		}

		public static Texture2D GetDownWoodenSwordLinkSpriteSheet()
		{
			return DownWoodenSwordLinkSpriteSheet;
		}

		public static Texture2D GetLeftWoodenSwordLinkSpriteSheet()
		{
			return LeftWoodenSwordLinkSpriteSheet;
		}

		public static Texture2D GetRightWoodenSwordLinkSpriteSheet()
		{
			return RightWoodenSwordLinkSpriteSheet;
		}

		public static Texture2D GetUpWoodenArrowSpriteSheet()
		{
			return UpWoodenArrowSpriteSheet;
		}

		public static Texture2D GetDownWoodenArrowSpriteSheet()
		{
			return DownWoodenArrowSpriteSheet;
		}

		public static Texture2D GetLeftWoodenArrowSpriteSheet()
		{
			return LeftWoodenArrowSpriteSheet;
		}

		public static Texture2D GetRightWoodenArrowSpriteSheet()
		{
			return RightWoodenArrowSpriteSheet;
		}

		public static Texture2D GetBombSpriteSheet()
		{
			return BombSpriteSheet;
		}
		public static Texture2D GetBoomerSpriteSheet()
		{
			return BoomerSpriteSheet;
		}
	}
	
=======
    public static class Texture2DStorage
    {
        // Note that we are not using Game1's ContentLoader here (outside the scope of class methods) since it has not been instantiated yet
        private static Texture2D UpIdleLinkSpriteSheet;
        private static Texture2D UpMovingLinkSpriteSheet;

        private static Texture2D DownIdleLinkSpriteSheet;
        private static Texture2D DownMovingLinkSpriteSheet;

        private static Texture2D LeftIdleLinkSpriteSheet;
        private static Texture2D LeftMovingLinkSpriteSheet;

        private static Texture2D RightIdleLinkSpriteSheet;
        private static Texture2D RightMovingLinkSpriteSheet;

        private static Texture2D UpWoodenSwordLinkSpriteSheet;
        private static Texture2D DownWoodenSwordLinkSpriteSheet;
        private static Texture2D LeftWoodenSwordLinkSpriteSheet;
        private static Texture2D RightWoodenSwordLinkSpriteSheet;

        private static Texture2D UpOctorokSpriteSheet;
        private static Texture2D DownOctorokSpriteSheet;
        private static Texture2D LeftOctorokSpriteSheet;
        private static Texture2D RightOctorokSpriteSheet;

        private static Texture2D UpBlueOctorokSpriteSheet;
        private static Texture2D DownBlueOctorokSpriteSheet;
        private static Texture2D LeftBlueOctorokSpriteSheet;
        private static Texture2D RightBlueOctorokSpriteSheet;

        private static Texture2D UpBlueMSpriteSheet;
        private static Texture2D DownBlueMSpriteSheet;
        private static Texture2D LeftBlueMSpriteSheet;
        private static Texture2D RightBlueMSpriteSheet;

        private static Texture2D OldManSpriteSheet;
        private static Texture2D OldWomanSpriteSheet;

        private static Texture2D MerchantRSpriteSheet;
        private static Texture2D MerchantPSpriteSheet;
        private static Texture2D MerchantGSpriteSheet;

        private static Texture2D DamagedLinkSpriteSheet;
        private static Texture2D LinkUseItemSpriteSheet;

        // More private static Texture2D fields follow
        // ...

        // static classes have no constructor, but we need a method to initialize the Texture2D fields
        public static void LoadAllTextures(ContentManager content)
        {
            UpIdleLinkSpriteSheet = content.Load<Texture2D>("images/UpIdle");
            UpMovingLinkSpriteSheet = content.Load<Texture2D>("images/UpMoving");

            LeftIdleLinkSpriteSheet = content.Load<Texture2D>("images/LeftIdle");
            LeftMovingLinkSpriteSheet = content.Load<Texture2D>("images/LeftMoving");

            DownIdleLinkSpriteSheet = content.Load<Texture2D>("images/DownIdle");
            DownMovingLinkSpriteSheet = content.Load<Texture2D>("images/DownMoving");

            RightIdleLinkSpriteSheet = content.Load<Texture2D>("images/RightIdle");
            RightMovingLinkSpriteSheet = content.Load<Texture2D>("images/RightMoving");

            UpWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/UpWoodenSword");
            DownWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/DownWoodenSword");
            LeftWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/LeftWoodenSword");
            RightWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/RightWoodenSword");

            UpOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokUp");
            DownOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokDown");
            LeftOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokLeft");
            RightOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokRight");

            UpBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueOctorokUp");
            DownBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueOctorokDown");
            LeftBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueOctorokLeft");
            RightBlueOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/BlueOctorokRight");

            UpBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMUp");
            DownBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMDown");
            LeftBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMLeft");
            RightBlueMSpriteSheet = content.Load<Texture2D>("images/Enemy/BlueM/blueMRight");

            OldManSpriteSheet = content.Load<Texture2D>("images/Npc/OldMan");
            OldWomanSpriteSheet = content.Load<Texture2D>("images/Npc/OldWoman");
            MerchantRSpriteSheet = content.Load<Texture2D>("images/Npc/MerchantR");
            MerchantPSpriteSheet = content.Load<Texture2D>("images/Npc/MerchantP");
            MerchantGSpriteSheet = content.Load<Texture2D>("images/Npc/MerchantG");

            DamagedLinkSpriteSheet = content.Load<Texture2D>("images/DamagedLink");
            LinkUseItemSpriteSheet = content.Load<Texture2D>("images/LinkUseItem");


            // More Content.Load calls follow
            //...
        }

        public static void UnloadAllTextures()
        {
            // unload all the Texture2Ds - not needed for the scope of this project
        }

        public static Texture2D GetUpIdleLinkSpriteSheet()
        {
            return UpIdleLinkSpriteSheet;
        }

        public static Texture2D GetUpMovingLinkSpriteSheet()
        {
            return UpMovingLinkSpriteSheet;
        }

        public static Texture2D GetDownIdleLinkSpriteSheet()
        {
            return DownIdleLinkSpriteSheet;
        }

        public static Texture2D GetDownMovingLinkSpriteSheet()
        {
            return DownMovingLinkSpriteSheet;
        }

        public static Texture2D GetLeftIdleLinkSpriteSheet()
        {
            return LeftIdleLinkSpriteSheet;
        }

        public static Texture2D GetLeftMovingLinkSpriteSheet()
        {
            return LeftMovingLinkSpriteSheet;
        }

        public static Texture2D GetRightIdleLinkSpriteSheet()
        {
            return RightIdleLinkSpriteSheet;
        }

        public static Texture2D GetRightMovingLinkSpriteSheet()
        {
            return RightMovingLinkSpriteSheet;
        }

        public static Texture2D GetUpWoodenSwordLinkSpriteSheet()
        {
            return UpWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetDownWoodenSwordLinkSpriteSheet()
        {
            return DownWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetLeftWoodenSwordLinkSpriteSheet()
        {
            return LeftWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetRightWoodenSwordLinkSpriteSheet()
        {
            return RightWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetUpMovingOctorokSpriteSheet()
        {
            return UpOctorokSpriteSheet;
        }

        public static Texture2D GetDownMovingOctorokSpriteSheet()
        {
            return DownOctorokSpriteSheet;
        }

        public static Texture2D GetLeftMovingOctorokSpriteSheet()
        {
            return LeftOctorokSpriteSheet;
        }

        public static Texture2D GetRightMovingOctorokSpriteSheet()
        {
            return RightOctorokSpriteSheet;
        }

        public static Texture2D GetUpMovingBlueOctorokSpriteSheet()
        {
            return UpBlueOctorokSpriteSheet;
        }

        public static Texture2D GetDownMovingBlueOctorokSpriteSheet()
        {
            return DownBlueOctorokSpriteSheet;
        }

        public static Texture2D GetLeftMovingBlueOctorokSpriteSheet()
        {
            return LeftBlueOctorokSpriteSheet;
        }

        public static Texture2D GetRightMovingBlueOctorokSpriteSheet()
        {
            return RightBlueOctorokSpriteSheet;
        }

        public static Texture2D GetUpMovingBlueMSpriteSheet()
        {
            return UpBlueMSpriteSheet;
        }

        public static Texture2D GetDownMovingBlueMSpriteSheet()
        {
            return DownBlueMSpriteSheet;
        }

        public static Texture2D GetLeftMovingBlueMSpriteSheet()
        {
            return LeftBlueMSpriteSheet;
        }

        public static Texture2D GetRightMovingBlueMSpriteSheet()
        {
            return RightBlueMSpriteSheet;
        }

        public static Texture2D GetOldManSpriteSheet()
        {
            return OldManSpriteSheet;
        }

        public static Texture2D GetOldWomanSpriteSheet()
        {
            return OldWomanSpriteSheet;
        }

        public static Texture2D GetMerchantRSpriteSheet()
        {
            return MerchantRSpriteSheet;
        }

        public static Texture2D GetMerchantPSpriteSheet()
        {
            return MerchantPSpriteSheet;
        }

        public static Texture2D GetMerchantGSpriteSheet()
        {
            return MerchantGSpriteSheet;
        }

        public static Texture2D GetDamagedLinkSpriteSheet()
        {
            return DamagedLinkSpriteSheet;
        }

        public static Texture2D GetLinkUseItemSpriteSheet()
        {
            return LinkUseItemSpriteSheet;
        }


    }

>>>>>>> 632ba7d96f10c1bda5dd71d1290be474ab379f7f
}
