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
                var temp = new Exercise { Name = "Plaska", Bodypart = Bodypart.CHEST, Exercise_type = Exercise_type.WEIGHT, Note = "Notatka" };

                unitOfWork.Exercises.Add(temp);

                temp = new Exercise { Name = "Przysiad", Bodypart = Bodypart.QUADRICEPS, Exercise_type = Exercise_type.WEIGHT, Note = "Notatka" };

                unitOfWork.Exercises.Add(temp);

                unitOfWork.Complete();

                var exercises = unitOfWork.Exercises.GetAll();

                
                if (exercises.Count() > 0)
                {
                    foreach (var exercise in exercises)
                    {
                        Console.WriteLine("ID: {0}, Name: {1} , Bodypart: {2}, Type: {3}, Note: {4}", exercise.ExcerciseID, exercise.Name, exercise.Bodypart, exercise.Exercise_type, exercise.Note);
                    }
                }
                else
                {
                    Console.WriteLine("List is empty.");
                }

                unitOfWork.Exercises.RemoveAll();
                unitOfWork.Complete();

                Console.WriteLine("\npress any key to exit the process...");

                // basic use of "Console.ReadKey()" method 
                Console.ReadKey();
            }
        }
    }
}
