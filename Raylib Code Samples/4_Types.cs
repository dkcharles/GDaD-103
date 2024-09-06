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
            const int screenHeight = 450;
            InitWindow(screenWidth, screenHeight, "Raylib [C#] - Data Types Example");

            // Set the target FPS
            SetTargetFPS(60);

            // Define various data types
            int rectX = 100;
            int rectY = 100;
            int rectWidth = 200;
            int rectHeight = 150;

            float circleX = 400.0f; // f suffix is needed to specify a float literal
            float circleY = 225.0f;
            float circleRadius = 50.0f;

            string message = "Hello, Raylib!";
            bool showMessage = true;

            Color rectColor = Color.Green;
            Color circleColor = Color.Blue;
            Color textColor = Color.DarkGray;

            // Main game loop
            while (!WindowShouldClose()) // Detect window close button or ESC key
            {
                // Update logic can go here

                // Start drawing
                BeginDrawing();
                
                // Clear the background with a color
                ClearBackground(Color.RayWhite);

                // Draw rectangle
                DrawRectangle(rectX, rectY, rectWidth, rectHeight, rectColor);
                RDrawRectangleLines(rectX, rectY, rectWidth, rectHeight, Color.Black);

                // Draw circle
                DrawCircle((int)circleX, (int)circleY, circleRadius, circleColor); // cast float to int
                DrawCircleLines((int)circleX, (int)circleY, circleRadius, Color.Black);

                // Draw text if showMessage is true
                if (showMessage)
                {
                    Raylib.DrawText(message, screenWidth / 2 - 100, screenHeight / 2 + 100, 20, textColor);
                }

                // End drawing
                EndDrawing();
            }

            // Close the window and OpenGL context
            CloseWindow();
        }
    }
}