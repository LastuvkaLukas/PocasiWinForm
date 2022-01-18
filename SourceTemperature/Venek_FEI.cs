using PocasiWinForm.TemperatureConfig;

namespace PocasiWinForm.SourceTemperature
{
    internal class Venek_FEI : TemperatureHTML
    {
        //Constants
        protected override string Url       => "http://teplota.eparo.cz/teplota_uni_venku.php";
        protected override string Name      => "FEI venku";
        protected override char[] Search    => new char[] { ':', '\n' };
    }
}
