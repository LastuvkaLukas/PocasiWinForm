
namespace PocasiWinForm.TemperatureConfig
{
    internal abstract class Temperature
    {
        //Props
        public Degree Unit { get; set; } = Degree.Celsius;
        public double Celsius { get; protected set; } = double.NaN;
        public double Fahrenheit => Celsius * 9 / 5 + 32;
        public string CelsiusString => $"{Celsius} °C";
        public string FahrenheitString => $"{Fahrenheit} °F";

        //Methods
        public double GetDegree() => (Unit == Degree.Celsius) ? Celsius : Fahrenheit;

        public string GetDegreeString() => (Unit == Degree.Celsius) ? CelsiusString : FahrenheitString;

        public abstract void Update();
    }
    
    internal enum Degree
    {
        Celsius,
        Fahrenheit
    }
}
