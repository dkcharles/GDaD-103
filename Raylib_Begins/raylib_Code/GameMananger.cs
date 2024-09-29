
namespace RayGame;
public sealed class GameManager
{
    private static GameManager? instance;
    
#region consts
        public const string WELCOME_MESSAGE = "Hello, world!";
        public const string WINDOW_TITLE = "Raylib Game";
        public const int SCREENWIDTH = 800;
        public const int SCREENHEIGHT = 600;
#endregion

#region public variables
        public int frameRate = 60; // Frame rate
        public int playerHealth = 100; // Player health
#endregion

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
