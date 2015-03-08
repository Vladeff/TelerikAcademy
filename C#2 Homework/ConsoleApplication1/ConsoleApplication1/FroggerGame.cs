﻿using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

class FroggerGame
{

    struct Car
    {
        public int x;
        public int y;
        public int width;
        public int direction;
        public char bodySymbol;
        public ConsoleColor color;
    }

    struct Frog
    {
        public int x;
        public int y;
        public char bodySymbol;
        public ConsoleColor color;
    }

    static Random randomGenerator = new Random();

    static int gameWidth = 70;
    static int gameHeight = 30;
    static int gameSpeed = 300;

    static Frog mrFrog = new Frog();
    static int mrFrogLives = 6; // because F(frog) is the 6th letter in Engl

    static List<Car> cars = new List<Car>();
    static bool collisionFlag = false;



    static void Main()
    {
        SetGameDimensions();

        //initialize mrFrog 
        initializeMrFrog();

        while (true)
        {

            //Move enemy Cars 
            MoveEnemyCars();

            // clear the console - so we dont see the PAST !
            Console.Clear();

            // create mr.Frog 
            MoveAndDrawMrFrog();

            // create enemies for mr.Frog - cars/obstacles
            //TODO : make so that when we start we have verywhere cars, not to wait them to be created
            //TODO : some cars move from left to right | some from right to left
            //TODO : make that the 1st simbol shows thedirection in which they are moving
            // '==>' or '<====' or '>' or '<' or '<===' hope you get it
            CreateEnemies();


            //display Colision
            //PS: there is a problem >> we detect colision with the cars only if we hit the the first index of the car
            //this means that if we have a 4 elementBody car(====) and hit its last element (the most right) 
            // we will not have a collision !!!! only if we hit its first ->>> the element with index 0 (the most left)
            //this can be solved by List.Contains
            //
            if (collisionFlag)
            {
                //display X /colision/
                PrintAtPosition(mrFrog.x,
                    mrFrog.y,
                    'X',
                    ConsoleColor.Red);
            }

            // slow down the program - so we can see what is happening 
            Thread.Sleep(gameSpeed);

            collisionFlag = false;
        }
    }

    static void initializeMrFrog()
    {
        mrFrog.x = gameWidth / 2;
        mrFrog.y = gameHeight - 1;
        mrFrog.bodySymbol = '@';
        mrFrog.color = ConsoleColor.Green;
    }

    static void MoveAndDrawMrFrog()
    {
        //see if we have pressed a key
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo pressedKey = Console.ReadKey(true);//save the pressed key
            while (Console.KeyAvailable) Console.ReadKey(true);// we remove buffer keys from before
            if (pressedKey.Key == ConsoleKey.LeftArrow)//move Left >>>
            {
                if (mrFrog.x != 0)//so we dont get out of the bounderies of our gameScreen
                    mrFrog.x--;
            }
            if (pressedKey.Key == ConsoleKey.RightArrow)//move Right <<<
            {
                if (mrFrog.x < gameWidth - 1)
                    mrFrog.x++;
            }
            if (pressedKey.Key == ConsoleKey.UpArrow)//move Right ^^^
            {
                if (mrFrog.y != 0)
                    mrFrog.y--;
            }
            if (pressedKey.Key == ConsoleKey.DownArrow)//move Right vvv
            {
                if (mrFrog.y < gameHeight - 1)
                    mrFrog.y++;
            }
        }

        //draw mrFrog on the Screen
        PrintAtPosition(mrFrog.x, mrFrog.y, mrFrog.bodySymbol, mrFrog.color);
    }

    static void CreateEnemies()
    {
        Car newEnemyCar = new Car();
        newEnemyCar.x = 0;

        //Sidewalks are lanes that there are no cars
        //lane 0 is Top Sidewalk | lane gameHeight - 1 is Bot Sidewalk | everything else is the road
        newEnemyCar.y = randomGenerator.Next(1, gameHeight - 2);
        newEnemyCar.direction = randomGenerator.Next(0, 2);
        newEnemyCar.width = randomGenerator.Next(1, 5);
        newEnemyCar.color = ConsoleColor.Yellow;
        newEnemyCar.bodySymbol = '=';
        cars.Add(newEnemyCar);

        foreach (Car currentCar in cars)
        {
            PrintAtPosition(currentCar.x,
                currentCar.y,
                currentCar.bodySymbol,
                currentCar.color,
                currentCar.width);
        }
    }

    static void MoveEnemyCars()
    {
        List<Car> newCars = new List<Car>();
        for (int i = 0; i < cars.Count; i++)
        {
            Car oldCar = cars[i];
            Car currentCar = new Car();
            currentCar.x = oldCar.x + 1; // we move the car from here
            currentCar.y = oldCar.y;



            currentCar.width = oldCar.width;
            currentCar.direction = oldCar.direction;
            currentCar.bodySymbol = oldCar.bodySymbol;
            currentCar.color = oldCar.color;


            //maybe Colision detection has to be solved something like the lines below???
            //if (currentCar.y == mrFrog.y) cars.Contains(mrFrog.x);
            //{ 
            //    collisionFlag = true;
            //}

            //check for Colision 
            if (currentCar.x == mrFrog.x && currentCar.y == mrFrog.y)
            {
                //set that we have been hit 
                collisionFlag = true;
                //remove 1 live from total
                if (mrFrogLives != 0)
                {
                    mrFrogLives--;
                }
                else
                {
                    //GOTO : Activate gameOver !
                }
            }

            if (currentCar.x < gameWidth)
            {
                newCars.Add(currentCar);
            }
        }
        cars = newCars;
        //Rly i have no clue why I have to create a new list
        //then create a oldCar and currentCar and set currentCar variables to oldCar
        //and then add it to the new LIST 
        //and how by doing this I solve the problem  .... 
        //at http://telerikacademy.com/Courses/LectureResources/Video/5433/Just-Cars-%D0%9D%D0%B8%D0%BA%D0%B8-21-%D0%BD%D0%BE%D0%B5%D0%BC%D0%B2%D1%80%D0%B8-2012
        //min 60:41 they explain and do it like just like this
        //I guess here C# acts like a magic wand - pure magic
    }


    static void PrintAtPosition(int x, int y, char symbol, ConsoleColor color, int elementBodyWidth = 1)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        for (int len = 0; len < elementBodyWidth; len++)
        {
            Console.Write(symbol);
        }
    }

    static void SetGameDimensions()
    {
        Console.CursorVisible = false;

        Console.WindowWidth = gameWidth;
        Console.WindowHeight = gameHeight;

        Console.BufferWidth = gameWidth;
        Console.BufferHeight = gameHeight;
    }
}