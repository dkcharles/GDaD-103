/*******************************************************************************************
*
*   raylib example - Falling circles
*
*******************************************************************************************/


using System;
using System.Numerics;
using Raylib_cs; // Make sure to import the Raylib-cs namespace
using static Raylib_cs.Raylib; // Allows direct access to static methods in Raylib

class Program
{
    // Structure to hold circle properties
    struct Circle
    {
        public float x;
        public float y;
        public float radius;
        public Color color;
        public float speed;
    }

    static void Main(string[] args)
    {
        const int screenWidth = 800;
        const int screenHeight = 450;

        InitWindow(screenWidth, screenHeight, "raylib [core] example - falling circles");

        Random random = new Random();
        int circleCount = 10;
        Circle[] circles = new Circle[circleCount];

        // Initialize circles with random positions, sizes, colors, and speeds
        for (int i = 0; i < circleCount; i++)
        {
            circles[i] = new Circle
            {
                x = random.Next(0, screenWidth),
                y = random.Next(-screenHeight, 0),
                radius = random.Next(10, 40),
                color = new Color(random.Next(256), random.Next(256), random.Next(256), 255),
                speed = random.Next(1, 8)
            };
        }

        SetTargetFPS(60);

        while (!WindowShouldClose())
        {
            // Update circle positions
            for (int i = 0; i < circleCount; i++)
            {
                circles[i].y += circles[i].speed;

                // If a circle moves off the bottom of the screen, recycle it to a new random position at the top
                if (circles[i].y - circles[i].radius > screenHeight)
                {
                    circles[i].x = random.Next(0, screenWidth);
                    circles[i].y = -circles[i].radius;
                    circles[i].radius = random.Next(10, 40);
                    circles[i].color = new Color(random.Next(256), random.Next(256), random.Next(256), 255);
                    circles[i].speed = random.Next(1, 8);
                }
            }

            BeginDrawing();
            ClearBackground(Color.White);

            // Draw circles
            foreach (var circle in circles)
            {
                DrawCircleV(new Vector2(circle.x, circle.y), circle.radius, circle.color);
            }

            EndDrawing();
        }

        CloseWindow();
    }
}
