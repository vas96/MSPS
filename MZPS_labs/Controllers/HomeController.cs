using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MZPS_labs.Models;

namespace MZPS_labs.Controllers
{   
    public class HomeController : Controller
    {
    
        [HttpPost]
        public IActionResult firstMethod(string[] arr)
        {         
            try
            {
                arr.ToList();

                List<double> initialData = arr.Select(x => double.Parse(x)).ToList();
                FirstTableData data = new FirstTableData(initialData);
                List<double[]> res = data.allData();

                return PartialView("_firstMethod", res);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost]
        public IActionResult secondMethod(string[] arr)
        {
            arr.ToList();
           
            List<double> initialData = arr.Select(x => double.Parse(x)).ToList();
            SecondTableData data = new SecondTableData(initialData);
            List<double[]> res = data.allData();

            return PartialView("_secondMethod", res);
        }
        [HttpPost]
        public IActionResult thirdMethod(string[] arr)
        {
            try
            {
                arr.ToList();

                List<double> initialData = arr.Select(x => double.Parse(x)).ToList();
                ThirdTableData data = new ThirdTableData(initialData);
                List<double[]> res = data.allData();

                return PartialView("_thirdMethod", res);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost]
        public IActionResult fourhMethod(string[] arr)
        {
            try
            {
                arr.ToList();

                List<double> initialData = arr.Select(x => double.Parse(x)).ToList();
                FourthTableData data = new FourthTableData(initialData);
             
                var res = data.allData();

                return PartialView("_fourhMethod", res);
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet]
        public IActionResult Lab1()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Lab1_2()
        {
            return View();
        }
        public IActionResult Lab1_3()
        {
            return View();
        }
        public IActionResult Lab2()
        {
            return View();
        }
        public IActionResult Lab3()
        {
            return View();
        }
        public IActionResult Lab4()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Lab2_tables(string[] arr)
        {
            arr.ToList();
            List<double> initialData = arr.Select(x => double.Parse(x)).ToList();
            var lab2 = new Lab2(initialData);

            var twoTables = lab2.FullResult();

            return PartialView("_Lab2_tables", twoTables);
        }

        [HttpPost]
        public IActionResult Lab3_example()
        {
            List<List<double>> matrix = new List<List<double>>()
                {
            new List<double>(){8.0, 5, 9, 7},
            new List<double>(){5.0, 9, 6, 5},
            new List<double>(){10.0, 6, 9, 6},
            new List<double>(){6.0, 5, 10, 7},
            new List<double>(){5.0, 5, 10, 4},
            new List<double>(){9.0, 9, 7, 10},
            new List<double>(){9.0, 5, 10, 5},
            new List<double>(){6.0, 5, 10, 7},
            new List<double>(){8.0, 6, 9, 6},
            new List<double>(){7.0, 8, 6, 10},
                };

            List<List<double>> matrix2 = new List<List<double>>()
                {
            new List<double>(){10.0, 9, 10, 8.05},
            new List<double>(){9.0, 8, 8, 7.5},
            new List<double>(){9.0, 7, 9, 6.10},
            new List<double>(){6.0, 5, 8, 7.7},
            new List<double>(){7.0, 5, 8, 6.05},
            new List<double>(){9.0, 7, 8, 7.85},
            new List<double>(){10.0, 9, 10, 7.35},
            new List<double>(){6.0, 8, 7, 5.55},
            new List<double>(){9.0, 7, 6, 7.85},
            new List<double>(){6.0, 5, 9, 4.3},
                };

            double[][] matrix3 = new double[][]
            {
            new []{8.3, 8.8, 8.0, 7.1, 8.1},
            new []{7.3, 9.2, 8.9, 8.1, 6.7},
            new []{9.8, 9.0, 9.5, 9.9, 8.1},
            new []{9.8, 8.4, 6.9, 6.3, 6.5},
            new []{5.9, 7.6, 5.2, 8.6, 5.6},
            new []{9.8, 8.4, 6.9, 6.3, 6.5},
            new []{9.8, 7.1, 6.5, 9.0, 8.0},
            new []{5.9, 7.6, 5.3, 8.6, 5.6},
            new []{9.7, 8.4, 9.8, 9.6, 8.8},
            };

            Lab3 data = new Lab3(matrix, matrix2);

            List<double> Kj = new List<double>() { 6, 5, 10, 7.0 };
            List<double> Aj = new List<double>() { 6, 5, 8, 7.7 };

            var res = data.FullResult();

            return PartialView("_Lab3_example", res);
        }
        [HttpPost]
        public IActionResult Lab4_example()
        {
            List<List<double>> matrix = new List<List<double>>()
                {
            new List<double>(){34.53, 52.54, 42.61, 12.78, 22.02},
            new List<double>(){30.91, 52.90, 40.28, 13.80, 22.79},
            new List<double>(){33.65, 50.82, 42.39, 10.06, 22.26},
            new List<double>(){32.64, 54.20, 44.54, 12.89, 22.59},
            new List<double>(){34.04, 54.41, 42.42, 13.28, 21.87},
            new List<double>(){30.48, 54.31, 43.56, 10.30, 23.66},
            new List<double>(){32.37, 51.02, 43.55, 10.64, 20.16},
            new List<double>(){34.02, 50.61, 41.14, 12.76, 20.58},
            new List<double>(){34.27, 54.89, 44.87, 12.69, 20.86},
            new List<double>(){33.77, 52.13, 43.30, 10.98, 21.74},

            new List<double>(){35.0, 55.0, 45.0, 10.0, 20.0},
            new List<double>(){0.032, 0.201, 0.398, 0.110, 0.259},
                };

            Lab4 data = new Lab4(matrix);
            var res = data.FullResult();

            return PartialView("_Lab4_example", res);
        }
        [HttpPost]
        public IActionResult Lab4_MyVariant()
        {
            List<List<double>> matrix = new List<List<double>>()
                {
            new List<double>(){24.72, 34.28, 10.17, 51.02, 43.20},
            new List<double>(){23.95, 33.14, 11.16, 54.34, 44.24},
            new List<double>(){22.20, 34.71, 12.49, 54.08, 41.59},
            new List<double>(){20.60, 31.06, 11.18, 53.71, 40.47},
            new List<double>(){23.91, 30.78, 13.30, 53.43, 41.91},
            new List<double>(){22.68, 33.76, 12.08, 52.13, 41.82},
            new List<double>(){24.74, 31.34, 12.33, 51.44, 43.97},
            new List<double>(){21.15, 31.84, 14.91, 52.75, 42.41},
            new List<double>(){20.01, 32.33, 13.22, 52.69, 44.98},
            new List<double>(){22.64, 30.96, 13.79, 52.22, 41.39},

            new List<double>(){25.0, 35.0, 15.0, 50.0, 40.0},
            new List<double>(){0.191, 0.147, 0.376, 0.165, 0.120},
                };

            Lab4 data = new Lab4(matrix);
            var res = data.FullResult();

            return PartialView("_Lab4_example", res);
        }

        [HttpPost]
        public IActionResult Lab_3MyVariant()
        {

            List<List<double>> matrix = new List<List<double>>()
                {
            new List<double>(){8.3, 8.8, 8.0, 7.1, 8.1},
            new List<double>(){7.3, 9.2, 8.9, 8.1, 6.7},
            new List<double>(){9.8, 9.0, 9.5, 9.9, 8.1},
            new List<double>(){9.8, 8.4, 6.9, 6.3, 6.5},
            new List<double>(){9.8, 7.1, 6.5, 9.0, 8.0},
            new List<double>(){5.9, 7.6, 5.2, 8.6, 5.6},
            new List<double>(){9.8, 8.4, 6.9, 6.3, 6.5},
            new List<double>(){9.8, 7.1, 6.5, 9.0, 8.0},
            new List<double>(){5.9, 7.6, 5.3, 8.6, 5.6},
            new List<double>(){9.7, 8.4, 9.8, 9.6, 8.8},
            };

            List<List<double>> matrix2 = new List<List<double>>()
                {
            new List<double>(){5.0, 7, 5, 5, 7},
            new List<double>(){6.0, 9, 9, 7, 8},
             new List<double>(){5.0, 8, 5, 5, 5},
              new List<double>(){7.0, 9, 10, 8, 9},
               new List<double>(){6.0, 8, 10, 6, 8},
                new List<double>(){5.0, 5, 7, 6, 7},
                 new List<double>(){8.0, 8, 8, 7, 7},
                  new List<double>(){7.0, 8, 7, 6, 7},
                   new List<double>(){8.0, 7, 10, 8, 9},
                    new List<double>(){9.0, 10, 10, 8, 9},
                };
        
            Lab3 data = new Lab3(matrix, matrix2);

            var res = data.FullResult();

            return PartialView("_Lab_3MyVariant", res);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    //lab 1 - method 1
    public class FirstTableData
    {
        public List<double> A { get; set; }
        int n = 0;
        public FirstTableData(List<double> a)
        {
            A = a;
            n = a.Count;
            double avg = a.Average();
        }

        //Формула для обчислення першого рядка таблиці
        private List<double> firstRow(List<double> Arr)
        {
            List<double> temp = new List<double>();
            double Xcl = Arr.Average();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(Xcl - Arr[i])), 4));
            }
            //додаємо суму усіх значень
            temp.Add(Math.Round((temp.Sum()), 4));
            //то мало бути в конструкторі
            A.Add(Arr.Sum());
            A.Add(Xcl);
            //повертаємо ліст значень
            return temp;
        }

        private List<double> firstRow2(List<double> Arr , double last)
        {
            List<double> temp = new List<double>();
            double Xcl = Arr.Sum() / Arr.Count;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(Arr[i] - last)), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        private List<double> secondRow(List<double> Arr)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(1 / Arr[i])), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        private List<double> thirdRow(List<double> Arr, List<double> Arr2, double sum)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(Arr[i] / (Arr2[i] * sum))), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        public List<double[]> allData()
        {
            //вихідний результат
            List<double[]> result = new List<double[]>();
            //проміжні значення
            List<double> temp1;
            List<double> temp2;
            List<double> temp3 = new List<double>() { 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99 };
            double[] finalCoef = { 1.1, 99};
            var tmplamda = 0.0; 
            //розрахунок
            for (int i = 0;; i++)
            {
                if (temp3.Last() <= 0.005)
                {
                    break;
                }
                if (i == 0)
                {
                    temp1 = firstRow(A);
                    result.Add(A.ToArray());
                    tmplamda = A.Last();
                }
                else
                {                   
                    temp1 = firstRow2(A, temp3[n]);
                    tmplamda = temp3[n];
                }

                temp2 = secondRow(temp1);
                var coef = temp3[n];
                temp3 = thirdRow(A, temp1, temp2[n]);

                tmplamda -= temp3[n];
               
                temp3.Add(Math.Round(tmplamda,4));
              
                double[] tempStr = new double[] { i+1,};
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());
               
            }
            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n] - A[i]),4));

                if (i == 0)
                {
                    finalCoef[0] = (double)i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double)i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }
            result.Add(finalResult.ToArray());


            result.Add(finalCoef);
            double[] experts = { (double)n };
            result.Add(experts);
           
            return result;
        }
    }
    //lab 1 - method 2
    public class SecondTableData
    {
        public List<double> A { get; set; }
        public int n = 0;
        public double q = 1.490;
        public SecondTableData(List<double> a)
        {
            A = a;
            n = a.Count;
            double avg = a.Average();
            A.Add(a.Sum());           
            A.Add(avg);
        }

        private List<double> firstRow(List<double> Arr, double avg)
        {
            List<double> temp = new List<double>();           
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round( (Math.Pow(Arr[i] - avg, 2) * (n+1)) / q, 4));
            }
            
            return temp;
        }
 
        private List<double> secondRow(List<double> Arr, double avg)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add( Math.Round(Math.Exp(-((Math.Pow(Arr[i] - avg, 2) * (n + 1)) / q)), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));
           
            return temp;
        }

        private List<double> thirdRow(List<double> Arr,  double avg, double prevSum)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round(Arr[i] * Math.Exp(-((Math.Pow(Arr[i] - avg, 2) * (n+1)) / q)), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));
            temp.Add(Math.Round((temp.Last()/ prevSum), 4));
            temp.Add(Math.Round((avg - temp.Last()), 4));
            return temp;
        }

        public List<double[]> allData()
        {
            List<double[]> result = new List<double[]>();
 
            List<double> temp1;
            List<double> temp2;
            List<double> temp3 = new List<double>() { 1.1 };
            double[] finalCoef = { 1.1, 99 };

            for (int i = 0;; i++)
            {
                if (temp3.Last() <= 0.005)
                {
                    break;
                }
                if (i == 0)
                {
                    temp1 = firstRow(A, A [n + 1]);
                    temp2 = secondRow(A, A[n + 1]);
                    temp3 = thirdRow(A, A [n + 1], temp2.Last());                   
                }
                else
                {
                    temp1 = firstRow(A, temp3 [n + 1]);
                    temp2 = secondRow(A, temp3[n + 1]);
                    temp3 = thirdRow(A, temp3 [n + 1], temp2.Last());
                }

              
                double[] tempStr = new double[] { i + 1, };
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());
            }

            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n + 1] - A[i]),4));
                if (i==0)
                {
                    finalCoef[0] = (double)i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double)i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }
            result.Add(finalResult.ToArray());
            result.Add(finalCoef);
            double[] experts = { (double)n };
            result.Add(experts);
            return result;
        }
    }
    //lab 1 - method 1 (formula-2)
    public class ThirdTableData
    {
        public List<double> A { get; set; }
        int n = 0;
        public ThirdTableData(List<double> a)
        {
            A = a;
            n = a.Count;
            double avg = a.Average();
        }

        //Формула для обчислення першого рядка таблиці
        private List<double> firstRow(List<double> Arr)
        {
            List<double> temp = new List<double>();
            double Xcl = Arr.Average();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add( Math.Round( 1 + Arr[i] * Math.Pow(Xcl - Arr[i], 2), 4));
            }
            //додаємо суму усіх значень
            temp.Add(Math.Round((temp.Sum()), 4));
            //то мало бути в конструкторі
            A.Add(Arr.Sum());
            A.Add(Xcl);
            //повертаємо ліст значень
            return temp;
        }

        private List<double> firstRow2(List<double> Arr, double last)
        {
            List<double> temp = new List<double>();
            double Xcl = Arr.Sum() / Arr.Count;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round(1 + Arr[i] * Math.Pow(last - Arr[i], 2), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        private List<double> secondRow(List<double> Arr)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(1 / Arr[i])), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        private List<double> thirdRow(List<double> Arr, List<double> Arr2, double sum)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(Arr[i] / (Arr2[i] * sum))), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        public List<double[]> allData()
        {
            //вихідний результат
            List<double[]> result = new List<double[]>();
            //проміжні значення
            List<double> temp1;
            List<double> temp2;
            List<double> temp3 = new List<double>() { 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99 };
            double[] finalCoef = { 1.1, 99 };
            var tmplamda = 0.0;
            //розрахунок
            for (int i = 0; ; i++)
            {
                if (temp3.Last() <= 0.005)
                {
                    break;
                }
                if (i == 0)
                {
                    temp1 = firstRow(A);
                    result.Add(A.ToArray());
                    tmplamda = A.Last();
                }
                else
                {
                    temp1 = firstRow2(A, temp3[n]);
                    tmplamda = temp3[n];
                }

                temp2 = secondRow(temp1);
                var coef = temp3[n];
                temp3 = thirdRow(A, temp1, temp2[n]);

                tmplamda -= temp3[n];

                temp3.Add(Math.Round(tmplamda, 4));

                double[] tempStr = new double[] { i + 1, };
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());

            }
            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n] - A[i]),4));

                if (i == 0)
                {
                    finalCoef[0] = (double)i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double)i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }
            result.Add(finalResult.ToArray());


            result.Add(finalCoef);
            double[] experts = { (double)n };
            result.Add(experts);

            return result;
        }
    }
    //lab 1 - method 1 (formula-3)
    public class FourthTableData
    {
        public List<double> A { get; set; }
        int n = 0;
        public FourthTableData(List<double> a)
        {
            A = a;
            n = a.Count;
            double avg = a.Average();
        }

        //Формула для обчислення першого рядка таблиці
        private List<double> firstRow(List<double> Arr)
        {
            List<double> temp = new List<double>();
            double Xcl = Arr.Average();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round( Math.Pow((Math.Abs(Xcl - Arr[i])),2), 4));
            }
            //додаємо суму усіх значень
            temp.Add(Math.Round((temp.Sum()), 4));
            //то мало бути в конструкторі
            A.Add(Arr.Sum());
            A.Add(Xcl);
            //повертаємо ліст значень
            return temp;
        }

        private List<double> firstRow2(List<double> Arr, double last)
        {
            List<double> temp = new List<double>();
            double Xcl = Arr.Sum() / Arr.Count;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round( Math.Pow((Math.Abs(Arr[i] - last)),2), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        private List<double> secondRow(List<double> Arr)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(1 / Arr[i])), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        private List<double> thirdRow(List<double> Arr, List<double> Arr2, double sum)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round((Math.Abs(Arr[i] / (Arr2[i] * sum))), 4));
            }
            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        public List<double[]> allData()
        {
            //вихідний результат
            List<double[]> result = new List<double[]>();
            //проміжні значення
            List<double> temp1;
            List<double> temp2;
            List<double> temp3 = new List<double>() { 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99 };
            double[] finalCoef = { 1.1, 99 };
            var tmplamda = 0.0;
            //розрахунок
            for (int i = 0; i < 22; i++)
            {
                if (temp3.Last() <= 0.005)
                {
                    break;
                }
                if (i == 0)
                {
                    temp1 = firstRow(A);
                    result.Add(A.ToArray());
                    tmplamda = A.Last();
                }
                else
                {
                    temp1 = firstRow2(A, temp3[n]);
                    tmplamda = temp3[n];
                }

                temp2 = secondRow(temp1);
                var coef = temp3[n];
                temp3 = thirdRow(A, temp1, temp2[n]);

                tmplamda -= temp3[n];

                temp3.Add(Math.Round(tmplamda, 4));

                double[] tempStr = new double[] { i + 1, };
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());

            }
            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n] - A[i]),4));

                if (i == 0)
                {
                    finalCoef[0] = (double)i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double)i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }
            result.Add(finalResult.ToArray());


            result.Add(finalCoef);
            double[] experts = { (double)n };
            result.Add(experts);

            return result;
        }
    }
    //lab2
    public class Lab2
    {
        public List<double> Coefs { get; set; }

        private double[][] matrix = new double[][]
    {
            new []{8.0, 5, 9, 7 },
            new []{5.0, 9, 6, 5 },
            new []{10.0, 6, 9, 6},
            new []{6.0, 5, 10, 7},
            new []{5.0, 5, 10, 4},
            new []{9.0, 9, 7, 10},
            new []{9.0, 7, 6, 10},
            new []{6.0, 5, 10, 5},
            new []{8.0, 6, 9, 6 },
            new []{7.0, 8, 6, 10}
    };

        private double[][] matrix2 = new double[][]
    {
            new []{10.0, 9, 10, 8.05},
            new []{ 9.0, 8, 8, 7.50},
            new []{9, 7, 9, 6.10},
            new []{6, 5, 8, 7.70},
            new []{7, 5, 8, 6.05},
            new []{9, 7, 8, 7.85},
            new []{10, 9, 10, 7.35},
            new []{6, 8, 7, 5.55},
            new []{9, 7, 6, 7.85},
            new []{6, 5, 9, 4.30}
    };


        public Lab2(List<double> coefs)
        {
            Coefs = coefs;
        }

        List<List<string>> forAngles = new List<List<string>>();

        public List<List<string>> ConcatFirstTable()
        {

            List<List<string>> firstTable = new List<List<string>>();

            for (int i = 0; i < matrix.Length; i++)
            {
                List<string> avgTemp = new List<string>();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    avgTemp.Add(matrix[i][j].ToString() + "/" + matrix2[i][j].ToString());
                }
                avgTemp.Add(matrix[i].Average().ToString());
                firstTable.Add(avgTemp);
            }
            List<string> sumTemp = new List<string>();
            for (int k = 0; k < matrix[1].Length; k++)
            {
                List<string> anglTemp = new List<string>();
                var firstMatrix = 0.0;
                var secondMatrix = 0.0;
                for (int l = 0; l < matrix.Length; l++)
                {
                    firstMatrix += matrix[l][k];
                    secondMatrix += matrix2[l][k];
                    anglTemp.Add(matrix[l][k].ToString());
                }
                sumTemp.Add(firstMatrix.ToString() + "/" + (secondMatrix / matrix.Length).ToString());

                anglTemp.Add(firstMatrix.ToString());
                forAngles.Add(anglTemp);
            }
            List<string> anglTemp2 = new List<string>();
            var temp = 0.0;
            for (int g = 0; g < firstTable.Count; g++)
            {
                temp += double.Parse(firstTable[g].Last(), System.Globalization.NumberStyles.AllowDecimalPoint);
                anglTemp2.Add(firstTable[g].Last());
            }
            anglTemp2.Add(temp.ToString());
            forAngles.Add(anglTemp2);

            sumTemp.Add(temp.ToString());
            firstTable.Add(sumTemp);

            return firstTable;
        }

        public List<List<string>> ConcatSecondTable()
        {
            var GradesSum = 0.0;
            var ExpertsGradesSum = 0.0;
            var avgGradesSum = 0.0;
            var tempMidGradesSum = 1.0;

            List<List<string>> secondTable = new List<List<string>>();

            for (int i = 0; i < matrix.Length; i++)
            {
                var tempSum = 1.0;
                
                List<string> sumCoefTemp = new List<string>();
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    sumCoefTemp.Add((matrix[i][j] * matrix2[i][j]).ToString());
                    tempSum += (matrix[i][j] * matrix2[i][j]) * Coefs[j];
                }

                sumCoefTemp.Add((matrix[i][matrix[1].Length - 1] * matrix2[i][matrix2[1].Length - 1]).ToString());        
                tempSum += (matrix[i][matrix[1].Length - 1] * matrix2[i][matrix2[1].Length - 1]) * Coefs.Last();

                var tempMidleVal = 0.0;
                for (int k = 0; k < sumCoefTemp.Count(); k++)
                {
                    tempMidleVal += Math.Round( (double.Parse((sumCoefTemp[k]), System.Globalization.NumberStyles.AllowDecimalPoint) * Coefs[k]) / Coefs.Sum() , 4);
                }

                tempMidGradesSum += tempMidleVal;

                sumCoefTemp.Add(tempMidleVal.ToString());
                //double prod = Coefs.Aggregate(1.0, (a, b) => a * b);
                var averagedGrades = Math.Round((tempSum) / Coefs.Sum() / matrix[i].Average(), 3 );
                GradesSum += averagedGrades;
                sumCoefTemp.Add(averagedGrades.ToString());

                secondTable.Add(sumCoefTemp);
            }


            List<string> averageGradesList = new List<string>();
            List<string> gradesWithExperts = new List<string>();

            for (int i = 0; i < matrix[1].Length; i++)
            {
                var firstMatrix = 0.0;
                var secondMatrix = 0.0;

                for (int j = 0; j < matrix.Length; j++)
                {
                    firstMatrix += matrix[j][i];
                    secondMatrix += (double.Parse(secondTable[j][i]));
                }
                averageGradesList.Add(Math.Round((secondMatrix / firstMatrix), 2).ToString());
                gradesWithExperts.Add(Math.Round((secondMatrix / firstMatrix) * Coefs[i], 2).ToString());
                ExpertsGradesSum += Math.Round((secondMatrix / firstMatrix) * Coefs[i]);
                avgGradesSum += (Math.Round((secondMatrix / firstMatrix), 2));
            }

            gradesWithExperts.Add(Math.Round((avgGradesSum / 4), 2).ToString());
            averageGradesList.Add((Math.Round((tempMidGradesSum/10 / 7.75), 2).ToString()));
            averageGradesList.Add((Math.Round((GradesSum / 10), 2).ToString()));
            gradesWithExperts.Add(Math.Round((ExpertsGradesSum / Coefs.Sum()), 2).ToString());

            secondTable.Add(averageGradesList);
            secondTable.Add(gradesWithExperts);

            return secondTable;
        }

        public Dictionary<int, List<List<string>>> FullResult()
        {
            List<List<string>> coefs = new List<List<string>>();

            List<string> tempCoefs = Coefs.Select(x => x.ToString()).ToList();
            coefs.Add(tempCoefs);
            Dictionary<int, List<List<string>>> result = new Dictionary<int, List<List<string>>>(2);
            result.Add(1, ConcatFirstTable());
            result.Add(2, ConcatSecondTable());
            result.Add(3, coefs);

            List<List<string>> anglesList = new List<List<string>>();
            //calculate angles for diagrams//
            for (int i = 0; i < forAngles.Count; i++)
            {
                var tmp = 0.0;//first angl 0
                List<string> templistAngls = new List<string>();
                for (int j = 0; j < forAngles.Last().Count - 1; j++)
                {
                    if (j == 0)
                    {
                        templistAngls.Add(tmp.ToString());
                    }
                    else
                    {
                        //from radians to degrees
                        double angl = ((double.Parse(forAngles[i][j])) / double.Parse(forAngles[i].Last())) * (180.0 / Math.PI);
                        tmp = (2 * Math.PI * angl) + tmp;
                        templistAngls.Add(tmp.ToString());

                    }
                }
                anglesList.Add(templistAngls);
            }

            result.Add(4, anglesList);
            return result;
        }
    }
    //lab3
    public class Lab3
    {
        private int m = 4;
        private double q = 0.05;
        private double k1 = 0.0;
        private double a1 = 0.0;

        //private List<double> Kj = new List<double>() { 6, 5, 10, 7.0 };
        //private List<double> Aj = new List<double>() { 6, 5, 8, 7.7 };

        List<List<double>> Matrix { get; set; }
        List<List<double>> newMatrix = new List<List<double>>();
        List<List<double>> Matrix2 { get; set; }
        List<List<double>> matrix2Copied;
        public Lab3(List<List<double>> matrix, List<List<double>> matrix2)
        {
            Matrix = matrix;
            Matrix2 = matrix2;
            matrix2Copied = new List<List<double>>(matrix2);
            m = matrix[1].Count;
        }
        
  //      private double[][] matrix = new double[][]
  //{
  //          new []{8.0, 5, 9, 7},
  //          new []{5.0, 9, 6, 5},
  //          new []{10.0, 6, 9, 6},
  //          new []{6.0, 5, 10, 7},
  //          new []{9.0, 9, 7, 10},
  //          new []{9.0, 7, 6, 10},
  //          new []{6.0, 5, 10, 5},
  //          new []{8.0, 6, 9, 6},
  //          new []{7.0, 8, 6, 9},

        //};

        //      private double[][] matrix2 = new double[][]
        //{
        //            new []{10.0, 9, 10, 8.05},
        //            new []{9.0, 8, 8, 7.5},
        //            new []{9.0, 7, 9, 6.10},
        //            new []{6.0, 5, 8, 7.7},
        //            new []{7.0, 5, 8, 6.05},
        //            new []{9.0, 7, 8, 7.85},
        //            new []{10.0, 9, 10, 7.35},
        //            new []{6.0, 8, 7, 5.55},
        //            new []{6.0, 5, 9, 4.3},

        //};
        //create first and last tables
        public List<List<string>> ConcatTable(List<List<double>> _firstData, List<List<double>> _secondData)
        {
            var firstData = new List<List<double>>(_firstData);
            var secondData = new List<List<double>>(_secondData);
            var sumAvg = 0.0;
            var sumAvg2 = 0.0;
            List<List<string>> firstTable = new List<List<string>>();

            for (int i = 0; i < firstData.Count; i++)
            {
                 List<string>  temp = new List<string>();

                for (int j = 0; j < firstData[1].Count; j++)
                {
                    temp.Add(firstData[i][j].ToString() + "/" + secondData[i][j].ToString());
                }
                temp.Add((firstData[i].Sum() / firstData[i].Count).ToString() + "/" + (secondData[i].Sum()/secondData[i].Count).ToString());
                sumAvg += firstData[i].Sum() / firstData[i].Count;
                sumAvg2 += secondData[i].Sum() / secondData[i].Count;
                firstTable.Add(temp);
            }

            List<string> tempListSum = new List<string>();
            for (int i = 0; i < firstData[i].Count; i++)
            {
                var tempSum = 0.0;
                var avgSum = 0.0;
                for (int j = 0; j < firstData.Count; j++)
                {
                   tempSum += firstData[j][i];
                    avgSum += secondData[j][i];
                }
                tempListSum.Add(Math.Round((tempSum / firstData.Count),3).ToString() + "/" + Math.Round((avgSum / firstData.Count),3).ToString());
            }
            tempListSum.Add((sumAvg / firstData.Count).ToString() +"/"+ (sumAvg2 / secondData.Count).ToString());
            firstTable.Add(tempListSum);
            return firstTable;
        }
        // itearations for last table
        public List<List<string>> IterationTable(List<double> _Kj, List<double> _Aj)
        {
            var Kj = new List<double>(_Kj);
            var Aj = new List<double>(_Aj);
            Kj.Add(Kj.Sum());
            Aj.Add(Aj.Sum());

            k1 = Kj.Last() / m;
            a1 = Aj.Last() / m;

            Kj.Add(k1);
            Aj.Add(a1);

            List<List<string>> iterationTable = new List<List<string>>();
            //secodTable.Add(Aj.Select(x => (x.ToString())).ToList());

             List<double> firstRow(List<double> fourthRowArr)
            {
                List<double> temp = new List<double>();
                for (int i = 0; i < fourthRowArr.Count - 2; i++)
                {
                    temp.Add(Math.Round(fourthRowArr[i] * Aj[i],3));
                }
                temp.Add(Math.Round(temp.Sum(), 3));
                temp.Add(Math.Round(temp.Last() / m, 3));
                return temp;
            }

            List<double> secondRow(double a)
            {
                
                List<double> temp = new List<double>();
                for (int i = 0; i < Aj.Count - 2; i++)
                {
                    temp.Add(Math.Round(Math.Abs(a - Aj[i]), 3));
                }
                temp.Add(Math.Round(temp.Sum(), 3));
                return temp;
            }

            List<double> thirdRow(List<double> Arr)
            {
               
                List<double> temp = new List<double>();
                for (int i = 0; i < Arr.Count - 1; i++)
                {
                    if (Arr[i] == 0)
                    {
                        temp.Add(Math.Round(1.0, 3)); ;
                    }
                    else { temp.Add(Math.Round(1 / Arr[i], 3)); }
                   
                }
                temp.Add(Math.Round(temp.Sum(), 3));
                return temp;
            }

            List<double> fourthRow(List<double> secondArr, double thirdSum, double a , double aPrew)
            {
                List<double> temp = new List<double>();
                for (int i = 0; i < secondArr.Count - 1; i++)
                {
                    if (secondArr[i] == 0)
                    {
                        temp.Add(Math.Round(Kj.Last() / 1 / thirdSum, 3));
                    }
                    else { 
                    temp.Add(Math.Round(Kj.Last()/secondArr[i]/thirdSum, 3));
                         }
                }
                temp.Add(Math.Round(temp.Sum(), 3));
                temp.Add(Math.Round(Math.Abs(aPrew - a), 3));

                return temp;             
            }

            List<double> resultRow1(List<double> fourthArr)
            {
                List<double> temp = new List<double>();
                for (int i = 0; i < Aj.Count - 2; i++)
                {
                    temp.Add(Math.Round(Aj[i] * fourthArr[i], 3));
                }
                temp.Add(Math.Round(temp.Sum(), 3));
                temp.Add(Math.Round(temp.Last()/m, 3));
                return temp;
            }

            List<double> resultRow2(List<double> fourthArr , double a)
            {
                List<double> temp = new List<double>();
                for (int i = 0; i < Kj.Count - 2; i++)
                {
                    if (Kj[i] < Kj.Last())
                    {
                        temp.Add(Kj[i] + fourthArr[i]);
                    }
                    else
                    {
                        temp.Add(Kj[i] - fourthArr[i]);
                    }
                }
                var newTemp = new List<double>(temp);
                newMatrix.Add(newTemp);

                temp.Add(Math.Round(temp.Sum(), 3));
                temp.Add(Math.Round(temp.Last() / m, 3));
                temp.Add(Math.Round(Math.Abs(a - Aj.Last()) , 3));
                return temp;
            }

            List<double> row1 = new List<double>();
            List<double> row2 = new List<double>();
            List<double> row3 = new List<double>();
            List<double> row4 = new List<double>();

            for (int i = 0;  ;i++)
            {

                double aPrew = 0.0;
                if (i == 0)
                {
                    row1 = Aj;
                    aPrew = 0;
                }
                else
                {
                    aPrew = row1.Last();
                    row1 = firstRow(row4);                 
                }
                row2 = secondRow(row1.Last());
                row3 = thirdRow(row2);
                row4 = fourthRow(row2, row3.Last(), row1.Last(), aPrew);

                iterationTable.Add(row1.Select(x => (x.ToString())).ToList());
                iterationTable.Add(row2.Select(x => (x.ToString())).ToList());
                iterationTable.Add(row3.Select(x => (x.ToString())).ToList());
                iterationTable.Add(row4.Select(x => (x.ToString())).ToList());

                if (row4.Last() <= q && i != 0)
                {
                    break;
                }
            }
            var theLatRow1 = resultRow1(row4);
            var theLatRow2 = resultRow2(row4, theLatRow1.Last());
            iterationTable.Add(theLatRow1.Select(x => (x.ToString())).ToList());
            iterationTable.Add(theLatRow2.Select(x => (x.ToString())).ToList());

            return iterationTable;
        }
        // all results
        public Dictionary<int, List<List<string>>> FullResult()
        {
            Dictionary<int, List<List<string>>> result = new Dictionary<int, List<List<string>>>();
            var firstTable = ConcatTable(Matrix, Matrix2);
            result.Add(0, firstTable);
            int i = 0;
            for (i = 0; i < Matrix.Count; i++)
            {
                var tempTable = IterationTable(Matrix[i], Matrix2[i]);
                result.Add(i+1,tempTable);
            }
            var newTable = ConcatTable(newMatrix, matrix2Copied);
            result.Add(i+1, newTable);
            return result;

        }
    }

    public class Lab4
    {
        List<List<double>> Matrix { get; set; }

        public  Lab4(List<List<double>> matrix)
        {
            Matrix = matrix;
            List<double> maxList = new List<double>();
            List<double> minList = new List<double>();
            List<double> Indexes = new List<double>();
            for (int i = 0; i < matrix[i].Count; i++)
            {
                var min = matrix[0][i];
                var max = matrix[0][i];
                var indexMax = 1;
                for (int j = 0; j < matrix.Count-2; j++)
                {
                    if (matrix[j][i] < min)
                    {
                        min = matrix[j][i];
                        if (i >= 3)
                        {
                            indexMax = j + 1;
                        }
                    }
                    if (matrix[j][i] > max)
                    {
                        max = matrix[j][i];
                        if (i<3)
                        {
                          indexMax = j + 1;
                        }
                        
                    }                 
                }
                maxList.Add(max);
                minList.Add(min);
                Indexes.Add(indexMax);
            }
            Matrix.Add(maxList);
            Matrix.Add(minList);
            Matrix.Add(Indexes);
        }
        //
        private List<List<double>> MaxAndIndex(List<List<double>> Arr)
        {
            List<List<double>> result = new List<List<double>>();
            List<double> maxList = new List<double>();
            List<double> Indexes = new List<double>();
            for (int i = 0; i < Arr[i].Count; i++)
            {              
                var max = Arr[0][i];
                var indexMax = 1;
                for (int j = 0; j < Arr.Count; j++)
                {              
                    if (Arr[j][i] > max)
                    {
                        max = Arr[j][i];                        
                        indexMax = j + 1;
                    }
                }
                maxList.Add(max);                
                Indexes.Add(indexMax);
            }
            result.Add(maxList);
            result.Add(Indexes);
            return result;
        }
        private List<List<double>> MaxMinAndIndex(List<List<double>> Arr)
        {
            List<List<double>> result = new List<List<double>>();
            List<double> maxList = new List<double>();
            List<double> minList = new List<double>();
            List<double> Indexes = new List<double>();
            for (int i = 0; i < Arr[1].Count; i++)
            {
                var max = Arr[0][i];
                var min = Arr[0][i];
                var indexMax = 1;
                for (int j = 0; j < Arr.Count; j++)
                {
                    if (Arr[j][i] < min)
                    {
                        min = Arr[j][i];
                        if ((i >= 3 && i < 5) || i==6 || i == 8 || i==10)
                        {
                            indexMax = j + 1;
                        }
                    }
                    if (Arr[j][i] > max)
                    {
                        max = Arr[j][i];
                        if (i < 3 || i==5 ||i==7 || i==9)
                        {
                            indexMax = j + 1;
                        }

                    }
                }
                maxList.Add(max);
                Indexes.Add(indexMax);
            }
            result.Add(maxList);
            result.Add(Indexes);
            return result;
        }

        private List<List<double>> MaxMinAndIndex2(List<List<double>> Arr)
        {
            List<List<double>> result = new List<List<double>>();
            List<double> maxList = new List<double>();
            List<double> minList = new List<double>();
            List<double> Indexes = new List<double>();
            for (int i = 0; i < Arr[1].Count; i++)
            {
                if (i == 0)
                {
                    maxList.Add(11);
                    Indexes.Add(12);
                }
                else
                {
                    var max = Arr[0][i];
                    var min = Arr[0][i];
                    var indexMax = 1;
                    for (int j = 0; j < Arr.Count; j++)
                    {
                        if (Arr[j][i] < min)
                        {
                            min = Arr[j][i];
                            if ((i >= 3 && i < 5) || i == 6 || i == 8 || i == 10)
                            {
                                indexMax = j + 1;
                            }
                        }
                        if (Arr[j][i] > max)
                        {
                            max = Arr[j][i];
                            if (i < 3 || i == 5 || i == 7 || i == 9)
                            {
                                indexMax = j + 1;
                            }

                        }
                    }
                    maxList.Add(max);
                    Indexes.Add(indexMax);
                }
            }
            result.Add(maxList);
            result.Add(Indexes);
            return result;
        }
        //Мультиплікативна згортка 
        public List<List<double>> firstTable (List<List<double>> InitialMatrix) {
            List<List<double>> result = new List<List<double>>();

            for (int i = 0; i < InitialMatrix.Count - 5; i++)
            {
                var temp = new List<double>();

                for (int j = 0; j < InitialMatrix[i].Count; j++)
                {
                    temp.Add(Math.Round(Math.Pow(InitialMatrix[i][j], Matrix[Matrix.Count - 4][j]), 3));
                }
                double multiplyed = temp.Aggregate((a, x) => a * x);
                temp.Add(Math.Round(multiplyed, 3));
                result.Add(temp);              
            }
            var maxAndIndexList = MaxAndIndex(result);
            result.Add(maxAndIndexList[0]);
            result.Add(maxAndIndexList[1]);
            return result;
        }
        public List<List<double>> secondTable(List<List<double>> InitialMatrix)
        {
            List<List<double>> result = new List<List<double>>();

            for (int i = 0; i < InitialMatrix.Count - 5; i++)
            {
                var temp = new List<double>();
                temp.Add(i + 1);
                for (int j = 0; j < InitialMatrix[i].Count; j++)
                {
                    temp.Add(InitialMatrix[i][j]);
                }
                double Pd = temp.Last() * temp[temp.Count - 2];
                double Ps = temp[1]*temp[2]*temp[3];
                double f = Ps / Pd;
                temp.Add(Math.Round(Ps, 3));
                temp.Add(Math.Round(Pd, 3));
                temp.Add(Math.Round(f, 3));

                result.Add(temp);
            }
            var maxAndIndexList = MaxAndIndex(result);
            result.Add(maxAndIndexList[0]);
            result.Add(maxAndIndexList[1]);
            return result;
        }
        public List<List<double>> thirdTable(List<List<double>> InitialMatrix)
        {
            List<List<double>> result = new List<List<double>>();

            for (int i = 0; i < InitialMatrix.Count - 5; i++)
            {
                var temp = new List<double>();
                temp.Add(i + 1);
                for (int j = 0; j < InitialMatrix[i].Count; j++)
                {
                    if (j<3)
                    {
                        temp.Add(Math.Round(InitialMatrix[i][j] / Matrix[Matrix.Count - 5][j], 3));
                    }
                    else
                    {
                        temp.Add(Math.Round(Matrix[Matrix.Count - 5][j] / InitialMatrix[i][j], 3));
                    }                    
                }
                double Pd = temp.Last() * temp[temp.Count - 2];
                double Ps = temp[1] * temp[2] * temp[3];
                double f = (Math.Round(Math.Pow((Ps * Pd), 0.2), 3));
                temp.Add(Math.Round(Ps, 3));
                temp.Add(Math.Round(Pd, 3));
                temp.Add(Math.Round(f, 3));
                result.Add(temp);
            }
            var maxAndIndexList = MaxMinAndIndex(result);
            result.Add(maxAndIndexList[0]);
            result.Add(maxAndIndexList[1]);
            return result;
        }
        public List<List<double>> fourthTable(List<List<double>> InitialMatrix)
        {
            List<List<double>> result = new List<List<double>>();

            for (int i = 0; i < InitialMatrix.Count - 5; i++)
            {
                var temp = new List<double>();
                temp.Add(i + 1);
                for (int j = 0; j < InitialMatrix[i].Count; j++)
                {
                    if (j < 3)
                    {
                        temp.Add(Math.Round(InitialMatrix[i][j] / Matrix[Matrix.Count - 3][j], 3));
                    }
                    else
                    {
                        temp.Add(Math.Round(Matrix[Matrix.Count - 2][j] / InitialMatrix[i][j], 3));
                    }
                }
                double Pd = temp.Last() * temp[temp.Count - 2];
                double Ps = temp[1] * temp[2] * temp[3];
                double r = (Math.Round(Math.Pow((Ps * Pd), 0.2), 3));
                double r1 = 1 / r;
                temp.Add(Math.Round(Ps, 3));
                temp.Add(Math.Round(Pd, 3));
                temp.Add(Math.Round(r, 3));
                temp.Add(Math.Round(r1, 3));
                result.Add(temp);
            }
            var maxAndIndexList = MaxMinAndIndex(result);
            result.Add(maxAndIndexList[0]);
            result.Add(maxAndIndexList[1]);
            return result;
        }
        public List<List<double>> fifthTable(List<List<double>> InitialMatrix, List<List<double>> prevMatrix)
        {
            List<List<double>> result = new List<List<double>>();

            for (int i = 0; i < InitialMatrix.Count - 5; i++)
            {
                var temp = new List<double>();
                temp.Add(i + 1);
                for (int j = 0; j < InitialMatrix[i].Count; j++)
                {
                    if (j < 3)
                    {
                        temp.Add(Math.Round(InitialMatrix[i][j] / Matrix[Matrix.Count - 2][j], 3));
                    }
                    else
                    {
                        temp.Add(Math.Round(Matrix[Matrix.Count - 3][j] / InitialMatrix[i][j], 3));
                    }
                }
                double Pd = temp.Last() * temp[temp.Count - 2];
                double Ps = temp[1] * temp[2] * temp[3];
                double h = (Math.Round(Math.Pow((Ps * Pd), 0.2), 3));
                double h1 = 1 / h;
                double n = h * prevMatrix[i][prevMatrix[i].Count-2];
                double n1 = 1 / n;
                temp.Add(Math.Round(Ps, 3));
                temp.Add(Math.Round(Pd, 3));
                temp.Add(Math.Round(h, 3));
                temp.Add(Math.Round(h1, 3));
                temp.Add(Math.Round(n, 3));
                temp.Add(Math.Round(n1, 3));
                result.Add(temp);
            }
            var maxAndIndexList = MaxMinAndIndex(result);
            result.Add(maxAndIndexList[0]);
            result.Add(maxAndIndexList[1]);
            return result;
        }
        public List<List<double>> lastTable(List<List<double>> InitialMatrix)
        {
            List<List<double>> result = new List<List<double>>();

            for (int i = 0; i < InitialMatrix.Count - 5; i++)
            {
                var temp = new List<double>();
                temp.Add(i + 1);
                for (int j = 0; j < InitialMatrix[i].Count; j++)
                {
                    if (j < 3)
                    {
                        temp.Add(Math.Round(Math.Pow(InitialMatrix[i][j],2) / (Matrix[Matrix.Count - 3][j] * Matrix[Matrix.Count - 2][j]), 3));
                    }
                    else
                    {
                        temp.Add(Math.Round((Matrix[Matrix.Count - 3][j] * Matrix[Matrix.Count - 2][j]) / Math.Pow(InitialMatrix[i][j],2), 3));
                    }
                }
                double Pd = temp.Last() * temp[temp.Count - 2];
                double Ps = temp[1] * temp[2] * temp[3];
                double n = (Math.Round(Math.Pow((Ps * Pd), 0.2), 3));
                double n1 = 1 /n;
                temp.Add(Math.Round(Ps, 3));
                temp.Add(Math.Round(Pd, 3));
                temp.Add(Math.Round(n, 3));
                temp.Add(Math.Round(n1, 3));
                result.Add(temp);
            }
            var maxAndIndexList = MaxMinAndIndex2(result);
            result.Add(maxAndIndexList[0]);
            result.Add(maxAndIndexList[1]);
            return result;
        }
        // Ранжування варіантів ІС
        public List<List<double>> IcTable(List<List<double>> prevMatrix)
        {
            List<List<double>> result = new List<List<double>>();
           
            List<double> n = new List<double>();

            for (int i = 0; i < prevMatrix.Count-2; i++)
            {
                n.Add(prevMatrix[i][prevMatrix[1].Count - 2]);
            }
            n.Sort();
            n.Reverse();

            //var element = (from sublist in prevMatrix
            //               from item in sublist
            //               where item == 1.011
            //               select item).FirstOrDefault();

            for (int i = 0; i < n.Count; i++)
            {
                List<double> temp = new List<double>();
                for (int j = 0; j < n.Count; j++)
                {
                    if (prevMatrix[j][n.Count-2] == (n[i]))
                    {
                        temp.Add(i);
                        temp.Add(prevMatrix[j][0]);
                        temp.Add(prevMatrix[j][prevMatrix[1].Count - 2]);
                        temp.Add(prevMatrix[j][prevMatrix[1].Count - 1]);
                        break;
                    }
                }
                result.Add(temp);
            }

            return result;
        }
        //Виведення результатів
            public Dictionary<int, List<List<double>>> FullResult()
        {
            Dictionary<int, List<List<double>>> result = new Dictionary<int, List<List<double>>>();
            result.Add(0, Matrix);
            var table2 = firstTable(Matrix);
            result.Add(1, table2);
            var table3 = secondTable(Matrix);
            result.Add(2, table3);
            var table4 = thirdTable(Matrix);
            result.Add(3, table4);
            var table5 = fourthTable(Matrix);
            result.Add(4, table5);
            var table6 = fifthTable(Matrix, table5);
            result.Add(5, table6);
            var table7 =  lastTable(Matrix);
            result.Add(6, table7);
            var finalIcTable = IcTable(table7);
            result.Add(7, finalIcTable);
            return result;
        }

        }
 }
    
    

