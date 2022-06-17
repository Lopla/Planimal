namespace Planimal;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Pla.Win.App.PlaMain(new Ctx());
    }    
}