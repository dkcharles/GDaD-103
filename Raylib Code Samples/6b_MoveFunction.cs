using static Raylib_cs.Raylib;
using Raylib_cs;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        // Initialize the window
        const int screenWidth = 800;
        const int screenHeight = 450;
        InitWindow(screenWidth, screenHeight, "Raylib [C#] - Moving Rectangle with Function Example");

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
            // Update rectangle position
            rectPosition = UpdateRectanglePosition(rectPosition, speed, rectWidth, rectHeight, screenWidth, screenHeight);

            BeginDrawing();
            ClearBackground(Color.White);

            DrawRectangle((int)rectPosition.X, (int)rectPosition.Y, rectWidth, rectHeight, Color.Red);

            EndDrawing();
        }

        // Close the window and OpenGL context
        CloseWindow();
    }

    // Function to update the rectangle's position
    // Must be static to be called from the Main function
    static Vector2 UpdateRectanglePosition(Vector2 position, float speed, int rectWidth, int rectHeight, int screenWidth, int screenHeight)
    {
        // Update position based on cursor keys
        if (IsKeyDown(KeyboardKey.Right)) position.X += speed;
        if (IsKeyDown(KeyboardKey.Left)) position.X -= speed;
        if (IsKeyDown(KeyboardKey.Up)) position.Y -= speed;
        if (IsKeyDown(KeyboardKey.Down)) position.Y += speed;

        // Prevent the rectangle from moving out of the screen bounds
        if (position.X < 0) position.X = 0;
        if (position.X > screenWidth - rectWidth) position.X = screenWidth - rectWidth;
        if (position.Y < 0) position.Y = 0;
        if (position.Y > screenHeight - rectHeight) position.Y = screenHeight - rectHeight;

        return position;
    }
}
