using Pla.Lib;
using SkiaSharp;

namespace Planimal
{
    internal class Ctx : IContext, IControl, IPainter
    {
        public void Click(SKPoint argsLocation)
        {
            
        }

        public IControl GetControl()
        {
            return this;
        }

        public IPainter GetPainter()
        {
            return this;
        }

        public void Init(IEngine engine)
        {
            
        }

        public void KeyDown(uint key)
        {
            
        }

        public void Paint(SKImageInfo info, SKSurface surface)
        {
            surface.Canvas.DrawCircle(100,100,50,new SKPaint(){
                Color = SKColor.Parse("f00")
            });
        }
    }
}