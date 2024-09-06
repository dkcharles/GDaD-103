using System;
using System.Numerics;
using Raylib_cs; // Make sure to import the Raylib-cs namespace
using static Raylib_cs.Raylib; // Allows direct access to static methods in Raylib


namespace Raylib_HelloWorld;

class Program
{
    static Game game = new Game();
    static void Main(string[] args)
    {     
        game.Run(); // Call the Run method
    }       
}

public class Game
{
    string startMessage = "Welcome to the game!"; // A string variable to store a welcome message
    public Game()
    {
        // Initialization code here
        Console.WriteLine(startMessage); // Print "Hello, World!" to the console
    }

    public void Run()
    {
        const int screenWidth = 800;
        const int screenHeight = 600;

        InitWindow(screenWidth, screenHeight, "raylib boilerplate");
        SetTargetFPS(60);

        while (!WindowShouldClose())
        {
            Update();   // Call the Update method
            Draw();     // Call the Draw method
        }
        CloseWindow();
    }

    // Update method
    private void Update()
    {
        // Update code logic here
    }

    // Draw method
    private void Draw()
    {
        // Draw code here
        BeginDrawing();
        ClearBackground(Color.White);

        EndDrawing();
    }
}
