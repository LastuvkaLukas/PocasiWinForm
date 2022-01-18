using PocasiWinForm.TemperatureConfig;

namespace PocasiWinForm.SourceTemperature
{
    internal class Ucebna_PC102 : TemperatureXML
    {
        //Constants
        protected override string Url   => "http://teplota.eparo.cz/Uni_pc102.php";
        protected override string Name  => "Učebna PC102";
        protected override string Tag   => "temp";
    }
}
