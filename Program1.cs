/*
🟡 PROJECT 3: Score & Level System

Level: Intermediate
Time: 1 hour

🎯 Goal

Increase score and level up player.

🧠 Game Logic

Score increases

Every 100 points → Level up

Level affects player stats

🧾 Concepts Used

Variables

Methods

Operators

If conditions

🧪 Your Tasks

Create AddScore(int points)

Create LevelUp()

Increase difficulty each level*/

namespace Miniproject1
{
    class ScoreAndLevel
    {
        private  int points;

        private  int level;

        private enum Level
        {
            Easy,
            Intermediate,
            difficulty
        }
        private enum Status
        {
            NotChanged,
            Changed,
            


        }

        public ScoreAndLevel()
        {
            points=0;
            level=1;
            Console.WriteLine("player score is:"+points);
            Console.WriteLine("Level Status:"+Level.Easy);

        }
       
       public void AddScore(int points)
        {
            if (points> 0)
            {   int newPoints=0;
                newPoints=points+newPoints;
                Console.WriteLine("status Of player:"+Status.NotChanged);
                Console.WriteLine("score incremented:"+newPoints);
                LevelUp(points);
                
            }
            else if(points==0){
                Console.WriteLine("Status:"+Status.NotChanged);
            }
            else
            {
                Console.WriteLine("Invalid score Status");
                
            }
          
            
        }
       public void  LevelUp(int points)
        {
            if (points == 100)

            {   level = level+1;
                Console.WriteLine("player Level incremented");
                Console.WriteLine("current Level:"+level);
                points=0;
                LevelStatus();
            }
          
            else if (points<0)
            {
               return;
            }
            else if(points>100)
            {
                int newPoints,newLevel=0;
                newPoints=points-100;
                newLevel =level+1;
                Console.WriteLine("player score set  to:"+newPoints+"/nafter level increase:"+newLevel);
            }
            
            }
            public void LevelStatus()
        {    
            if(level>=50)
            {
            if (level <=10&&level>=1)
            {
                Console.WriteLine("Level Status:"+Status.Changed+"Difficulty:"+Level.Easy);
            }
            else if (level >10 && level < 20)
            {
                Console.WriteLine("Level Status:"+Status.Changed+"DIfficulty:"+Level.Intermediate);
            }
            else
            {
                Console.WriteLine("Difficulty:"+Level.difficulty);
            } 
            }
            else
            {
                return;
            }

        }
        
    }
    class Progam1
    {
        public static void Main()
        {
            ScoreAndLevel scoreAndLevel = new();
            scoreAndLevel.AddScore(150);
            
        }
    }
}

