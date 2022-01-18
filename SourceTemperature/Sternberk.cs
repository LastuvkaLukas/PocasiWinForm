using PocasiWinForm.TemperatureConfig;

namespace PocasiWinForm.SourceTemperature
{
    internal class Sternberk : TemperatureXML
    {
        //Constants
        protected override string Url   => "http://teplota.eparo.cz/teplota_stbk.php";
        protected override string Name  => "Šternberk";
        protected override string Tag   => "temp";
    }
}
