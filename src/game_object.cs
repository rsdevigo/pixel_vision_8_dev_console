namespace PixelVision8.Player {
    public class GameObject {
        public int x = 0;
        public int y = 0;
        public int sprite = 0;
        public int w = 0;
        public int h = 0;
        public CustomGameChip gameChip;

        public GameObject() {

        }
        public GameObject(int w, int h, int spr, int x, int y, CustomGameChip gameChip) {
            this.x = x;
            this.y = y;
            this.sprite = spr;
            this.w = w;
            this.h = h;
            this.gameChip = gameChip;
        }

        public void DrawGameObject()
        {
            if (gameChip.debug) DrawGizmoHitBox();
            gameChip.DrawSprite(sprite, x, y, false, false, DrawMode.Sprite);
        }

        public void DrawGizmoHitBox()
        {
            int[] pixelData = new int[w*h];

            for(int i = 0; i < w; i++) {
                pixelData[i] = 15;
            }

            int j = 1;

            for(int i = w; i <= w * h - w; i++) {
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
            
            gameChip.DrawPixels(pixelData, x, y, w, h, false, false, DrawMode.SpriteBelow);
        }
    }
}