using SkiaSharp;

namespace Planimal
{
    public class GO
    {
        /// <summary>
        /// Draw localy
        /// </summary>
        public virtual void Draw(DrawHandle handle)
        {
            using(var p = new SKPaint(){
                Color = SKColor.Parse("000"),
                StrokeWidth = 1,
            })
            {
                handle.surface.Canvas.DrawLine(0,0,0,0, p);
            }
        }
    }
}