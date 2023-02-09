using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

 class Program
    {
        static void Main(string[] args)
        {
            var test = BenchmarkRunner.Run<StrBenchmarks>();
        }
    }


    public class StrBenchmarks
    {
        private  string[] str;
        private  int number;

        public StrBenchmarks()
        {
            number = 150;
            str = new string[number];
            for (int i = 0; i < number; i++)
            {
                str[i] = "Hillel";
               // str[i] = new string('a', 2000);
            }
        }

        [Benchmark]
        public string PlusOperator()
        {
            string result = "";
            for (int i = 0; i < number; i++)
            {
                result += str[i];
            }

            return result;
        }

        [Benchmark]
        public string StringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                stringBuilder.Append(str[i]);
            }

            return stringBuilder.ToString();
        }

        [Benchmark]
        public string StringJoin()
        {
            return string.Join("", str);
        }

        [Benchmark]
        public string StringConcat()
        {
            return string.Concat(str);
        }
    }

   
