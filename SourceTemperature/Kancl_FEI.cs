using PocasiWinForm.TemperatureConfig;

namespace PocasiWinForm.SourceTemperature
{
    internal class Kancl_FEI : TemperatureHTML
    {
        //Constants
        protected override string Url       => "http://teplota.eparo.cz/teplota_uni.php";
        protected override string Name      => "Moje kancelář";
        protected override char[] Search    => new char[]{ '\'', '\'' };
    }
}
