﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNoGame
{
    partial class Game
    {
        public void InitGame(int levelNumber)
        {
            if (levelNumber == 1)
            {
                Aim = new Rectangle(new Vector(1250,50), new Size(100,100));
                Aim.Aim = true;
                Player = new Player(new Vector(100, 660), new Size(64, 64));
                Monster = new Monster(new Vector(10, 10), new Size(64, 64));
                var mapObjects = new List<Rectangle>()
                    {
                        new Rectangle(new Vector(0, 750), new Size(800, 300)),
                        new Rectangle(new Vector(1000, 750), new Size(800, 300)),
                        new Rectangle(new Vector(100, 100), new Size(200, 20)),
                        new Rectangle(new Vector(400, 100), new Size(600, 20)),
                        new Rectangle(new Vector(200, 250), new Size(200, 20)),
                        new Rectangle(new Vector(800, 300), new Size(100, 20)),
                        new Rectangle(new Vector(1000, 200), new Size(100, 20)),
                        new Rectangle(new Vector(0,0), new Size(2, 880)), // левый край
                        new Rectangle(new Vector(0,0), new Size(1440, 2)), // верхний край
                        new Rectangle(new Vector(1440 ,0), new Size(2, 880)), // правый край
                        new Rectangle(new Vector(1200, 600), new Size(1140, 20)),
                        new Rectangle(new Vector(100, 600), new Size(1000, 20)),
                        new Rectangle(new Vector(1300, 400), new Size(300, 20)),
                        new Rectangle(new Vector(0, 450), new Size(400, 20)),
                        new Rectangle(new Vector(500, 450), new Size(700, 20)),
                        new Rectangle(new Vector(1200, 150), new Size(300, 20)),
                        new Rectangle(new Vector(0, 100), new Size(100, 350)),

                        new Food (new Vector(1200, 95), new Size(64,64)),//17
                        new Food (new Vector(300, 195), new Size(64,64)),
                        new Food (new Vector(600, 45), new Size(64,64)),//19
                        new Food (new Vector(800, 395), new Size(64,64)),//20
                        new Food (new Vector(100, 45), new Size(64,64)),//21
                        new Food (new Vector(800, 45), new Size(64,64)),
                        new Food (new Vector(1200,545), new Size(64,64)),
                        new Food (new Vector(1200,695), new Size(64,64)),//24


                        Aim,
                        Player,
                        Monster,
                    };
                Map = new Map(mapObjects);

            }
            else if (levelNumber == 2)
            {
                Aim = new Rectangle(new Vector(1250, 50), new Size(100, 100));
                Aim.Aim = true;
                Player = new Player(new Vector(250, 480), new Size(64, 64));
                Monster = new Monster(new Vector(800, 530), new Size(64, 64));
                var mapObjects = new List<Rectangle>()
                    {
                        new Rectangle(new Vector(0, 750), new Size(1000, 300)),
                        new Rectangle(new Vector(1000, 750), new Size(100, 20)),
                        new Rectangle(new Vector(960, 600), new Size(40, 180)),
                        new Rectangle(new Vector(800, 600), new Size(200, 20)),
                        new Rectangle(new Vector(1200, 150), new Size(300, 20)),
                        new Rectangle(new Vector(800, 300), new Size(300, 20)),
                        new Rectangle(new Vector(100, 0), new Size(300, 20)),
                        new Rectangle(new Vector(100, 400), new Size(300, 20)),
                        new Rectangle(new Vector(450, 150), new Size(300, 20)),
                        new Rectangle(new Vector(0, 0), new Size(1, 1024)), // левый край 
                        new Rectangle(new Vector(0,0), new Size(1440, -10)), // верхний край 
                        new Rectangle(new Vector(1440 ,0), new Size(1, 1024)), // правый край 

                        new Food (new Vector(150, 350), new Size(64,64)),//13
                        new Food (new Vector(450, 100), new Size(64,64)),
                        new Food (new Vector(1000, 685), new Size(64,64)),
                        new Food (new Vector(900, 685), new Size(64,64)),//16

                        Aim,
                        Player,
                        Monster,
                    };
                Map = new Map(mapObjects);
            }
            else if (levelNumber == 3)
            {
                Aim = new Rectangle(new Vector(1250, 50), new Size(100, 100));
                Aim.Aim = true;
                Player = new Player(new Vector(250, 480), new Size(64, 64));
                Monster = new Monster(new Vector(100, 480), new Size(64, 64));
                var mapObjects = new List<Rectangle>()
                    {
                        new Rectangle(new Vector(0, 700), new Size(2000, 300)),
                        new Rectangle(new Vector(900, 300), new Size(100, 10)),
                        new Rectangle(new Vector(700, 400), new Size(100, 10)),
                        new Rectangle(new Vector(500, 500), new Size(100, 10)),
                        new Rectangle(new Vector(1100, 400), new Size(250, 340)),
                        new Rectangle(new Vector(1200, 100), new Size(300, 20)),
                        new Rectangle(new Vector(0,0), new Size(1, 1024)), // левый край 6
                        new Rectangle(new Vector(0,0), new Size(1440, -10)), // верхний край 7
                        new Rectangle(new Vector(1440 ,0), new Size(1, 1024)), // правый край 8
                        new Rectangle(new Vector(0, 300), new Size(100, 10)),//9
                        new Rectangle(new Vector(150, 400), new Size(100, 10)),
                        new Rectangle(new Vector(350, 350), new Size(100, 10)),
                        new Rectangle(new Vector(450, 200), new Size(100, 10)),//12
                        new Rectangle(new Vector(150, 200), new Size(100, 10)),//13
                        new Rectangle(new Vector(170, 700), new Size(100, 10)),
                        new Rectangle(new Vector(800, 400), new Size(100, 10)),//15
                        new Rectangle(new Vector(700, 200), new Size(100, 10)),//16
                        new Rectangle(new Vector(800, 400), new Size(100, 10)),//17

                        new Food (new Vector(25, 250), new Size(64,64)),//18 ham
                        new Food (new Vector(380, 295), new Size(64,64)),
                        new Food (new Vector(1200, 345), new Size(64,64)),
                        new Food (new Vector(1000, 660), new Size(64,64)),//21
                        new Food (new Vector(175,145), new Size(64,64)),//22 mush
                        new Food (new Vector(175,345), new Size(64,64)),
                        new Food (new Vector(800,345), new Size(64,64)),
                        new Food (new Vector(700,145), new Size(64,64)),//25

                        Aim,
                        Player,
                        Monster
                };
                Map = new Map(mapObjects);
            }

            else if (levelNumber == 4)
            {
                Aim = new Rectangle(new Vector(1250, 50), new Size(100, 100));
                Aim.Aim = true;
                Player = new Player(new Vector(100, 650), new Size(64, 64));
                Monster = new Monster(new Vector(100, 100), new Size(64, 64));
                var mapObjects = new List<Rectangle>()
                    {
                        new Rectangle(new Vector(0, 0), new Size(20, 1024)), // левый край
                        new Rectangle(new Vector(0, 0), new Size(1440, 20)), // верхний край
                        new Rectangle(new Vector(1440 ,0), new Size(20, 1024)), // правый край
                        new Rectangle(new Vector(0, 750), new Size(300, 300)),
                        new Rectangle(new Vector(450, 750), new Size(300, 300)),
                        new Rectangle(new Vector(1000, 750), new Size(800, 300)),
                        new Rectangle(new Vector(450, 100), new Size(400, 20)),
                        new Rectangle(new Vector(0, 300), new Size(400, 20)),
                        new Rectangle(new Vector(800, 300), new Size(400, 20)),
                        new Rectangle(new Vector(1300, 150), new Size(400, 20)),

                        new Food (new Vector(25, 225), new Size(64,64)),//18 ham
                        new Food (new Vector(350, 225), new Size(64,64)),
                        new Food (new Vector(1300, 80), new Size(64,64)),
                        new Food (new Vector(1000, 660), new Size(64,64)),//21
                        new Food (new Vector(800, 50), new Size(64,64)),


                        Aim,
                        Player,
                        Monster
                    };
                Map = new Map(mapObjects);
            }
            else
                throw new Exception();
        }
    }
}
