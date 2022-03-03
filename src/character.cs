using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework.Input;
namespace PixelVision8.Player {  
    public class Character : GameObject {
        public Character() {

        }

        public Character(int w, int h, int spr, int x, int y, CustomGameChip gameChip) : base(w, h, spr, x, y, gameChip) {
        }

        

        public void UpdatePlayer(Enemy enemy) {
            if (gameChip.Button(Buttons.Left)) {
                x -= 1;
            }
            if (gameChip.Button(Buttons.Right)) {
                x += 1;
            }
        }
    }

}