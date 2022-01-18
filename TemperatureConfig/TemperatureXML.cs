using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Xml;

namespace PocasiWinForm.TemperatureConfig
{
    internal abstract class TemperatureXML : Temperature
    {
        //Props
        abstract protected string Url { get; }
        abstract protected string Name { get; }
        abstract protected string Tag { get; }
        protected XmlReader Xml = null;

        //Fields
        private readonly WebClient _webClient = new WebClient();
        private Stream _data = null;

        //Methods
        virtual protected string Find()
        {
            string ret = string.Empty;
            while (Xml.Read())
            {
                if (Xml.Name == Tag)
                {
                    ret = Xml
                        .ReadElementContentAsString()
                        .Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
                }
            }
            return ret;
        }

        public override void Update()
        {
            try
            {
                _data = _webClient.OpenRead(Url);
                Xml = XmlReader.Create(_data);

                Celsius = double.Parse(Find());
            }
            catch (Exception)
            {
                Celsius = double.NaN;
            }
            finally
            {
                _data?.Dispose();
                Xml?.Dispose();
            }
        }

        //Object
        public override string ToString() => Name;
    }
}
