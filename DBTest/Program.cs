using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainerOfflineLibrary.Database;
using TrainerOfflineLibrary.Enums;
using TrainerOfflineLibrary.Models;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new GymContext()))
            {
                bool isWorking = true;

                while (isWorking)
                {
                    Console.Clear();
                    Console.WriteLine("1. Show Exercise List");
                    Console.WriteLine("2. Add Exercise");
                    Console.WriteLine("3. Remove Exercise");
                    Console.WriteLine("4. Update Exercise");
                    Console.WriteLine("5. Clear list of Exercises");
                    Console.WriteLine("6. Exit");

                    Console.WriteLine("What you want to do?");

                    string key;
                    key = Console.ReadLine();
                    switch (key)
                    {
                        case "1":
                            ShowExerciseList(unitOfWork);
                            break;
                        case "2":
                            AddExercise(unitOfWork);
                            break;
                        case "3":
                            RemoveExercise(unitOfWork);
                            break;
                        case "4":
                            UpdateExercise(unitOfWork);
                            break;
                        case "5":
                            ClearListOfExercises(unitOfWork);
                            break;
                        case "6":
                            Exit(isWorking);
                            break;
                        default:
                            Console.WriteLine("\nInvalid value..");
                            break;
                    }

                    Console.WriteLine("\nPress any button to continue...");
                    Console.ReadKey();
                }
            }
        }

        private static void Exit(bool isWorking)
        {
            isWorking = false;
        }

        private static void ClearListOfExercises(UnitOfWork unitOfWork)
        {
            unitOfWork.Exercises.RemoveAll();
            unitOfWork.Save();
        }

        private static void AddExercise(UnitOfWork unitOfWork)
        {
            var exercise = new Exercise();
            Console.WriteLine("Enter the appropriate details.");

            Console.WriteLine("Name: ");
            exercise.Name = Console.ReadLine();

            Console.WriteLine("Bodypart: ");
            exercise.Bodypart = Console.ReadLine();

            Console.WriteLine("Name: ");
            exercise.Name = Console.ReadLine();

            Console.WriteLine("Name: ");
            exercise.Name = Console.ReadLine();
        }

        private static void RemoveExercise(UnitOfWork unitOfWork)
        {

        }

        private static void UpdateExercise(UnitOfWork unitOfWork)
        {

        }

        private static void ShowExerciseList(UnitOfWork unitOfWork)
        {
            var exercises = unitOfWork.Exercises.GetAll();
            foreach (var exercise in exercises)
            {
                Console.WriteLine("ID: {0}, Name: {1} , Bodypart: {2}, Type: {3}, Note: {4}", exercise.ExcerciseID, exercise.Name, exercise.Bodypart, exercise.Exercise_type, exercise.Note);
            }
        }
    }
}
