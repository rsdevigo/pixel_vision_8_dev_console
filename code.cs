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
    public override void Init()
    {
      BackgroundColor(5);
      LoadTilemap("tilemap-0");
      player = new Player{w = 8, h = 8, sprite = 1, px = 74, py = 74};
    }

    public override void Draw()
    {
      RedrawDisplay();
      player.DrawPlayer();
      
    }

    public override void Update(int timeDelta)
    {
      bool isPlaying = IsChannelPlaying(0);
      if (Key(Keys.P) && !isPlaying) PlaySound(4, 0);
    }
    
    public void DrawGizmoHitBox(int px, int py, int w, int h)
    {
      int[] pixelData = new int[w*h];

      for(int i = 0; i < w; i++) {
        pixelData[i] = 15;
      }

      int j = 1;

      for(int i = w; i < w * h - w; i++) {
        if (i == w * j) {
          j++;
          pixelData[i] = 15;
          pixelData[i-1] = 15;
        } else {
          pixelData[i] = -1;
        }
      }

      for(int i = w*h - w; i < w*h; i++) {
        pixelData[i] = 15;
      }
      
      DrawPixels(pixelData, px, py, w, h, false, false, DrawMode.SpriteBelow);
    }
  }
}
