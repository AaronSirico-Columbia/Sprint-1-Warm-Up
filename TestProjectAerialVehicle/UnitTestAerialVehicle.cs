using AerialVehicleLibrary;

namespace TestProjectAerialVehicle
{
    [TestClass]
    public class UnitTestAerialVehicle
    {
        [TestMethod]
        public void AirplaneConstructor()
        {
            //Arrange
            Airplane airplane;
            //Act
            airplane= new Airplane();
            //Assert
            Assert.IsNotNull(airplane);
            Assert.AreEqual(airplane.MaxAltitude, 41000);
        }

        public void EngineConstructor()
        {
            //Arrange
            Engine engine;
            //Act
            engine= new Engine();
            //Assert
            Assert.IsNotNull(engine);
            Assert.AreEqual(engine.IsStarted, false);
        }

        public void ToyplaneConstructor()
        {
            //Arrange
            ToyPlane toyPlane;
            //Act
            toyPlane = new ToyPlane();
            //Assert
            Assert.IsNotNull(toyPlane);
            Assert.AreEqual(toyPlane.isWoundUp, false);
            Assert.AreEqual(toyPlane.MaxAltitude, 50);
        }
    }
}