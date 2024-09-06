using System.Numerics; // needed for math operations in Raylib_cs
using static Raylib_cs.Raylib; // means we can use Raylib functions without the Raylib prefix
using Raylib_cs; // needed for Raylib functions

namespace GDAD_Examples
{
class Program
    {
        public static void Main()
        {
            GameManager GM = GameManager.Instance; // Game manager singleton instance reference
            InitWindow(GameManager.screenWidth, GameManager.screenHeight, "raylib mouse example");
            
            Vector2 mousePosition = new Vector2();

            while (!WindowShouldClose())
            {
                mousePosition = Raylib.GetMousePosition();
                
                string mouseText = $"Mouse: ({mousePosition.X:F0}, {mousePosition.Y:F0})"; 
                
                BeginDrawing();
                ClearBackground(Color.White);

                DrawText(mouseText, 12, 12, 20, Color.Black);

                EndDrawing();
            }

            CloseWindow();
        }
    }
}