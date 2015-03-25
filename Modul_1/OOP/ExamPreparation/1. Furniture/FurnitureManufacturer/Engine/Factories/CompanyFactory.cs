namespace FurnitureManufacturer.Engine.Factories
{
    using System;
    using System.Collections.Generic;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class CompanyFactory : ICompanyFactory
    {
        private static HashSet<string> registeredCompanyNames = new HashSet<string>();

        public ICompany CreateCompany(string name, string registrationNumber)
        {
            if (registeredCompanyNames.Contains(name))
            {
                throw new ArgumentException("Duplicate company names is not allowed!");
            }

            registeredCompanyNames.Add(name);

            Company newCompany = new Company(name, registrationNumber);

            //Console.WriteLine("Company {0} created", newCompany.Name);

            return newCompany;
        }

        //public void AddFurnitureToCompany(string companyName, string furnitureModel)
        //{
        //    Console.WriteLine("Furniture {0} added to company {1}", furnitureModel, companyName);
        //}

        //public void RemoveFurnitureFromCompany(string companyName, string furnitureModel)
        //{
        //    Console.WriteLine("Furniture {0} removed from company {1}", furnitureModel, companyName);
        //}

        //public void FindFurnitureFromCompany(string companyName, string furnitureModel)
        //{ 
        //}
    }
}
