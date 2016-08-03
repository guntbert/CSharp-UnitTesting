//---------------------------------------------------------------
// <copyright file="CarsControllerTests.cs" company="Unknown">
//  All rights reserved.
// </copyright>
// <author>Unknown</author>
//---------------------------------------------------------------
namespace Cars.Tests
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using Models;
    using MSTestExtensions;

    /// <summary>
    /// Provides test methods for testing the <see cref="CarsController"/> class.
    /// </summary>
    /// <seealso cref="MSTestExtensions.BaseTest" />
    [TestClass]
    public class CarsControllerTests : BaseTest
    {
        /// <summary>
        /// Contains current instance's car repository.
        /// </summary>
        private readonly ICarsRepository repository;

        /// <summary>
        /// Contains the current instance of the <see cref="CarsController"/> class.
        /// </summary>
        private CarsController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarsControllerTests" /> class.
        /// </summary>
        public CarsControllerTests() : this(new MockCarsRepository())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarsControllerTests"/> class. Used for default constructor implementation.
        /// </summary>
        /// <param name="mockedRepository">The mocked repository.</param>
        public CarsControllerTests(IMockCarsRepository mockedRepository)
        {
            this.repository = mockedRepository.CarsInformation;
        }

        /// <summary>
        /// Creates the current instance of the controller.
        /// </summary>
        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.repository);
        }

        /// <summary>
        /// Tests <see cref="CarsController.Index"/> method. 
        /// </summary>
        [TestMethod]
        public void Index_ReturnListOfAllCars_InvokeControllerIndexMethod()
        {
            var result = (IList<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, result.Count);
        }

        /// <summary>
        /// Tests <see cref="CarsController.Add(Car)"/> method when <see cref="Car"/> is null. 
        /// </summary>
        [TestMethod]
        public void Add_ReturnArgumentNullException_CarIsNull()
        {
            Assert.Throws<ArgumentException>(() => this.controller.Add(null));
        }

        /// <summary>
        /// Tests <see cref="CarsController.Add(Car)"/> method when <see cref="Car.Make"/> is null.
        /// </summary>
        [TestMethod]
        public void Add_ReturnArgumentNullException_CarMakeIsNull()
        {
            Car car = new Car
            {
                Id = 6,
                Make = null,
                Model = "Polo",
                Year = 2005
            };

            Assert.Throws<ArgumentNullException>(() => this.controller.Add(car));
        }

        /// <summary>
        /// Tests <see cref="CarsController.Add(Car)"/> method when <see cref="Car.Model"/> is null.
        /// </summary>
        [TestMethod]
        public void Add_ReturnArgumentNullException_CarModelIsNull()
        {
            Car car = new Car
            {
                Id = 6,
                Make = "VW",
                Model = null,
                Year = 2005
            };

            Assert.Throws<ArgumentNullException>(() => this.controller.Add(car));
        }

        /// <summary>
        /// Tests <see cref="CarsController.Add(Car)"/> method.
        /// </summary>
        [TestMethod]
        public void Add_ReturnModel_InvokeAddCar()
        {
            Car car = new Car
            {
                Id = 14,
                Make = "VW",
                Model = "Polo",
                Year = 2005
            };

            var result = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual("Opel", result.Make);
        }

        /// <summary>
        /// Tests <see cref="CarsController.Details(int)"/> method.
        /// </summary>
        [TestMethod]
        public void Details_ReturnModel_InvokeDetails()
        {
            Car result = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.AreEqual("Astra", result.Model);
        }

        /// <summary>
        /// Tests <see cref="CarsController.Details(int)"/> method when <see cref="Car"/> is null. 
        /// </summary>
        [TestMethod]
        public void Details_ReturnArgumentNullException_InvokedWithNullValue()
        {
            Assert.Throws<ArgumentNullException>(() => this.controller.Details(6));
        }

        /// <summary>
        /// Tests <see cref="CarsController.Search(string)"/> method.
        /// </summary>
        [TestMethod]
        public void Search_ReturnModel_InvokeSearch()
        {
            var result = (IList<Car>)this.GetModel(() => this.controller.Search("Opel"));

            Assert.AreEqual(2, result.Count);
        }

        /// <summary>
        /// Tests <see cref="CarsController.Sort(string)"/> method when <see cref="string"/> value is invalid.
        /// </summary>
        [TestMethod]
        public void Sort_ReturnArgumentNullException_ParameterIsNotMakeOrYear()
        {
            Assert.Throws<ArgumentException>(() => this.controller.Sort("wrong"));
        }

        /// <summary>
        /// Tests <see cref="CarsController.Sort(string)"/> method when <see cref="string"/> value is "Make".
        /// </summary>
        [TestMethod]
        public void Sort_ReturnModel_ParameterIsMake()
        {
            var result = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual(1999, result[0].Year);
        }

        /// <summary>
        /// Tests <see cref="CarsController.Sort(string)"/> method when <see cref="string"/> value is "Year".
        /// </summary>
        [TestMethod]
        public void Sort_ReturnModel_ParameterIsYear()
        {
            var result = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));
            Assert.AreEqual(2, result.Count);
        }

        /// <summary>
        /// Implements logic used over other methods via <see cref="Func{TResult}"/> delegate to output result of different type. 
        /// </summary>
        /// <param name="func">The function.</param>
        /// <returns><see cref="object"/></returns>
        private object GetModel(Func<IView> func)
        {
            var view = func();
            return view.Model;
        }
    }
}
