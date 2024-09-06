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

            // Define positions and sizes
            int rectX = 100;
            int rectY = 100;
            int rectWidth = 200;
            int rectHeight = 150;

            int circleX = 400;
            int circleY = 225;
            float circleRadius = 50.0f;

            while (!WindowShouldClose())
            {                             
                BeginDrawing();
                ClearBackground(Color.White);

                // Draw rectangle
                DrawRectangle(rectX, rectY, rectWidth, rectHeight, Color.Red);
                DrawRectangleLines(rectX, rectY, rectWidth, rectHeight, Color.Black);
                
                // Draw circle
                DrawCircle(circleX, circleY, circleRadius, Color.Blue);
                DrawCircleLines(circleX, circleY, circleRadius, Color.Black);

                EndDrawing();
            }

            CloseWindow();
        }
    }
}