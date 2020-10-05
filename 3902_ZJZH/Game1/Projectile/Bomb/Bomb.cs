﻿using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Bomb : IProjectile
    {
        public IProjectileSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int Velocity { get; set; }

        public bool exist { get; set; }


        public Bomb(Vector2 Position, Vector2 direction)
        {


            
            Direction = direction;
            this.Position = Position + Direction * 60 + new Vector2(20,20);
            Velocity = 120;
            exist = true;
            
            GetSprite = new BombSprite();
            

        }

        public void Update()
        {


            
            Velocity--;
            GetSprite.Update();

            if (Velocity == 0)
            {
                exist = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(spriteBatch, Position);
            }
        }


    }
}
