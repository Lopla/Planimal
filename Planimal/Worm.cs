using SkiaSharp;

namespace Planimal
{
    public class Worm : GO
    {
        public override void Draw(DrawHandle handle)
        {
            handle.surface.Canvas.DrawLine(-10,-10,10,10, handle.BlackLines);
        }
    }
}