using System;
using System.Diagnostics;
using System.Resources;
using System.Runtime.InteropServices.ComTypes;

namespace sample1.generic
{
    public static class Monitor
    {

        public static void Show()
        {
            var i = 11932;

            long commonSecond = 0;
            long objectSecond = 0;
            long genericSecond = 0;

            {
                Stopwatch stopwatch = new();
                stopwatch.Start();
                for (var j = 0; j < 1000000000; j++)
                {
                    ShowInt(i);
                }

                stopwatch.Stop();
                commonSecond = stopwatch.ElapsedMilliseconds;
            }

            {
                Stopwatch stopwatch = new();
                stopwatch.Start();
                for (var j = 0; j < 1000000000; j++)
                {
                    ShowObject(i);
                }

                stopwatch.Stop();
                objectSecond = stopwatch.ElapsedMilliseconds;
            }

            {
                Stopwatch stopwatch = new();
                stopwatch.Start();
                for (var j = 0; j < 1000000000; j++)
                {
                    Show(i);
                }

                stopwatch.Stop();
                genericSecond = stopwatch.ElapsedMilliseconds;
            }

            Console.WriteLine(
                $"commonMethod:{commonSecond}\nobjectMethod:{objectSecond}\ngenericMethod:{genericSecond}");
        }

        #region Private Method

        private static void ShowInt(int i)
        {
        }

        private static void ShowObject(object i)
        {
        }

        private static void Show<T>(T i)
        {
        }

        #endregion
    }
}