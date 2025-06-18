using Garage.Garage;
using Garage.Models;

namespace GarageUnitTest
{
    public class GarageUnitTests
    {
        [Fact]
        public void Add_Vehicle_ToTheGarage()
        {
            //Arrange
            GarageHandler handler = new GarageHandler();
            int capacity = 5; //add manuaally capacity like writing in the console
            handler.CreateGarage(capacity);
            var car = new Car("Citroen", "OUA080", "white"); //simulate the creation of  a car

            //Act
            var test = handler.AddVehicle(car);
            //Assert
            Assert.True(test);
        }
        [Fact]
        public void Remove_Vehicle_FromTheGarage()
        {
            //Arrange
            GarageHandler handler = new GarageHandler();
            int capacity = 5; //add manuaally capacity like writing in the console
            handler.CreateGarage(capacity);
            var car = new Car("Citroen", "OUA080", "white"); //simulate the creation of  a car
            var testAdd = handler.AddVehicle(car);
            var registrationNumber = "OUA080";//simulate the creation of  a car

            //Act
            var testRemove = handler.RemoveVehicle(registrationNumber);
            //Assert
            Assert.True(testRemove);
        }

    }
}
