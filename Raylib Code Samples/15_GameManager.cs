/*******************************************************************************************
*
*   raylib example - Game Manager Singleton
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
        // Get the singleton instance of GameManager
        GameManager GM = GameManager.Instance;

        InitWindow(GameManager.screenWidth, GameManager.screenHeight, "raylib [core] example - singleton game manager");

        SetTargetFPS(60);

        while (!WindowShouldClose()) // Detect window close button or ESC key
        {
            BeginDrawing();
            ClearBackground(Color.White);

            // Display the welcome message
            DrawText(GameManager.WELCOME_MESSAGE, GameManager.screenWidth / 2 - MeasureText(GameManager.WELCOME_MESSAGE, 20) / 2, GameManager.screenHeight / 2, 20, Color.Black);

            // Display the player health
            string healthText = "Player Health: " + GM.playerHealth;
            DrawText(healthText, 10, 10, 20, Color.Red);

            EndDrawing();
        }

        CloseWindow(); // Close window and OpenGL context
    }
}

// A Game Manager singleton class to manage the game - can be used to store global variables and methods
public sealed class GameManager
{
    private static GameManager? instance;
    
    public const string WELCOME_MESSAGE = "Hello, world!";
    public const int screenWidth = 800;
    public const int screenHeight = 600;

    public int playerHealth = 100; // Player health

    // Private constructor to prevent instantiation from outside the class
    private GameManager()
    {
        // Initialization code here
    }
    
    // Public static method to get the singleton instance
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }
    
}
