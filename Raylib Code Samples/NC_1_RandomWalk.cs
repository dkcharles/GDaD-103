
using System;
using System.Collections.Generic;
using Raylib_cs; // Make sure to import the Raylib-cs namespace
using static Raylib_cs.Raylib; // Allows direct access to static methods in Raylib
using static Raylib_cs.KeyboardKey;
using System.Numerics; // Allows direct access to keyboard keys

class Program
{
    static int walkSpeed = 1;
    static int dotSize = 1; // Define the dot size
        public static void Main()
        {
        // Initialize the window
        const int screenWidth = 800;
        const int screenHeight = 600;
        Raylib.InitWindow(screenWidth, screenHeight, "Raylib [C#] - Random Walk");

        Vector2 position = new Vector2(screenWidth / 2, screenHeight / 2);

        // Set the target FPS
        // Raylib.SetTargetFPS(120);

            while (!WindowShouldClose())
            {                             
                BeginDrawing();
                // ClearBackground(Color.White);

                RandomWalk(ref position, screenWidth, screenHeight);
                
                EndDrawing();
            }

            CloseWindow();
        }

        // Function to generate a random number
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Function to generate a random color
        public static Color RandomColor()
        {
            return new Color((byte)RandomNumber(0, 255), (byte)RandomNumber(0, 255), (byte)RandomNumber(0, 255), (byte)255);
        }

        // Function to generate a random direction
        public static Vector2 RandomDirection()
        {
            Vector2 direction;
            direction = new Vector2(RandomNumber(-1, 2), RandomNumber(-1, 2));
            return direction;
        }

        // Function to generate a random position between 0 and the screen width/height
        public static Vector2 RandomPosition(int width, int height)
        {
            return new Vector2(RandomNumber(0, width), RandomNumber(0, height));
        }

        // Function to generate a random walk
        public static void RandomWalk(ref Vector2 position, int screenWidth, int screenHeight)
        {
            Vector2 direction = RandomDirection();

            // Move the position
            position.X += direction.X * walkSpeed;
            position.Y += direction.Y * walkSpeed;

            // Ensure the position stays within the window bounds
            if (position.X < 0) position.X = 0;
            if (position.X > screenWidth) position.X = screenWidth;
            if (position.Y < 0) position.Y = 0;
            if (position.Y > screenHeight) position.Y = screenHeight;

            Color color = RandomColor();

            // Draw the current position
            DrawCircle((int)position.X, (int)position.Y, dotSize, Color.White);
        }
}


