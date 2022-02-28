﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace ConsoleGame
{
    public class StrawberryUtils
    {
        // Catch current game instance
        protected Game _game = Game1._game;

        public class Math : StrawberryUtils
            {
                public static float Lerp(float valueA, float valueB, float amount)
                {
                    return valueA * (1 - amount) + valueB * amount;
                }

                public static Vector2 Lerp(Vector2 valueA, Vector2 valueB, float amount)
                {
                    float retX = Lerp(valueA.X, valueB.X, amount);
                    float retY = Lerp(valueA.Y, valueB.Y, amount);

                    return new Vector2(retX, retY);
                }
              

            }


        public class Graphics : StrawberryUtils
        {
            public static void DrawSprite(Texture2D sprite, Vector2 position, Color color, SpriteBatch _spriteBatch)
            {
                //_spriteBatch.Begin();
                _spriteBatch.Draw(sprite, position, color);
                //_spriteBatch.End();

            }

        }

        public class ECS: StrawberryUtils
        {
            

            public static Entity FlushEntities(List<Entity> entityList)
            {
                if(Game1.entityRegistry.Count > 0)
                { 
                    foreach(Entity entity in entityList)
                    {
                        //Game1.entityRegistry.Remove(entity);
                    }
                }
                return null;
            }
            public static Entity DestroyEntity(uint ID)
            {
                foreach(KeyValuePair<uint,Entity> pair in Game1.entityRegistry)
                {
                    if(pair.Key == ID)
                    {
                        Game1.entityRegistry.Remove(pair);
                        Game1._activeScene.ind++;
                    }
                }
                return null;
            }

        }


    }
}
