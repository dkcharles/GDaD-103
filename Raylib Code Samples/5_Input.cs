using System.Numerics; // needed for math operations in Raylib_cs
using static Raylib_cs.Raylib; // means we can use Raylib functions without the Raylib prefix
using Raylib_cs; // needed for Raylib functions

namespace GDAD_Examples
{
public class Program
    {
        public static void Main()
        {
            // Initialize the window
            const int screenWidth = 800;
            const int screenHeight = 450;
            InitWindow(screenWidth, screenHeight, "Raylib [C#] - Question and Answer Example");

            // Set the target FPS
            SetTargetFPS(60);

            // Define the question and the correct answer
            string question = "Is Raylib a game development library? (y/n)";
            char correctAnswer = 'y';
            
            // Variable to store user input
            char userInput = '\0';
            string resultMessage = "";

            // Main game loop
            while (!WindowShouldClose()) // Detect window close button or ESC key
            {
                // Update: Check for key press
                if (IsKeyPressed(KeyboardKey.Y))
                {
                    userInput = 'y';
                }
                else if (IsKeyPressed(KeyboardKey.N))
                {
                    userInput = 'n';
                }

                // Check the answer
                if (userInput == correctAnswer)
                {
                    resultMessage = "Correct!";
                }
                else if (userInput != '\0')
                {
                    resultMessage = "Wrong!";
                }

                // Start drawing
                BeginDrawing();
                
                // Clear the background with a color
                ClearBackground(Color.RayWhite);

                // Draw the question
                DrawText(question, screenWidth / 2 - 200, screenHeight / 2 - 50, 20, Color.Black);
                
                // Draw the result message
                if (!string.IsNullOrEmpty(resultMessage))
                {
                    DrawText(resultMessage, screenWidth / 2 - 50, screenHeight / 2 + 20, 20, Color.Red);
                }

                // End drawing
                EndDrawing();
            }

            // Close the window and OpenGL context
            CloseWindow();
        }
    }
}