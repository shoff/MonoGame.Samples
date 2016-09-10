

namespace Platformer2D
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            using (var game = new PlatformerGame())
            {
                game.Run();
            }

        }
    }

}
