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
        InitWindow(screenWidth, screenHeight, "Raylib [C#] - Drawing Shapes Example");

        // Set the target FPS
        SetTargetFPS(60);

            while (!WindowShouldClose())
            {                             
                BeginDrawing();
                ClearBackground(Color.White);

            // Draw rectangles
            DrawRectangle(100, 100, 200, 150, Color.Red);
            DrawRectangleLines(100, 100, 200, 150, Color.Black);
            
            // Draw circles
            DrawCircle(400, 225, 50, Color.Blue);
            DrawCircleLines(400, 225, 50, Color.Black);
            
            // Draw more shapes
            DrawRectangle(500, 200, 100, 100, Color.Green);
            DrawRectangleLines(500, 200, 100, 100, Color.Black);

            DrawCircle(650, 300, 75, Color.Yellow);
            DrawCircleLines(650, 300, 75, Color.Black);
 
                EndDrawing();
            }

            CloseWindow();
        }
    }
}