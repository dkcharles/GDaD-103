using System.Numerics; // needed for math operations in Raylib_cs
using static Raylib_cs.Raylib; // means we can use Raylib functions without the Raylib prefix
using Raylib_cs; // needed for Raylib functions

namespace GDAD_Examples
{
class Program
    {
        public static void Main()
        {
        // Initialize the window
        const int screenWidth = 800;
        const int screenHeight = 600;
        Raylib.InitWindow(screenWidth, screenHeight, "Raylib [C#] - Hello World Example");

        // Set the target FPS
        Raylib.SetTargetFPS(60);

            while (!WindowShouldClose())
            {                             
                BeginDrawing();
                ClearBackground(Color.White);

                // Draw "Hello, World!" text in the middle of the screen - what is wrong with this?
                Raylib.DrawText("Hello, World!", screenWidth / 2, screenHeight / 2, 20, Color.DarkGray);
 
                EndDrawing();
            }

            CloseWindow();
        }
    }
}