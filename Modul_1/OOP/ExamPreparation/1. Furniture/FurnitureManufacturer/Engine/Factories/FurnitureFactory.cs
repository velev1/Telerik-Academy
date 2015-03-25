namespace FurnitureManufacturer.Engine.Factories
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        private static HashSet<string> usedFurnitureModels = new HashSet<string>();

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            IsModelNameUsed(model);
            Table newTable = new Table(model, materialType, price, height, length, width);
            //PrintCreation(newTable.GetType().Name, model);
            return newTable;
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            IsModelNameUsed(model);
            Chair newCahir = new Chair(model, materialType, price, height, numberOfLegs);
            //PrintCreation("Chair", model);
            return newCahir;
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            IsModelNameUsed(model);
            AdjustableChair newAdjustibleCahir = new AdjustableChair(model, materialType, price, height, numberOfLegs);
            //PrintCreation("Chair", model);
            return newAdjustibleCahir;
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            IsModelNameUsed(model);
            ConvertibleChair newConvertibleChair = new ConvertibleChair(model, materialType, price, height, numberOfLegs);
            //PrintCreation("Chair", model);
            return newConvertibleChair;
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }

        //public void SetChairHeight(string model, decimal height)
        //{
        //    Console.WriteLine("Chair {0} adjusted to height {1}", model, height);
        //}

        //public void ConvertChair(string model)
        //{
        //    Console.WriteLine("Chair {0} converted", model);
        //}

        private static void  IsModelNameUsed(string model)
        {
            if (InvalidMaterialName.Contains(model))
            {
                throw new ArgumentException("Duplicate company names is not allowed!");
            }

            usedFurnitureModels.Add(model);
        }

        private static void PrintCreation(string type, string model)
        {
            Console.WriteLine("{0} {1} created", type, model);
        }
    }
}
