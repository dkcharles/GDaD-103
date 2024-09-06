using System;
using System.Numerics;
using Raylib_cs; // Make sure to import the Raylib-cs namespace
using static Raylib_cs.Raylib; // Allows direct access to static methods in Raylib

// Note use of GameManger to reference const values but GM to reference variables in the GameManager Singleton class
// Note also that there are no bare numbers here, but consts and variables used for everything
namespace RayGame;
public class Game
{
    GameManager GM = GameManager.Instance; // Create a new instance of the GameManager class
    public Game()
    {
        // Initialization code here
        Console.WriteLine(GameManager.WELCOME_MESSAGE); // Print "Hello, World!" to the console
    }

    public void Run()
    {

        InitWindow(GameManager.SCREENWIDTH, GameManager.SCREENHEIGHT, GameManager.WINDOW_TITLE);
        SetTargetFPS(GM.frameRate);

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