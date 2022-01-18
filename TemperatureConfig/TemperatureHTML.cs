using System;
using System.Globalization;
using System.IO;
using System.Net;

namespace PocasiWinForm.TemperatureConfig
{
    internal abstract class TemperatureHTML : Temperature
    {
        //Props
        abstract protected string Url { get; }
        abstract protected string Name { get; }
        abstract protected char[] Search { get; }
        protected StreamReader Page { get; private set; } = null;

        //Fields
        private readonly WebClient _webClient = new WebClient();
        private Stream _data = null;

        //Methods
        virtual protected string Find()
        {
            string ret = Page.ReadToEnd();
            int[] index = new int[]
            {
                ret.IndexOf(Search[0]),
                ret.IndexOf(Search[1], ret.IndexOf(Search[0]) + 1)
            };
            return ret
                .Substring(index[0] + 1, index[1] - index[0] - 1)
                .Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
        }

        public override void Update()
        {
            try
            {
                _data = _webClient.OpenRead(Url);
                Page = new StreamReader(_data);

                Celsius = double.Parse(Find());
            }
            catch (Exception)
            {
                Celsius = double.NaN;
            }
            finally
            {
                _data?.Dispose();
                Page?.Dispose();
            }
        }

        //Object
        public override string ToString() => Name;
    }
}
