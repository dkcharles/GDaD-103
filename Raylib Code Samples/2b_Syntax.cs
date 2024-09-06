/*******************************************************************************************
*
*   raylib example - Types and syntax
*
*******************************************************************************************/

using System;
using System.Numerics;
using Raylib_cs; // Make sure to import the Raylib-cs namespace
using static Raylib_cs.Raylib; // Allows direct access to static methods in Raylib

class Program
{
    static void Main(string[] args)
    {
        InitWindow(800, 600, "A basic sample of Raylib-cs syntax");
        SetTargetFPS(60);

        const String WelcomeMessage = "Welcome to the game!";

        while (!WindowShouldClose()) // Detect window close button or ESC key
        {
            BeginDrawing();
            ClearBackground(Color.White);

            // Display the welcome message
            DrawText(WelcomeMessage, GetScreenWidth() / 2 - MeasureText(WelcomeMessage, 20) / 2, GetScreenHeight() / 2, 20, Color.Black);

            EndDrawing();
        }

        CloseWindow(); // Close window and OpenGL context
    }
}