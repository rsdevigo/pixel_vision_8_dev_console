using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework.Input;
namespace PixelVision8.Player {  
    public class Enemy : GameObject {

        public Enemy() {

        }

        public Enemy(int w, int h, int spr, int x, int y, CustomGameChip gameChip) : base(w, h, spr, x, y, gameChip) {
        }

        
    }

}