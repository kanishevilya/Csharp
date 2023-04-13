using CommonTools.ConsoleShortCuts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Kata {
    public enum ShipType{
        one, two, three,
    }
    public enum Dir
    {
        left,right, up, down
    }
    public class Pole
    {
        public static int width, height;
        public bool[][] pole;
        public bool[][] isRevealed;
        static Pole()
        {
            width = 10; height = 10;
        }
        public Pole()
        {
            pole = new bool[height][];
            isRevealed = new bool[height][];
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = new bool[width];
                isRevealed[i] = new bool[width];
            }
        }
        public bool IsCanDrow(BattleShip ship)
        {
            if(ship.position.X <0 || ship.position.X>=pole.Length || ship.position.Y < 0 || ship.position.Y>= pole.Length) return false;
            switch (ship.dir)
            {
                case Dir.left:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.X-i < 0 || ship.position.X-i >= pole.Length) return false;
                        if (pole[ship.position.Y][ship.position.X-i]) return false;
                    }
                    break;
                case Dir.right:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.X+i < 0 || ship.position.X+i >= pole.Length) return false;
                        if (pole[ship.position.Y][ship.position.X + i]) return false;
                    }
                    break;
                case Dir.up:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.Y < 0 || ship.position.Y-i >= pole.Length) return false;
                        if (pole[ship.position.Y-i][ship.position.X]) return false;
                    }
                    break;
                case Dir.down:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.Y+i < 0 || ship.position.Y + i >= pole.Length) return false;
                        if (pole[ship.position.Y+i][ship.position.X]) return false;
                    }
                    break;
            }
            return true;
        }
        public void DrowShip(BattleShip ship)
        {
            switch (ship.dir)
            {
                case Dir.left:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.X-i < 0 || ship.position.X-i >= pole.Length) continue;
                        pole[ship.position.Y][ship.position.X-i] = true;
                    }
                    break;
                case Dir.right:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.X+i < 0 || ship.position.X+i >= pole.Length) continue;
                        pole[ship.position.Y][ship.position.X + i] = true;
                    }
                    break;
                case Dir.up:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.Y < 0 || ship.position.Y-i >= pole.Length) continue;
                        pole[ship.position.Y-i][ship.position.X] = true;
                    }
                    break;
                case Dir.down:
                    for (int i = 0; i < (int)ship.shipType+1; i++)
                    {
                        if (ship.position.Y+i < 0 || ship.position.Y + i >= pole.Length) continue;
                        pole[ship.position.Y+i][ship.position.X] = true;
                    }
                    break;
            }
        }
        public void Display()
        {
            Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole[i].Length; j++)
                {
                    if (isRevealed[i][j] && pole[i][j]) Write('X');
                    else if (isRevealed[i][j]) Write('*');
                    else Write('#');
                }
                WriteLine();
            }
            WriteLine();
        }
        public void Shoot(Point point)
        {
            if (point.X <0 || point.X>=pole.Length || point.Y < 0 || point.Y>= pole.Length) return;
            isRevealed[point.Y][point.X] = true;
        }
        public bool isGameOver()
        {
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                for (int j = 0; j < pole[i].Length; j++)
                {
                    if (pole[i][j]) cnt1++;
                    if (isRevealed[i][j] && pole[i][j]) cnt2++;
                }
            }
            if (cnt1 == cnt2) return true;
            return false;
        }
    }

    public class BattleShip
    {
        public ShipType shipType;
        public Point position;
        public Dir dir;
        public BattleShip()
        {
            RandInit();
        }

        public void RandInit()
        {
            Random random = new Random();
            shipType = (ShipType)random.Next(Enum.GetNames(typeof(ShipType)).Length);
            position = new Point(random.Next(Pole.width), random.Next(Pole.height));
            dir = (Dir)random.Next(Enum.GetNames(typeof(ShipType)).Length);
        }
    }

    public class BattleSeaGame
    {
        private List<BattleShip> ships;
        private Pole pole;

        public BattleSeaGame()
        {
            Init();
        }
        private void Init()
        {
            pole = new Pole();
            ships = new List<BattleShip>();
            for (int i = 0; i < 6; i++)
            {
                BattleShip temp = new BattleShip();
                while (!pole.IsCanDrow(temp))
                {
                    temp = new BattleShip();
                }
                ships.Add(temp);
                pole.DrowShip(temp);
            }
        }
        private Point AskUserPoint()
        {
            int x = 0, y = 0;
            C.Out("type in x ");
            C.In(ref x);
            C.Out("type in y ");
            C.In(ref y);
            return new Point(x, y);
        }

        public void Start()
        {
            Clear();
            while (!pole.isGameOver()) {
                pole.Display();
                pole.Shoot(AskUserPoint());
            }
            Clear();
            WriteLine("you win!");
            Read();
        }
    }
}
