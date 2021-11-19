using System;

namespace DotNet_Design_Patterns.Chapter3.AbstractFactory
{
    public abstract class CarFactory
    {
        public abstract PetrolCar CreatePetrolCar();
        public abstract DieselCar CreateDieselCar();
    }
    public class IranKhodro : CarFactory
    {
        public override DieselCar CreateDieselCar() => new Arena();

        public override PetrolCar CreatePetrolCar() => new Peugeot206();
    }
    public class Saipa : CarFactory
    {
        public override DieselCar CreateDieselCar() => new Foton();

        public override PetrolCar CreatePetrolCar() => new Pride();
    }
    public abstract class PetrolCar
    {
        public abstract void AssembleSeats();
    }
    public class Pride : PetrolCar
    {
        public override void AssembleSeats() => Console.WriteLine("Pride seats assembleed");
    }
    public class Peugeot206 : PetrolCar
    {
        public override void AssembleSeats() => Console.WriteLine("Peugeot206 seats assembleed");
    }

    public abstract class DieselCar
    {
        public abstract void AssembleDieselEngine();
    }
    public class Foton : DieselCar
    {
        public override void AssembleDieselEngine() => Console.WriteLine("Foton engine assembleed");
    }
    public class Arena : DieselCar
    {
        public override void AssembleDieselEngine() => Console.WriteLine("Arena engine assembleed");
    }

    public class Client
    {
        private readonly CarFactory factory;

        public Client(CarFactory factory) => this.factory = factory;

        public void CreatePetrolCar()
        {
            var petrol = factory.CreatePetrolCar();
            petrol.AssembleSeats();
        }

        public void CreateDieselCar()
        {
            var diesel = factory.CreateDieselCar();
            diesel.AssembleDieselEngine();
        }
    }
}
