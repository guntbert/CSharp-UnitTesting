//---------------------------------------------------------------
// <copyright file="IMockCarsRepository.cs" company="Unknown">
//  All rights reserved.
// </copyright>
// <author>Unknown</author>
//---------------------------------------------------------------
namespace Cars.Tests.Mocks
{
    using Cars.Contracts;

    /// Using ICarsRepository interface to implement the cars database in the Mock setup.
    /// <summary>
    /// Defines property to implement <see cref="ICarsRepository"/> interface inside car repository.
    /// </summary>
    public interface IMockCarsRepository
    {
        /// <summary>
        /// Gets the cars information.
        /// </summary>
        ICarsRepository CarsInformation { get; }
    }
}
