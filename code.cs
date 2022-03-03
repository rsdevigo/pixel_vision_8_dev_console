//
// Pixel Vision 8 - New Template Script
// Copyright (C) 2017, Pixel Vision 8 (@pixelvision8)
// Created by Jesse Freeman (@jessefreeman)
// Converted from the Lua file by Drake Williams [drakewill+pv8@gmail.com]
//
// This project was designed to display some basic instructions when you create
// a new game.  Simply delete the following code and implement your own Init(),
// Update() and Draw() logic.
// 
// Learn more about making Pixel Vision 8 games at
// https://www.pixelvision8.com/getting-started
// 
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
namespace PixelVision8.Player
{
  public class CustomGameChip : GameChip
  {
    Character player;
    Enemy enemy;
    public bool debug = false;
    public override void Init()
    {
      BackgroundColor(5);
      LoadTilemap("tilemap-0");
      player = new Character{w = 8, h = 8, sprite = 1, x = 71, y = 69, gameChip = this};
      enemy = new Enemy{w = 8, h = 8, sprite = 18, x = 78, y = 69, gameChip = this};
    }

    public override void Draw()
    {
      RedrawDisplay();
      player.DrawGameObject();
      enemy.DrawGameObject();
      
    }

    public override void Update(int timeDelta)
    {
      bool isPlaying = IsChannelPlaying(0);
      if (Key(Keys.P) && !isPlaying) PlaySound(4, 0);
      player.UpdatePlayer(enemy);
    }
  }
}
