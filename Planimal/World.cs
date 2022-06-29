using SkiaSharp;

namespace Planimal
{
    public class World
    {
        List<GO> GOs = new List<GO>();

        public void Draw(SkiaSharp.SKSurface surface)
        {
            var handle = new DrawHandle();
            handle.surface = surface;
            using(handle.BlackLines = new SKPaint(){
                Color = SKColor.Parse("000")
            })
            {
                foreach(var g in GOs)
                {
                    g.Draw(handle);
                }
            }            
        }

        public void Init()
        {
            GOs.Add(new Cross());
            GOs.Add(new Worm());
        }
    }
}