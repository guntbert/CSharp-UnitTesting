﻿//---------------------------------------------------------------
// <copyright file="MockCarsRepository.cs" company="Unknown">
//  All rights reserved.
// </copyright>
// <author>Unknown</author>
//---------------------------------------------------------------
namespace Cars.Tests.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Controllers;
    using Models;
    using Moq;

    /// <summary>
    /// Provides data for unit testing the <see cref="CarsController"/> class.
    /// </summary>
    /// <seealso cref="Cars.Tests.Mocks.IMockCarsRepository" />
    internal class MockCarsRepository : IMockCarsRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MockCarsRepository"/> class.
        /// Constructor uses <see cref="CreateSetOfCars"/> method to generate the needed data 
        /// and <see cref="MoqArrange"/> to set the required mocks.
        /// </summary>
        public MockCarsRepository()
        {
            this.CreateSetOfCars();
            this.MoqArrange();
        }

        /// <summary>
        /// Gets the cars information. Used for mocks implementation.
        /// </summary>
        public ICarsRepository CarsInformation { get; private set; }

        /// <summary>
        /// Gets the cars data generated by the <see cref="CreateSetOfCars"/> method. 
        /// </summary>
        protected IList<Car> SetOfCars { get; private set; }

        /// <summary>
        /// Creates <see cref="IList{T}"/> instance that contains the cars data.
        /// </summary>
        private void CreateSetOfCars()
        {
            this.SetOfCars = new List<Car>
            {
                new Car { Id = 1, Make = "Audi", Model = "A4", Year = 2005 },
                new Car { Id = 2, Make = "Audi", Model = "A3", Year = 1999 },
                new Car { Id = 3, Make = "Lexus", Model = "LS", Year = 2013 },
                new Car { Id = 4, Make = "Mercedes", Model = "CLS 63 AMG", Year = 2013 },
                new Car { Id = 5, Make = "Opel", Model = "Astra", Year = 2015 }
            };
        }

        /// <summary>
        /// Creates the required mocks during testing process.
        /// </summary>
        private void MoqArrange()
        {
            var mockedRepository = new Mock<ICarsRepository>();
            mockedRepository.Setup(x => x.Add(It.IsAny<Car>())).Verifiable();
            mockedRepository.Setup(x => x.All()).Returns(this.SetOfCars.Where(z => z.Year > 2000).ToList());
            mockedRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(this.SetOfCars.Last());
            mockedRepository.Setup(x => x.GetById(It.IsInRange(6, 10, Range.Inclusive))).Verifiable();
            mockedRepository.Setup(x => x.Remove(null)).Verifiable();
            mockedRepository.Setup(x => x.Remove(It.IsAny<Car>())).Throws<ArgumentException>();
            mockedRepository.Setup(x => x.Search(It.IsAny<string>())).Returns(this.SetOfCars.Where(z => z.Make == "Audi").ToList());
            mockedRepository.Setup(x => x.SortedByMake()).Returns(this.SetOfCars.OrderBy(z => z.Make).ThenBy(z => z.Year).ToList());
            mockedRepository.Setup(x => x.SortedByYear()).Returns(this.SetOfCars.Where(z => z.Year == 2013).ToList());
            mockedRepository.Setup(x => x.TotalCars).Returns(5);
            this.CarsInformation = mockedRepository.Object;
        }
    }
}