using System;
using System.Collections.Generic;


namespace hungry_ninja
{
    class Program
    {

        public static void Main(string[] args)
        {
            Ninja Kian = new Ninja();
            Buffet buff = new Buffet();

            Kian.eat(buff.Serve());
            Kian.eat(buff.Serve());
            Kian.eat(buff.Serve());
            Kian.eat(buff.Serve());
            Kian.eat(buff.Serve());
            Kian.eat(buff.Serve());


        }
    }

         class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        


            public  Food (String Name, int Calories, bool IsSpicy, bool IsSweet){
            this.Name= Name;
            this.Calories=Calories;
            this.IsSpicy=IsSpicy;
            this.IsSweet=IsSweet;
            }
        }





        class Buffet
        {
            public List<Food> Menu;
             
            //constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("orange", 1000, true, false),
                    new Food("apple", 1000, false, true),
                    new Food("banana", 1000, true, false),
                    new Food("pear", 1000, true, false),
                    new Food("berry", 1000, false, true),
                    new Food("lime", 1000, true, false),
                    new Food("lemons", 1000, false, true)

                };
            }
             
            public Food Serve()
            {
                Random rand = new Random();
                int x = (rand.Next(0,7));
                return Menu[x] ;

            }
        }
         class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;
            
             
            // add a constructor
            public Ninja (){
                this.calorieIntake=0;
                FoodHistory = new List<Food>();
            }
             
            // add a public "getter" property called "IsFull"
            public bool IsFull { get; set; }
             
            // build out the Eat method
            public void eat(Food item)
            {
                this.calorieIntake += item.Calories
                System.Console.WriteLine("EAting");
            }
        }
    }

