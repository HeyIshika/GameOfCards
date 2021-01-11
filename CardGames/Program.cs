using System;

using System.Collections.Generic;

 

namespace CardGames

{

    class Program

    {

        static void Main(string[] args)

        {

            Deck playingCard = new Deck();

            UserActivity(playingCard);

            bool option;

            do

            {

                UserActivity(playingCard);

                Console.WriteLine("Do you want to continue? y/n");

                option = Console.ReadLine().ToLower()  == "y";

 

            } while (option);

 

        }

        private static void UserActivity(Deck playingCard)

        {

            Console.WriteLine(@" Select action from below options:

               1.Play

                2.Shuffle

                3.Restart");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)

            {

                case 1:

                    Console.WriteLine(playingCard.Play().NameValue());

                    break;

                case 2:

                    playingCard.Shuffle();

                    Console.WriteLine("Shuffled!");

                    break;

                case 3:

                    playingCard.Restart();

                    UserActivity(playingCard);

                    break;

                default:

                    Console.WriteLine("Not a valid option");

                    break;


            }

        }

    }

}