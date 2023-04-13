using System;


namespace FirstLesson
{
    public class Program
    {
        private static GameController gameController;

        public static UserInteract Interact;
        public static void Main(string[] args)
        {
            Interact= new UserInteract();
            gameController = new GameController();
            gameController.StartGame();
        }
    }
}