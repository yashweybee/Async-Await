using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace Async_Await
{
    class Program
    {
        static readonly string textFile = "C:/Users/DELL/source/repos/Async-Await/Async-Await/my.txt";
        static void Main(string[] args)
        {
            //Console.WriteLine(textFile);
            //Console.WriteLine(File.Exists("C:/Users/DELL/source/repos/Async-Await/Async-Await/my.txt"));
            //myfileInfo();
            //myfileInfoURL(url);
            //myfileInfo();


            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();
            //StartSchoolAssembly();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //TeachClass12();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //TeachClass11();
            //Console.WriteLine(watch.ElapsedMilliseconds);
            //watch.Stop();

            var watch2 = new System.Diagnostics.Stopwatch();
            watch2.Start();

            var task1 = StartAssembly();
            //await task1;
            var task2 = Class11();
            var task3 = Class12();

            Task.WaitAll(task1, task2, task3);
            Console.WriteLine(watch2.ElapsedMilliseconds);
            watch2.Stop();
            Console.ReadLine();
        }

        public static void StartSchoolAssembly()
        {
            Thread.Sleep(8000);
            Console.WriteLine("School Started");
        }


        public static void TeachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Taught class 12");

        }

        public static void TeachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Taught class 11");

        }

        static async Task StartAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("assembly started");
            });
        }
        static async Task Class11()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);

                Console.WriteLine("teacing class 11");
            });
        }
        static async Task Class12()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);

                Console.WriteLine("Teaching class 12");
            });
        }




        static async Task myfileInfo()
        {


            Console.WriteLine("Reading text file");
            await Task.Run(() =>
            {

                string myFileText = File.ReadAllText(textFile);

                Console.WriteLine("FIle text: " + myFileText);
            });

        }

        //static async Task myfileInfoURL(string URL)
        //{
        //    await Task.Run(() =>
        //    {
        //        Console.WriteLine("Reading text file URL: ");
        //        using (var httpClient = new HttpClient())
        //        {
        //            string urlText = httpClient.GetAsync(URL);
        //        }

        //        Console.WriteLine("URL text : " +  URL);

        //    })
        //}
    }
}
