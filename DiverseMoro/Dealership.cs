using System.Text.RegularExpressions;

namespace DiverseMoro
{
    internal class Dealership
    {
        private readonly string _name;
        private readonly string _address;
        private readonly List<Car> _cars;

        public Dealership(string name, string address)
        {
            _name = name;
            _address = address;
            _cars = new List<Car>();


            var text = "Hei på deg";
            int index = text.IndexOf('k');
            int? number = null;
        }

        public List<Car> GetLongDrivingCars(int minKilometers)
        {
            var longDrivingCars = new List<Car>();
            foreach (var car in _cars)
            {
                if (car.Kilometers > minKilometers) longDrivingCars.Add(car);
            }
            return longDrivingCars;
        }

        public List<Car> GetOlderCars(int age)
        {
            var olderCars = new List<Car>();
            foreach (var car in _cars)
            {
                if (car.Age > age) olderCars.Add(car);
            }

            return olderCars;
        }

        public void RemoveCar(Car car)
        {
            RemoveCar(car.RegNo);
        }

        public void RemoveCar(string regNo)
        {
            var theCar = FindCarByRegNo(regNo);
            if (theCar == null) return;
            _cars.Remove(theCar);
        }

        private Car? FindCarByRegNo(string regNo)
        {
            foreach (var car in _cars)
            {
                if (car.RegNo == regNo) return car;
            }
            return null;
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void AddCar(
            string name, string regNo,
            int modelYear, int kilometers)
        {
            var car = new Car(
                name, regNo, modelYear, kilometers);
            AddCar(car);
        }
    }
}
