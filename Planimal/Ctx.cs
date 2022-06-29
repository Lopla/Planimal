using Pla.Lib;
using SkiaSharp;

namespace Planimal
{
    internal class Ctx : IContext, IControl, IPainter
    {
        public World W = new World();

        SKPoint worldOffset = new SKPoint()
        {
            X = 100,
            Y = 100
        };

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
            this.W.Init();            
        }

        public void KeyDown(uint key)
        {
        }

        public void Paint(SKImageInfo info, SKSurface surface)
        {
            surface.Canvas.Translate(worldOffset);
            
            W.Draw(surface);
        }
    }
}