using System;

namespace FirstApp
{
    public class Program
    {
        
        public static void Main(string[] args)
        {

            UserInteract.Initialize(new UserInteract());           
            GameController.Initialize(new GameController());

            GameController.Instance.StartGame();
        }
    }
}
