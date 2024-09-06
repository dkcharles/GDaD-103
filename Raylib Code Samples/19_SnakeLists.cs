using System;
using System.Collections.Generic;
using Raylib_cs; // Import the Raylib-cs namespace
using static Raylib_cs.Raylib; // Allows direct access to static methods in Raylib
using static Raylib_cs.KeyboardKey; // Allows direct access to keyboard keys

class Program
{
    struct SnakeSegment
    {
        public int x;
        public int y;
    }

    static void Main(string[] args)
    {
        const int screenWidth = 800;
        const int screenHeight = 600;
        const int gridSize = 20;
        const int initialLength = 5;

        InitWindow(screenWidth, screenHeight, "Snake Game");

        List<SnakeSegment> snake = new List<SnakeSegment>();
        for (int i = 0; i < initialLength; i++)
        {
            snake.Add(new SnakeSegment { x = screenWidth / 2 / gridSize, y = screenHeight / 2 / gridSize });
        }

        SnakeSegment food = new SnakeSegment { x = new Random().Next(0, screenWidth / gridSize), y = new Random().Next(0, screenHeight / gridSize) };

        int dirX = 0;
        int dirY = -1;
        int framesCounter = 0;
        bool gameOver = false;

        SetTargetFPS(60);

        while (!WindowShouldClose())
        {
            // Input handling
            if (IsKeyDown(KeyboardKey.Right) && dirX != -1)
            {
                dirX = 1;
                dirY = 0;
            }
            if (IsKeyDown(KeyboardKey.Left) && dirX != 1)
            {
                dirX = -1;
                dirY = 0;
            }
            if (IsKeyDown(KeyboardKey.Up) && dirY != 1)
            {
                dirX = 0;
                dirY = -1;
            }
            if (IsKeyDown(KeyboardKey.Down) && dirY != -1)
            {
                dirX = 0;
                dirY = 1;
            }

            // Update game state
            if (!gameOver && ++framesCounter >= 10)
            {
                framesCounter = 0;

                // Move the snake
                for (int i = snake.Count - 1; i > 0; i--)
                {
                    snake[i] = snake[i - 1];
                }
                snake[0] = new SnakeSegment { x = snake[0].x + dirX, y = snake[0].y + dirY };

                // Check for collisions with food
                if (snake[0].x == food.x && snake[0].y == food.y)
                {
                    // Add a new segment to the end of the snake
                    snake.Add(new SnakeSegment { x = snake[snake.Count - 1].x, y = snake[snake.Count - 1].y });
                    food = new SnakeSegment { x = new Random().Next(0, screenWidth / gridSize), y = new Random().Next(0, screenHeight / gridSize) };
                }

                // Check for collisions with self
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].x == snake[i].x && snake[0].y == snake[i].y)
                    {
                        gameOver = true;
                    }
                }

                // Check for collisions with screen edges
                if (snake[0].x < 0 || snake[0].x >= screenWidth / gridSize || snake[0].y < 0 || snake[0].y >= screenHeight / gridSize)
                {
                    gameOver = true;
                }
            }

            // Drawing
            BeginDrawing();
            ClearBackground(Color.LightGray);

            // Draw the snake
            foreach (var segment in snake)
            {
                DrawRectangle(segment.x * gridSize, segment.y * gridSize, gridSize - 1, gridSize - 1, Color.Green);
            }

            // Draw the food
            DrawRectangle(food.x * gridSize, food.y * gridSize, gridSize - 1, gridSize - 1, Color.Red);

            // Draw game over message
            if (gameOver)
            {
                DrawText("GAME OVER", screenWidth / 2 - MeasureText("GAME OVER", 20) / 2, screenHeight / 2 - 10, 20, Color.Black);
            }

            EndDrawing();
        }

        CloseWindow();
    }
}
