using System;
using System.IO;
using Newtonsoft.Json;

namespace WeatherApp_Api
{
    class Program
    {
        static void Main(string[] args)
        {

            //Posun v ČZ
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Posun v časové zóně");
            string TZ;
            TZ = Console.ReadLine();
            int TZR = int.Parse(TZ);

            DateTime date = new System.DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(1557458354);

            TimeSpan time = new TimeSpan(0, TZR, 0, 0);

            DateTime final = date.Add(time);

            Console.WriteLine(String.Format("{0:d/M/yyyy HH:mm:ss}", final));
            Console.ReadKey();


            //API podle zadání
            string mesto = Console.ReadLine();
            string json;
            new Item = Items;


            json = new WebClient().DownloadString("http://api.openweathermap.org/data/2.5/forecast?q={mesto}&APPID=fedcf81469d34db86a7e24886bb9ae83");
            Items = JsonConvert.DeserialObject<Item>(json);

        }
    }

    class Item
    {
        public string coord { get; set; }
        public string weather { get; set; }
        public string basee { get; set; }
        public string main { get; set; }
        public string wind { get; set; }
        public string rain { get; set; }
        public string clouds { get; set; }
        public string dt { get; set; }
        public string sys { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cod { get; set; }

    }
}
