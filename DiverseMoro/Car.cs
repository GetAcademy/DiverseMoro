namespace DiverseMoro
{
    internal class Car
    {
        public string Name { get; }
        public string RegNo { get; }
        public int ModelYear { get; }
        public int Kilometers { get; private set; }

        public Car(string name, string regNo, int modelYear, int kilometers)
        {
            Name = name;
            RegNo = regNo;
            ModelYear = modelYear;
            Kilometers = kilometers;
        }

        public void AddKilometers(int kilometers)
        {
            if (kilometers <= 0) 
                throw new ArgumentOutOfRangeException();
            Kilometers += kilometers;
        }
    }
}
