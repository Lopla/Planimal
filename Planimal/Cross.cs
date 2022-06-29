using SkiaSharp;

namespace Planimal
{
    public class Cross : GO
    {
        public override void Draw(DrawHandle handle)
        {
            handle.surface.Canvas.DrawLine(-10,0,10,0, handle.BlackLines);
            handle.surface.Canvas.DrawLine(0,-10,0,10, handle.BlackLines);        
        }
    }
}