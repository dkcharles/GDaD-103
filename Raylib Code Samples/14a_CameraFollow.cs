using System;
using System.Numerics;
using Raylib_cs; // Make sure to import the Raylib-cs namespace
using static Raylib_cs.Raylib; // Allows direct access to static methods in Raylib

class Program
{
    static void Main(string[] args)
    {
        const int screenWidth = 800;
        const int screenHeight = 450;

        InitWindow(screenWidth, screenHeight, "raylib [core] example - camera following player");

        // Player properties
        Rectangle player = new Rectangle(400, 350, 50, 50);
        float playerSpeed = 5.0f;

        // Ground rectangle
        Rectangle ground = new Rectangle(-1000, 400, 3000, 50);

        // Background rectangles
        Rectangle[] backgroundRects = new Rectangle[]
        {
            new Rectangle(100, 300, 200, 50),
            new Rectangle(500, 150, 200, 100),
            new Rectangle(900, 250, 200, 75),
            new Rectangle(1300, 350, 200, 50),
            new Rectangle(-200, 150, 200, 100)
        };

                // Colors for background rectangles
        Color[] backgroundColors = new Color[backgroundRects.Length];
        Random random = new Random();
        for (int i = 0; i < backgroundColors.Length; i++)
        {
            int grayValue = random.Next(50, 100); // Random dark gray value
            backgroundColors[i] = new Color(grayValue, grayValue, grayValue, 255);
        }
        
        // Camera setup
        Camera2D camera = new Camera2D();
        camera.Target = new Vector2(player.X + player.Width / 2.0f, player.Y + player.Height / 2.0f);
        camera.Offset = new Vector2(screenWidth / 2.0f, screenHeight / 1.5f);
        camera.Rotation = 0.0f;
        camera.Zoom = 1.3f;

        SetTargetFPS(60);

        while (!WindowShouldClose())
        {
            // Update player position
            if (IsKeyDown(KeyboardKey.Right))
            {
                player.X += playerSpeed;
            }
            if (IsKeyDown(KeyboardKey.Left))
            {
                player.X -= playerSpeed;
            }

            // Update camera to follow player
            camera.Target = new Vector2(player.X + player.Width / 2.0f, player.Y + player.Height / 2.0f);

            BeginDrawing();
            ClearBackground(Color.LightGray);

            BeginMode2D(camera);

            // Draw ground
            DrawRectangleRec(ground, Color.DarkGreen);

            // Draw background rectangles with random dark gray colors
            for (int i = 0; i < backgroundRects.Length; i++)
            {
                DrawRectangleRec(backgroundRects[i], backgroundColors[i]);
            }

            // Draw player
            DrawRectangleRec(player, Color.Red);

            EndMode2D();

            EndDrawing();
        }

        CloseWindow();
    }
}
