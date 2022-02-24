namespace PixelVision8.Player {  
public class Character {
    int px = 0;
    int py = 0;
    int sprite = 0;
    int w = 0;
    int h = 0;

    public Character(int w, int h, int spr, int px, int py) {
        this.px = px;
        this.py = py;
        this.sprite = spr;
        this.w = w;
        this.h = h;
    }

    public void DrawPlayer()
    {
        DrawGizmoHitBox();
        DrawSprite(sprite, px, py, false, false, DrawMode.Sprite);
    }

    public void DrawGizmoHitBox()
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