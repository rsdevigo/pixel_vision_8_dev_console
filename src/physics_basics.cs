using System;
namespace PixelVision8.Player {
    public class PhysicsBasics {
        public static bool raycast_box(GameObject obj, int flag, RayDirection direction, GameChip gameChip) {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            switch(direction){
                case RayDirection.LEFT:
                    x1 = obj.x + 1;
                    x2 = obj.x;
                    y1 = obj.y;
                    y2 = obj.y + obj.h - 1;
                    break;
                case RayDirection.RIGHT:
                    x1 = obj.x + obj.w - 1;
                    x2 = obj.x + obj.w;
                    y1 = obj.y;
                    y2 = obj.y + obj.h - 1;
                    break;
                case RayDirection.UP:
                    x1 = obj.x + 2;
                    x2 = obj.x + obj.w - 3;
                    y1 = obj.y - 1;
                    y2 = obj.y;
                    break;
                case RayDirection.DOWN:
                   x1 = obj.x + 2;
                    x2 = obj.x + obj.w - 3;
                    y1 = obj.y + obj.h;
                    y2 = obj.y + obj.h;
                    break;
            }

            x1 /= 8;
            y1 /= 8;
            x2 /= 8;
            y2 /= 8;

            if (gameChip.Flag(x1, y1) == flag || gameChip.Flag(x1, y2) == flag || gameChip.Flag(x2, y1) == flag || gameChip.Flag(x2, y2) == flag)
                return true;

            return false;
        }

        public static bool collide_obj(GameObject objA, GameObject objB) {
            float xd = 0, xs = 0, yd = 0, ys = 0;

            xd = Math.Abs((objA.x+(objA.w/2))-(objB.x+(objB.w/2)));
            xs = (objA.w + objB.w)*0.5f;

            yd = Math.Abs((objA.y+(objA.h/2))-(objB.y+(objB.h/2)));
            ys = (objA.h + objB.h)*0.5f;

            if (xd < xs && yd < ys) return true;

            return false;
        }
    }

    public enum RayDirection {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
}