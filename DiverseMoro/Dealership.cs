namespace DiverseMoro
{
    internal class Dealership
    {
        private string _name;
        private string _address;
        private List<Car> _cars;

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
