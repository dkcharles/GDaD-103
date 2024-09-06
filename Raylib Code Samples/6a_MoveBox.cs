using static Raylib_cs.Raylib;
using Raylib_cs;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        // Initialize the window
        const int screenWidth = 800;
        const int screenHeight = 600;
        InitWindow(screenWidth, screenHeight, "Raylib [C#] - Moving Rectangle Example");

        // Set the target FPS
        SetTargetFPS(60);

        // Define rectangle properties
        Vector2 rectPosition = new Vector2(screenWidth / 2, screenHeight / 2);
        int rectWidth = 50;
        int rectHeight = 50;
        float speed = 5.0f;

        // Main game loop
        while (!WindowShouldClose()) // Detect window close button or ESC key
        {
            // Update rectangle position based on cursor keys
            if (IsKeyDown(KeyboardKey.Right)) rectPosition.X += speed;
            if (IsKeyDown(KeyboardKey.Left)) rectPosition.X -= speed;
            if (IsKeyDown(KeyboardKey.Up)) rectPosition.Y -= speed;
            if (IsKeyDown(KeyboardKey.Down)) rectPosition.Y += speed;

            // Prevent the rectangle from moving out of the screen bounds
            if (rectPosition.X < 0) rectPosition.X = 0;
            if (rectPosition.X > screenWidth - rectWidth) rectPosition.X = screenWidth - rectWidth;
            if (rectPosition.Y < 0) rectPosition.Y = 0;
            if (rectPosition.Y > screenHeight - rectHeight) rectPosition.Y = screenHeight - rectHeight;

            // Start drawing
            BeginDrawing();

            // Clear the background with a color
            ClearBackground(Color.White);

            // Draw the rectangle
            DrawRectangle((int)rectPosition.X, (int)rectPosition.Y, rectWidth, rectHeight, Color.Red);

            // End drawing
            EndDrawing();
        }

        // Close the window and OpenGL context
        CloseWindow();
    }
}
