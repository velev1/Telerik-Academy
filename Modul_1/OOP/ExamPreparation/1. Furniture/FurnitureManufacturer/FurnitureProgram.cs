namespace FurnitureManufacturer
{
    using System;

    using FurnitureManufacturer.Models;
    using FurnitureManufacturer.Interfaces;
    using Engine;

    public class FurnitureProgram
    {
        public static void Main()
        {
            FurnitureManufacturerEngine.Instance.Start();

            //Chair chair = new Chair("pesho", "wooden", 20.02m, 0.5m, 4);
            //Company newCompany = new Company("peshoTM", "1000225252");
            //newCompany.Add(chair);

            //Console.WriteLine(newCompany.Catalog());
        }
    }
}
