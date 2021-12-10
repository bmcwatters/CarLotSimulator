using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            // DONE!

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //DONE!
            //*************BONUS*************//
            //DONE!
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            CarLot lot = new CarLot();
            


            Car bmw = new Car();
            bmw.Year = 2016;
            bmw.Make = "BMW";
            bmw.Model = "328i";
            bmw.EngineNoise = "Vroom";
            bmw.HonkNoise = "Beep boop";
            bmw.IsDrivable = true;

            bmw.MakeEngineNoise();
            bmw.MakeHonkNoise();

            lot.Cars.Add(bmw);

            Car hyundai = new Car() { Year = 2020, Make = "Hyundai", Model = "Sonata", EngineNoise = "Help", HonkNoise = "Beep beep" };

            hyundai.MakeEngineNoise();
            hyundai.MakeHonkNoise();

            lot.Cars.Add(hyundai);

            Car ford = new Car(2019, "Ford", "F150", "Vroom vroom", "Look out");

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            lot.Cars.Add(ford);

            //*************BONUS X 2*************//Done!

            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }


            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
