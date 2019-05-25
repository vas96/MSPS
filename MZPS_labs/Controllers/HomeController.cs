using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using Microsoft.AspNetCore.Mvc;
using MZPS_labs.Models;

namespace MZPS_labs.Controllers
{
    public class HomeController : Controller
    {

        [HttpPost]
        public IActionResult FirstMethod(string[] arr)
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

        public IActionResult Lab5()
        {
            return View();
        }

        public IActionResult Lab6()
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
                new List<double>() {8.0, 5, 9, 7},
                new List<double>() {5.0, 9, 6, 5},
                new List<double>() {10.0, 6, 9, 6},
                new List<double>() {6.0, 5, 10, 7},
                new List<double>() {5.0, 5, 10, 4},
                new List<double>() {9.0, 9, 7, 10},
                new List<double>() {9.0, 5, 10, 5},
                new List<double>() {6.0, 5, 10, 7},
                new List<double>() {8.0, 6, 9, 6},
                new List<double>() {7.0, 8, 6, 10},
            };

            List<List<double>> matrix2 = new List<List<double>>()
            {
                new List<double>() {10.0, 9, 10, 8.05},
                new List<double>() {9.0, 8, 8, 7.5},
                new List<double>() {9.0, 7, 9, 6.10},
                new List<double>() {6.0, 5, 8, 7.7},
                new List<double>() {7.0, 5, 8, 6.05},
                new List<double>() {9.0, 7, 8, 7.85},
                new List<double>() {10.0, 9, 10, 7.35},
                new List<double>() {6.0, 8, 7, 5.55},
                new List<double>() {9.0, 7, 6, 7.85},
                new List<double>() {6.0, 5, 9, 4.3},
            };

            double[][] matrix3 = new double[][]
            {
                new[] {8.3, 8.8, 8.0, 7.1, 8.1},
                new[] {7.3, 9.2, 8.9, 8.1, 6.7},
                new[] {9.8, 9.0, 9.5, 9.9, 8.1},
                new[] {9.8, 8.4, 6.9, 6.3, 6.5},
                new[] {5.9, 7.6, 5.2, 8.6, 5.6},
                new[] {9.8, 8.4, 6.9, 6.3, 6.5},
                new[] {9.8, 7.1, 6.5, 9.0, 8.0},
                new[] {5.9, 7.6, 5.3, 8.6, 5.6},
                new[] {9.7, 8.4, 9.8, 9.6, 8.8},
            };

            Lab3 data = new Lab3(matrix, matrix2);

            List<double> Kj = new List<double>() {6, 5, 10, 7.0};
            List<double> Aj = new List<double>() {6, 5, 8, 7.7};

            var res = data.FullResult();

            return PartialView("_Lab3_example", res);
        }

        [HttpPost]
        public IActionResult Lab4_example()
        {
            List<List<double>> matrix = new List<List<double>>()
            {
                new List<double>() {34.53, 52.54, 42.61, 12.78, 22.02},
                new List<double>() {30.91, 52.90, 40.28, 13.80, 22.79},
                new List<double>() {33.65, 50.82, 42.39, 10.06, 22.26},
                new List<double>() {32.64, 54.20, 44.54, 12.89, 22.59},
                new List<double>() {34.04, 54.41, 42.42, 13.28, 21.87},
                new List<double>() {30.48, 54.31, 43.56, 10.30, 23.66},
                new List<double>() {32.37, 51.02, 43.55, 10.64, 20.16},
                new List<double>() {34.02, 50.61, 41.14, 12.76, 20.58},
                new List<double>() {34.27, 54.89, 44.87, 12.69, 20.86},
                new List<double>() {33.77, 52.13, 43.30, 10.98, 21.74},

                new List<double>() {35.0, 55.0, 45.0, 10.0, 20.0},
                new List<double>() {0.032, 0.201, 0.398, 0.110, 0.259},
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
                new List<double>() {24.72, 34.28, 10.17, 51.02, 43.20},
                new List<double>() {23.95, 33.14, 11.16, 54.34, 44.24},
                new List<double>() {22.20, 34.71, 12.49, 54.08, 41.59},
                new List<double>() {20.60, 31.06, 11.18, 53.71, 40.47},
                new List<double>() {23.91, 30.78, 13.30, 53.43, 41.91},
                new List<double>() {22.68, 33.76, 12.08, 52.13, 41.82},
                new List<double>() {24.74, 31.34, 12.33, 51.44, 43.97},
                new List<double>() {21.15, 31.84, 14.91, 52.75, 42.41},
                new List<double>() {20.01, 32.33, 13.22, 52.69, 44.98},
                new List<double>() {22.64, 30.96, 13.79, 52.22, 41.39},

                new List<double>() {25.0, 35.0, 15.0, 50.0, 40.0},
                new List<double>() {0.191, 0.147, 0.376, 0.165, 0.120},
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
                new List<double>() {8.3, 8.8, 8.0, 7.1, 8.1},
                new List<double>() {7.3, 9.2, 8.9, 8.1, 6.7},
                new List<double>() {9.8, 9.0, 9.5, 9.9, 8.1},
                new List<double>() {9.8, 8.4, 6.9, 6.3, 6.5},
                new List<double>() {9.8, 7.1, 6.5, 9.0, 8.0},
                new List<double>() {5.9, 7.6, 5.2, 8.6, 5.6},
                new List<double>() {9.8, 8.4, 6.9, 6.3, 6.5},
                new List<double>() {9.8, 7.1, 6.5, 9.0, 8.0},
                new List<double>() {5.9, 7.6, 5.3, 8.6, 5.6},
                new List<double>() {9.7, 8.4, 9.8, 9.6, 8.8},
            };

            List<List<double>> matrix2 = new List<List<double>>()
            {
                new List<double>() {5.0, 7, 5, 5, 7},
                new List<double>() {6.0, 9, 9, 7, 8},
                new List<double>() {5.0, 8, 5, 5, 5},
                new List<double>() {7.0, 9, 10, 8, 9},
                new List<double>() {6.0, 8, 10, 6, 8},
                new List<double>() {5.0, 5, 7, 6, 7},
                new List<double>() {8.0, 8, 8, 7, 7},
                new List<double>() {7.0, 8, 7, 6, 7},
                new List<double>() {8.0, 7, 10, 8, 9},
                new List<double>() {9.0, 10, 10, 8, 9},
            };

            Lab3 data = new Lab3(matrix, matrix2);

            var res = data.FullResult();

            return PartialView("_Lab_3MyVariant", res);
        }

        public IActionResult Lab5_example()
        {
            Lab5 data = new Lab5();
            var res = data.FullResult();

            return PartialView("_Lab5_example", res);
        }
        public IActionResult Lab6_example()
        {
            Lab6 data = new Lab6();
            var res = data.FullResult();

            return PartialView("_Lab6_example", res);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
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

        private List<double> firstRow2(List<double> Arr, double last)
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
            List<double> temp3 = new List<double>() {99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99};
            double[] finalCoef = {1.1, 99};
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

                temp3.Add(Math.Round(tmplamda, 4));

                double[] tempStr = new double[] {i + 1,};
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());

            }

            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n] - A[i]), 4));

                if (i == 0)
                {
                    finalCoef[0] = (double) i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double) i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }

            result.Add(finalResult.ToArray());


            result.Add(finalCoef);
            double[] experts = {(double) n};
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
                temp.Add(Math.Round((Math.Pow(Arr[i] - avg, 2) * (n + 1)) / q, 4));
            }

            return temp;
        }

        private List<double> secondRow(List<double> Arr, double avg)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round(Math.Exp(-((Math.Pow(Arr[i] - avg, 2) * (n + 1)) / q)), 4));
            }

            temp.Add(Math.Round((temp.Sum()), 4));

            return temp;
        }

        private List<double> thirdRow(List<double> Arr, double avg, double prevSum)
        {
            List<double> temp = new List<double>();
            int i = 0;
            for (i = 0; i < n; i++)
            {
                temp.Add(Math.Round(Arr[i] * Math.Exp(-((Math.Pow(Arr[i] - avg, 2) * (n + 1)) / q)), 4));
            }

            temp.Add(Math.Round((temp.Sum()), 4));
            temp.Add(Math.Round((temp.Last() / prevSum), 4));
            temp.Add(Math.Round((avg - temp.Last()), 4));
            return temp;
        }

        public List<double[]> allData()
        {
            List<double[]> result = new List<double[]>();

            List<double> temp1;
            List<double> temp2;
            List<double> temp3 = new List<double>() {1.1};
            double[] finalCoef = {1.1, 99};

            for (int i = 0;; i++)
            {
                if (temp3.Last() <= 0.005)
                {
                    break;
                }

                if (i == 0)
                {
                    temp1 = firstRow(A, A[n + 1]);
                    temp2 = secondRow(A, A[n + 1]);
                    temp3 = thirdRow(A, A[n + 1], temp2.Last());
                }
                else
                {
                    temp1 = firstRow(A, temp3[n + 1]);
                    temp2 = secondRow(A, temp3[n + 1]);
                    temp3 = thirdRow(A, temp3[n + 1], temp2.Last());
                }


                double[] tempStr = new double[] {i + 1,};
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());
            }

            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n + 1] - A[i]), 4));
                if (i == 0)
                {
                    finalCoef[0] = (double) i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double) i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }

            result.Add(finalResult.ToArray());
            result.Add(finalCoef);
            double[] experts = {(double) n};
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
                temp.Add(Math.Round(1 + Arr[i] * Math.Pow(Xcl - Arr[i], 2), 4));
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
            List<double> temp3 = new List<double>() {99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99};
            double[] finalCoef = {1.1, 99};
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

                temp3.Add(Math.Round(tmplamda, 4));

                double[] tempStr = new double[] {i + 1,};
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());

            }

            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n] - A[i]), 4));

                if (i == 0)
                {
                    finalCoef[0] = (double) i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double) i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }

            result.Add(finalResult.ToArray());


            result.Add(finalCoef);
            double[] experts = {(double) n};
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
                temp.Add(Math.Round(Math.Pow((Math.Abs(Xcl - Arr[i])), 2), 4));
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
                temp.Add(Math.Round(Math.Pow((Math.Abs(Arr[i] - last)), 2), 4));
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
            List<double> temp3 = new List<double>() {99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99, 99.99};
            double[] finalCoef = {1.1, 99};
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

                double[] tempStr = new double[] {i + 1,};
                result.Add(tempStr);
                result.Add(temp1.ToArray());
                result.Add(temp2.ToArray());
                result.Add(temp3.ToArray());

            }

            List<double> finalResult = new List<double>();
            for (int i = 0; i < n; i++)
            {
                finalResult.Add(Math.Round(Math.Abs(temp3[n] - A[i]), 4));

                if (i == 0)
                {
                    finalCoef[0] = (double) i + 1;
                    finalCoef[1] = finalResult[i];
                }
                else
                {
                    if ((finalResult[i] < finalCoef[1]))
                    {
                        finalCoef[0] = (double) i + 1;
                        finalCoef[1] = finalResult[i];
                    }
                }
            }

            result.Add(finalResult.ToArray());


            result.Add(finalCoef);
            double[] experts = {(double) n};
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
            new[] {8.0, 5, 9, 7},
            new[] {5.0, 9, 6, 5},
            new[] {10.0, 6, 9, 6},
            new[] {6.0, 5, 10, 7},
            new[] {5.0, 5, 10, 4},
            new[] {9.0, 9, 7, 10},
            new[] {9.0, 7, 6, 10},
            new[] {6.0, 5, 10, 5},
            new[] {8.0, 6, 9, 6},
            new[] {7.0, 8, 6, 10}
        };

        private double[][] matrix2 = new double[][]
        {
            new[] {10.0, 9, 10, 8.05},
            new[] {9.0, 8, 8, 7.50},
            new[] {9, 7, 9, 6.10},
            new[] {6, 5, 8, 7.70},
            new[] {7, 5, 8, 6.05},
            new[] {9, 7, 8, 7.85},
            new[] {10, 9, 10, 7.35},
            new[] {6, 8, 7, 5.55},
            new[] {9, 7, 6, 7.85},
            new[] {6, 5, 9, 4.30}
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
                    tempMidleVal +=
                        Math.Round(
                            (double.Parse((sumCoefTemp[k]), System.Globalization.NumberStyles.AllowDecimalPoint) *
                             Coefs[k]) / Coefs.Sum(), 4);
                }

                tempMidGradesSum += tempMidleVal;

                sumCoefTemp.Add(tempMidleVal.ToString());
                //double prod = Coefs.Aggregate(1.0, (a, b) => a * b);
                var averagedGrades = Math.Round((tempSum) / Coefs.Sum() / matrix[i].Average(), 3);
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
            averageGradesList.Add((Math.Round((tempMidGradesSum / 10 / 7.75), 2).ToString()));
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
                var tmp = 0.0; //first angl 0
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
                        double angl = ((double.Parse(forAngles[i][j])) / double.Parse(forAngles[i].Last())) *
                                      (180.0 / Math.PI);
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
                List<string> temp = new List<string>();

                for (int j = 0; j < firstData[1].Count; j++)
                {
                    temp.Add($"{firstData[i][j]}/{secondData[i][j]}");
                }

                temp.Add((firstData[i].Sum() / firstData[i].Count).ToString() + "/" +
                         (secondData[i].Sum() / secondData[i].Count).ToString());
                sumAvg += firstData[i].Sum() / firstData[i].Count;
                sumAvg2 += secondData[i].Sum() / secondData[i].Count;
                firstTable.Add(temp);
            }

            var tempListSum = new List<string>();
            for (int i = 0; i < firstData[i].Count; i++)
            {
                var tempSum = 0.0;
                var avgSum = 0.0;
                for (int j = 0; j < firstData.Count; j++)
                {
                    tempSum += firstData[j][i];
                    avgSum += secondData[j][i];
                }

                tempListSum.Add(Math.Round((tempSum / firstData.Count), 3).ToString() + "/" +
                                Math.Round((avgSum / firstData.Count), 3).ToString());
            }

            tempListSum.Add((sumAvg / firstData.Count).ToString() + "/" + (sumAvg2 / secondData.Count).ToString());
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
                    temp.Add(Math.Round(fourthRowArr[i] * Aj[i], 3));
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
                        temp.Add(Math.Round(1.0, 3));
                        ;
                    }
                    else
                    {
                        temp.Add(Math.Round(1 / Arr[i], 3));
                    }

                }

                temp.Add(Math.Round(temp.Sum(), 3));
                return temp;
            }

            List<double> fourthRow(List<double> secondArr, double thirdSum, double a, double aPrew)
            {
                List<double> temp = new List<double>();
                for (int i = 0; i < secondArr.Count - 1; i++)
                {
                    if (secondArr[i] == 0)
                    {
                        temp.Add(Math.Round(Kj.Last() / 1 / thirdSum, 3));
                    }
                    else
                    {
                        temp.Add(Math.Round(Kj.Last() / secondArr[i] / thirdSum, 3));
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
                temp.Add(Math.Round(temp.Last() / m, 3));
                return temp;
            }

            List<double> resultRow2(List<double> fourthArr, double a)
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
                temp.Add(Math.Round(Math.Abs(a - Aj.Last()), 3));
                return temp;
            }

            List<double> row1 = new List<double>();
            List<double> row2 = new List<double>();
            List<double> row3 = new List<double>();
            List<double> row4 = new List<double>();

            for (int i = 0;; i++)
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
                result.Add(i + 1, tempTable);
            }

            var newTable = ConcatTable(newMatrix, matrix2Copied);
            result.Add(i + 1, newTable);
            return result;

        }
    }

    //lab4
    public class Lab4
    {
        List<List<double>> Matrix { get; set; }

        public Lab4(List<List<double>> matrix)
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
                for (int j = 0; j < matrix.Count - 2; j++)
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
                        if (i < 3)
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
        public List<List<double>> firstTable(List<List<double>> InitialMatrix)
        {
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
                double Ps = temp[1] * temp[2] * temp[3];
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
                    if (j < 3)
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
                double n = h * prevMatrix[i][prevMatrix[i].Count - 2];
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
                        temp.Add(Math.Round(
                            Math.Pow(InitialMatrix[i][j], 2) /
                            (Matrix[Matrix.Count - 3][j] * Matrix[Matrix.Count - 2][j]), 3));
                    }
                    else
                    {
                        temp.Add(Math.Round(
                            (Matrix[Matrix.Count - 3][j] * Matrix[Matrix.Count - 2][j]) /
                            Math.Pow(InitialMatrix[i][j], 2), 3));
                    }
                }

                double Pd = temp.Last() * temp[temp.Count - 2];
                double Ps = temp[1] * temp[2] * temp[3];
                double n = (Math.Round(Math.Pow((Ps * Pd), 0.2), 3));
                double n1 = 1 / n;
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

            for (int i = 0; i < prevMatrix.Count - 2; i++)
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
                    if (prevMatrix[j][n.Count - 2] == (n[i]))
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
            var table7 = lastTable(Matrix);
            result.Add(6, table7);
            var finalIcTable = IcTable(table7);
            result.Add(7, finalIcTable);
            return result;
        }

    }

    //lab5
    public class Lab5
    {
        //private double _ppc = 0;
        //private double Pnet = 0;
        //private double _pp = 0;
        //private double Pos = 0;
        //private double Pdb = 0;
        //private double Pe = 0;
        //private double Prg = 0;
        private const int RoundNumber = 5;

        private static readonly List<List<double>> InitialData = new List<List<double>>()
        {
            new List<double>()
            {
                2.0, 2, 32, 0.4, 3.25, 12.7, 500,
                24, 4, 1000, 32,
                600, 9, 25, 0.128,
                32, 4, 100, 1, 0.1,
                32, 0.5, 5, 8, 32, 17,
                64, 152, 5, 0.1,
                64, 0.1, 5, 10, 3, 1, 100,
                1, 0.10, 5, 1, 0.5, 5
            },
            new List<double>()
            {
                2.0, 2, 32, 0.3, 4, 11.4, 320,
                8, 2, 100, 32,
                1200, 13, 32, 0.064,
                64, 16, 10000, 2, 0.05,
                64, 0.9, 20, 16, 47, 5,
                64, 171, 22, 0.4,
                32, 0.2, 10, 15, 5, 1, 111,
                2, 0.40, 15.3, 3.1, 1.3, 9
            },
            //new List<double>(){1.7,4,64, 0.6,6,17.2,340,
            //12,8,400,64,
            //2400,12,48,0.256,
            //32,32,4096,1,0.1,
            //64,11,22,13,42,7,
            //32,144,17,0.2,
            //64,0.5,15,20,7,3,179},
            new List<double>()
            {
                2.0, 2, 32, 0.5, 8, 8, 470,
                16, 12, 600, 64,
                1960, 15, 24, 0.512,
                64, 32, 6000, 1, 0.1,
                32, 0.7, 17, 13, 45, 9,
                32, 127, 10, 0.3,
                32, 0.7, 20, 25, 11, 4, 142,
                3, 1, 20, 5, 3, 15
            }
        };

        public Lab5()
        {
            double GetRandomNumber(double minimum, double maximum)
            {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
            }

            for (int i = 0; i < InitialData[1].Count; i++)
            {
                InitialData[1][i] = Math.Round(GetRandomNumber(InitialData[0][i], InitialData[2][i]), 1);
            }
        }

        private static IList<List<double>> NTP_PC(IList<List<double>> matrix)
        {
            //result List
            var calculations = new List<List<double>>();
            //variables
            const int elIndex = 1;
            var sum = 0.0;

            //part of formula that returns a lot of times
            double PartFormula(int firstListIndex, int secondListIndex)
            {
                return Math.Round(
                    (matrix[elIndex][firstListIndex] / matrix.Select(l => l[firstListIndex]).Max()) *
                    (matrix[elIndex][secondListIndex] / matrix.Select(l => l[secondListIndex]).Max()), RoundNumber);
            }

            double PartFormula2(int index)
            {
                return Math.Round((matrix[elIndex][index] / matrix.Select(l => l[index]).Max()), RoundNumber);
            }

            //Ppc
            List<double> ppcList = new List<double> {PartFormula(0, 1), PartFormula(3, 4), PartFormula(5, 6)};
            //Ppc =
            //     ((matrix[elIndex][0] / matrix.Select(l => l[0]).Max()) * (matrix[elIndex][1] / matrix.Select(l => l[1]).Max()) +
            //       (matrix[elIndex][3] / matrix.Select(l => l[3]).Max()) * (matrix[elIndex][4] / matrix.Select(l => l[4]).Max()) +
            //       (matrix[elIndex][5] / matrix.Select(l => l[5]).Max()) * (matrix[elIndex][6] / matrix.Select(l => l[6]).Max())) *
            //       0.33 *
            //       (matrix[elIndex][2] / matrix.Select(l => l[2]).Max());

            sum = (ppcList.Aggregate((a, x) => a + x)) * 0.33;
            ppcList.Add(ppcList.Count);
            ppcList.Add(Math.Round((matrix[elIndex][2] / matrix.Select(l => l[2]).Max()), 5));
            ppcList.Add(Math.Round(sum * (matrix[elIndex][2] / matrix.Select(l => l[2]).Max()), 5));
            // PpcList.Add(Math.Round(sum * ), 5));
            //Pnet =
            //    ((matrix[elIndex][7] / matrix.Select(l => l[7]).Max()) + (matrix[elIndex][8] / matrix.Select(l => l[8]).Max())) *
            //    0.5 *
            //    (matrix[elIndex][9] / matrix.Select(l => l[9]).Max()) * (matrix[elIndex][10] / matrix.Select(l => l[10]).Max());
            var pnetList = new List<double>
            {
                (matrix[elIndex][7] / matrix.Select(l => l[7]).Max()),
                (matrix[elIndex][8] / matrix.Select(l => l[8]).Max())
            };
            sum = (pnetList.Aggregate((a, x) => a + x)) * 0.5;
            pnetList.Add(pnetList.Count);
            pnetList.Add(Math.Round(
                (matrix[elIndex][9] / matrix.Select(l => l[9]).Max()) *
                (matrix[elIndex][10] / matrix.Select(l => l[10]).Max()), 5));
            pnetList.Add(Math.Round(
                sum * (matrix[elIndex][9] / matrix.Select(l => l[9]).Max()) *
                (matrix[elIndex][10] / matrix.Select(l => l[10]).Max()), 5));
            // temp.Add(Math.Round(Pnet, 5));
            //Pp =
            //    ((matrix[el][12] / matrix.Select(l => l[12]).Max()) + (matrix[el][13] / matrix.Select(l => l[13]).Max())) *
            //    0.5 *
            //    (matrix[el][14] / matrix.Select(l => l[14]).Max()) * (matrix[el][11] / matrix.Select(l => l[11]).Max());
            var ppList = new List<double> {PartFormula2(12), PartFormula2(13)};
            sum = (ppList.Aggregate((a, x) => a + x)) * 0.5;
            ppList.Add(ppList.Count);
            ppList.Add(Math.Round(PartFormula(14, 11), RoundNumber));
            ppList.Add(Math.Round(sum * ppList.Last(), RoundNumber));

            //temp.Add(Math.Round(Pp, 5));
            //Pos =
            //    ((matrix[el][16] / matrix.Select(l => l[16]).Max()) + (matrix[el][17] / matrix.Select(l => l[17]).Max()) +
            //    (matrix[el][18] / matrix.Select(l => l[18]).Max())) *
            //    0.333 *
            //    (matrix[el][15] / matrix.Select(l => l[15]).Max()) * (matrix[el][19] / matrix.Select(l => l[19]).Max());
            //temp.Add(Math.Round(Pos, 5));
            var posList = new List<double> {PartFormula2(16), PartFormula2(17), PartFormula2(18)};
            sum = (posList.Aggregate((a, x) => a + x)) * 0.333;
            posList.Add(posList.Count);
            posList.Add(Math.Round(PartFormula(15, 19), RoundNumber));
            posList.Add(Math.Round(sum * posList.Last(), RoundNumber));

            //Pdb =
            //    ((matrix[el][24] / matrix.Select(l => l[24]).Max()) + (matrix[el][21] / matrix.Select(l => l[21]).Max()) +
            //    (matrix[el][22] / matrix.Select(l => l[22]).Max()) + (matrix[el][23] / matrix.Select(l => l[23]).Max())) *
            //    0.25 *
            //    (matrix[el][21] / matrix.Select(l => l[21]).Max()) * (matrix[el][25] / matrix.Select(l => l[25]).Max());
            //temp.Add(Math.Round(Pdb, 5));
            var pdbList = new List<double> {PartFormula2(24), PartFormula2(21), PartFormula2(22), PartFormula2(25)};
            sum = (pdbList.Aggregate((a, x) => a + x)) * 0.25;
            pdbList.Add(posList.Count);
            pdbList.Add(Math.Round(PartFormula(21, 25), RoundNumber));
            pdbList.Add(Math.Round(sum * pdbList.Last(), RoundNumber));
            //Pe =
            //    ((matrix[el][27] / matrix.Select(l => l[27]).Max()) + (matrix[el][28] / matrix.Select(l => l[28]).Max()) +
            //    (matrix[el][29] / matrix.Select(l => l[29]).Max())) *
            //    0.333 *
            //    (matrix[el][26] / matrix.Select(l => l[26]).Max()) * (matrix[el][19] / matrix.Select(l => l[19]).Max());
            //temp.Add(Math.Round(Pe, 5));
            var peList = new List<double> {PartFormula2(16), PartFormula2(17), PartFormula2(18)};
            sum = (peList.Aggregate((a, x) => a + x)) * 0.333;
            peList.Add(peList.Count);
            peList.Add(Math.Round(PartFormula(15, 19), RoundNumber));
            peList.Add(Math.Round(sum * peList.Last(), RoundNumber));
            //Prg =
            //      ((matrix[el][31] / matrix.Select(l => l[31]).Max()) + (matrix[el][32] / matrix.Select(l => l[32]).Max()) +
            //      (matrix[el][33] / matrix.Select(l => l[33]).Max()) + (matrix[el][34] / matrix.Select(l => l[34]).Max()) +
            //      (matrix[el][35] / matrix.Select(l => l[35]).Max())) *
            //      0.25 *
            //      (matrix[el][30] / matrix.Select(l => l[30]).Max()) * (matrix[el][36] / matrix.Select(l => l[36]).Max());
            //temp.Add(Math.Round(Prg, 5));
            var prgList = new List<double>
                {PartFormula2(31), PartFormula2(32), PartFormula2(33), PartFormula2(34), PartFormula2(35)};
            sum = (prgList.Aggregate((a, x) => a + x)) * 0.20;
            prgList.Add(prgList.Count);
            prgList.Add(Math.Round(PartFormula(30, 36), RoundNumber));
            prgList.Add(Math.Round(sum * prgList.Last(), RoundNumber));

            var pmList = new List<double> {PartFormula2(40), PartFormula2(41), PartFormula2(42)};
            sum = (pmList.Aggregate((a, x) => a + x)) * 0.333;
            pmList.Add(pmList.Count);
            pmList.Add(Math.Round(PartFormula(37, 38) * PartFormula2(39), RoundNumber));
            pmList.Add(Math.Round(sum * pmList.Last(), RoundNumber));

            calculations.AddRange(new List<List<double>>()
                {ppcList, pnetList, ppList, posList, pdbList, peList, prgList, pmList});

            return calculations;
        }

        private static IList<List<double>> NTP_PC_addTable(IList<List<double>> matrix)
        {
            var calculations = new List<List<double>>();
            foreach (var t in matrix)
            {
                var tempData = new List<double>();
                for (var j = 0; j < t.Count - 3; j++)
                {
                    if (t[j] > 0.0)
                    {
                        tempData.Add(Math.Round(1 / t[t.Count - 3] * t[j] * t[t.Count - 2], RoundNumber));
                    }
                }

                tempData.Add(tempData.Sum());
                calculations.Add(tempData);
            }

            return calculations;
        }

        private static IList<List<double>> VectorsList(IList<List<double>> matrix)
        {
            var prs = new List<double>();
            prs.AddRange(matrix[0].Take(matrix[0].Count - 1).Concat(matrix[1].Take(matrix[1].Count - 1))
                .Concat(matrix[2].Take(matrix[2].Count - 1)));

            var pss = new List<double>();
            pss.AddRange(matrix[3].Take(matrix[3].Count - 1).Concat(matrix[4].Take(matrix[4].Count - 1))
                .Concat(matrix[5].Take(matrix[5].Count - 1)).Concat(matrix[6].Take(matrix[6].Count - 1)));

            var pms = new List<double>();
            pms.AddRange(matrix[7].Take(matrix[7].Count - 1));

            var result = new List<List<double>> {prs, pss, pms};

            return result;
        }

        //Zeq,Heq,Zus,Hus
        private static IList<List<double>> ZeqHeqList(List<double> softwareParam, List<double> otherParam)
        {
            if (softwareParam == null) throw new ArgumentNullException(nameof(softwareParam));
            if (otherParam == null) throw new ArgumentNullException(nameof(otherParam));

            var result = new List<List<double>> {otherParam};
            foreach (var software in softwareParam)
            {
                var tempList = new List<double> {software};
                for (var j = 0; j < otherParam.Count; j++)
                {
                    tempList.Add(software * otherParam[j]);
                }

                result.Add(tempList);
            }

            return result;
        }

        private static IList<List<double>> CreateRandomMatrix(int rowCount, int colCount)
        {
            var result = new List<List<double>> { };

            const int min = 0;
            const int max = 2;

            for (var i = 0; i < rowCount; i++)
            {
                var randNum = new Random();
                var randomList = Enumerable
                    .Repeat(0, colCount)
                    .Select(j => Convert.ToDouble(randNum.Next(min, max)))
                    .ToList();
                result.Add(randomList);
            }

            return result;
        }

        private static IList<List<double>> DivideTables(
            IList<List<double>> matrixIncidence,
            IList<List<double>> matrixOne,
            IList<List<double>> matrixTwo)
        {
            var result = new List<List<double>> { };

            for (var i = 0; i < matrixIncidence.Count; i++)
            {
                var tempList = new List<double>();
                for (var j = 0; j < matrixIncidence[i].Count; j++)
                {
                    if (matrixIncidence[i][j] == 1)
                    {
                        tempList.Add(matrixOne[i][j] / matrixTwo[i][j]);
                    }
                    else
                    {
                        tempList.Add(matrixIncidence[i][j]);
                    }
                }

                result.Add(tempList);
            }

            return result;
        }

        public Dictionary<int, IList<List<double>>> FullResult()
        {

            var result = new Dictionary<int, IList<List<double>>> {{0, InitialData}};
            var ntpPCtable = NTP_PC(InitialData);
            result.Add(1, ntpPCtable);
            var ntpPCtableadd = NTP_PC_addTable(ntpPCtable);
            result.Add(2, ntpPCtableadd);
            var vectors = VectorsList(ntpPCtableadd);
            result.Add(3, vectors);
            var technicalParametersListMax = new List<double>()
            {
                InitialData.Select(l => l[0]).Max(), InitialData.Select(l => l[3]).Max(),
                InitialData.Select(l => l[6]).Max(), InitialData.Select(l => l[7]).Max(),
                InitialData.Select(l => l[8]).Max(), InitialData.Select(l => l[12]).Max(),
                InitialData.Select(l => l[13]).Max()
            };
            var softwareParametersListMax = new List<double>()
            {
                InitialData.Select(l => l[16]).Max(), InitialData.Select(l => l[17]).Max(),
                InitialData.Select(l => l[18]).Max(), InitialData.Select(l => l[22]).Max(),
                InitialData.Select(l => l[23]).Max(), InitialData.Select(l => l[24]).Max(),
                InitialData.Select(l => l[25]).Max(), InitialData.Select(l => l[27]).Max(),
                InitialData.Select(l => l[28]).Max(), InitialData.Select(l => l[29]).Max(),
                InitialData.Select(l => l[31]).Max(), InitialData.Select(l => l[32]).Max(),
                InitialData.Select(l => l[33]).Max(), InitialData.Select(l => l[34]).Max(),
                InitialData.Select(l => l[35]).Max()
            };
            var mathParametersListMax = new List<double>()
            {
                InitialData.Select(l => l[40]).Max(), InitialData.Select(l => l[41]).Max(),
                InitialData.Select(l => l[42]).Max(),
            };

            var technicalParametersListAvg = new List<double>()
            {
                InitialData.Select(l => l[0]).Average(), InitialData.Select(l => l[3]).Average(),
                InitialData.Select(l => l[6]).Average(), InitialData.Select(l => l[7]).Average(),
                InitialData.Select(l => l[8]).Average(), InitialData.Select(l => l[12]).Average(),
                InitialData.Select(l => l[13]).Average()
            };
            var softwareParametersListAvg = new List<double>()
            {
                InitialData.Select(l => l[16]).Average(), InitialData.Select(l => l[17]).Average(),
                InitialData.Select(l => l[18]).Average(), InitialData.Select(l => l[22]).Average(),
                InitialData.Select(l => l[23]).Average(), InitialData.Select(l => l[24]).Average(),
                InitialData.Select(l => l[25]).Average(), InitialData.Select(l => l[27]).Average(),
                InitialData.Select(l => l[28]).Average(), InitialData.Select(l => l[29]).Average(),
                InitialData.Select(l => l[31]).Average(), InitialData.Select(l => l[32]).Average(),
                InitialData.Select(l => l[33]).Average(), InitialData.Select(l => l[34]).Average(),
                InitialData.Select(l => l[35]).Average()
            };
            var mathParametersListAvg = new List<double>()
            {
                InitialData.Select(l => l[40]).Average(), InitialData.Select(l => l[41]).Average(),
                InitialData.Select(l => l[42]).Average(),
            };

            var heq = ZeqHeqList(softwareParametersListMax, mathParametersListMax);
            var zeq = ZeqHeqList(softwareParametersListMax, technicalParametersListMax);
            var zus = ZeqHeqList(softwareParametersListAvg, mathParametersListAvg);
            var hus = ZeqHeqList(softwareParametersListAvg, technicalParametersListAvg);

            result.Add(4, zeq);
            result.Add(5, heq);
            result.Add(6, zus);
            result.Add(7, hus);

            var matrixIncidenceTzpz = CreateRandomMatrix(15, 7);
            var matrixIncidenceMzpz = CreateRandomMatrix(15, 3);

            result.Add(8, matrixIncidenceTzpz);
            result.Add(9, matrixIncidenceMzpz);

            var divideMatrixTzpz = DivideTables(matrixIncidenceTzpz, zeq, hus);
            var divideMatrixMzpz = DivideTables(matrixIncidenceMzpz, heq, zus);

            result.Add(10, divideMatrixTzpz);
            result.Add(11, divideMatrixMzpz);

            double[][] MultipleMatrix(IList<List<double>> a, IList<List<double>> b)
            {
                double[][] c = new double[0][];
                if (a.Count == b[0].Count)
                {
                    c = new double[a[0].Count][];
                    for (int i = 0; i < c.Length; i++)
                    {
                        c[i] = new double[b.Count];
                        for (int j = 0; j < c[i].Length; j++)
                        {
                            c[i][j] = 0;
                            for (int k = 0; k < a.Count; k++) // OR k<b.GetLength(0)
                                c[i][j] = c[i][j] + a[k][i] * b[j][k];
                        }
                    }
                }

                return c;
            }

            double[][] MultipleMatrix2(IList<List<double>> a, IList<List<double>> b)
            {
                double[][] c = new double[0][];
                if (a.Count == b[0].Count)
                {
                    c = new double[a[0].Count][];
                    for (int i = 0; i < c.GetLength(0); i++)
                    {
                        for (int j = 0; j < c.GetLength(1); j++)
                        {
                            c[i][j] = 0;
                            for (int k = 0; k < a[1].Count; k++) // OR k<b.GetLength(0)
                                c[i][j] = c[i][j] + a[i][k] * b[k][j];
                        }
                    }
                }

                return c;
            }

            IList<List<double>> TransparentMatrix(IList<List<double>> matrix)
            {
                var resultMatrix = new List<List<double>> { };

                for (var j = 0; j < matrix[1].Count; j++)
                {
                    //var tempList = new List<double>();
                    var temp = Enumerable.Range(0, matrix.Count)
                        .Select(x => matrix[x][j])
                        .ToList();
                    resultMatrix.Add(temp);
                }

                return resultMatrix;
            }

            IList<List<double>> TransparentMatrixReverse(IList<List<double>> matrix)
            {
                var resultMatrix = new List<List<double>> { };

                for (var j = 0; j < matrix[0].Count; j++)
                {
                    var tempList = matrix.Select(t => t[j]).ToList();
                    resultMatrix.Add(tempList);
                }

                return resultMatrix;
            }

            var tempVector1 = new List<List<double>> {vectors[0]};
            var rtsssPrs = MultipleMatrix(TransparentMatrix(divideMatrixTzpz), tempVector1);
            result.Add(12, rtsssPrs.Select(a => a.ToList()).ToList());

            var tempVector2 = new List<List<double>> {vectors[2]};
            var rtsmsPrs = MultipleMatrix(TransparentMatrix(divideMatrixMzpz), tempVector2);
            result.Add(13, rtsmsPrs.Select(a => a.ToList()).ToList());

            var yuy = Enumerable.Range(0, divideMatrixMzpz.Count)
                .Select(x => divideMatrixMzpz[x][0])
                .ToList();

            var multiplyRes = Enumerable.Range(0, rtsmsPrs.Length).Select(x => rtsmsPrs[x][0] * rtsssPrs[x][0]).ToList();
            var multiplyResTemp = new List<List<double>> {multiplyRes};
            result.Add(14, multiplyResTemp);

            //var multiplyResTempTr = Enumerable.Range(0, multiplyResTemp[0].Count)
            //    .Select(x => multiplyResTemp[0][x]).ToList()
            //    .ToList();

            var tempVector3 = new List<List<double>> { vectors[1] };

            //var tempVector3Temp = Enumerable.Range(0, tempVector3[0].Count)
            //    .Select(x => tempVector3[0][x]).ToList()
            //    .ToList();
            //var test = TransparentMatrixReverse(multiplyResTemp);
            //var test2 = TransparentMatrixReverse(tempVector3);
            var lastOne = MultipleMatrix(TransparentMatrixReverse(multiplyResTemp), tempVector3);
            result.Add(15, lastOne.Select(a => a.ToList()).ToList());

            List<double> tempParametrs = new List<double>();
            var firstParam = Math.Sqrt(Enumerable.Range(0, ntpPCtable.Count)
                .Select(x => ntpPCtable[x][ntpPCtable[x].Count-1]).ToList().Aggregate((a, x) => a + x));
            var secondParam = Math.Sqrt(divideMatrixTzpz.SelectMany(x => x).ToList().Aggregate((a, x) => a + x));
            var thirdaram = Math.Sqrt(divideMatrixMzpz.SelectMany(x => x).ToList().Aggregate((a, x) => a + x));

            tempParametrs.Add(firstParam);
            tempParametrs.Add(secondParam);
            tempParametrs.Add(thirdaram);

            //  sum = (pdbList.Aggregate((a, x) => a + x)) * 0.25;
            var parametrsList = new List<List<double>> {tempParametrs};
            result.Add(16, parametrsList);
            return result;

        }
    }

    public class Lab6
    {
        private static List<double> nList = new List<double>() { 0.1, 0.05 };
        private static List<double> bList = new List<double>() { 15.0, 2.00 };
        private static List<double> aList = new List<double>() { 2, 1.0 };

        private static List<double> lamdaList = new List<double>() { 0.1, 0.005 };
        private static List<double> qList = new List<double>() { 0.1, 0.005 };
        private static double t = -1.49;
        private static double A = 1.11;

        private static List<double> kList = new List<double>() { 1, 2, 3, 4, 5, };

        private static List<double> lList = new List<double>() { 3, 2.0 };

        private static List<double> c1List = new List<double>() { 1.5, 0.5 };
        private static List<double> c2List = new List<double>() { 1.1, 0.4 };
        private static List<double> c3List = new List<double>() { 0.7, 0.3 };
        private static List<double> c4List = new List<double>() { 0.5, 0.2 };
        private static List<double> c5List = new List<double>() { 0.2, 0.1 };

        private static List<double> ExptC3List = new List<double>() { 0.7, 0.9 };
        private static List<double> ExptC4List = new List<double>() { 0.6, 0.5 };

        private static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public Lab6()
        {

        }

        private static IList<List<double>> CreateMatrix()
        {
            var result = new List<List<double>>();

            for (int i = 0; i < 25; i++)
            {
                var tempList = new List<double>();
                //l
                tempList.Add(Math.Round((lList[0] + lList[1]) * GetRandomNumber(0.1, 1.7), 0));
                //i
                tempList.Add(i+1);
                //r
                tempList.Add(Math.Round((nList[0] + nList[1]) * GetRandomNumber(0.1, 1.7), 0));
                //B
                tempList.Add(Math.Round((bList[0] + bList[1]) * GetRandomNumber(0.1, 1.7), 0));
                //C
                tempList.Add(Math.Round((aList[0] + aList[1]) * GetRandomNumber(0.1, 1.7), 2));
                //S_1
                tempList.Add(Math.Round((tempList[tempList.Count - 2] - A * tempList.Last()) / Math.Pow((1 + tempList[2]), tempList[1]) * GetRandomNumber(0.1, 1.7), 2));
                //C_1
                tempList.Add(Math.Round((kList[0] <= tempList[0] ? (c1List[0] + c1List[1]) : 0) * GetRandomNumber(0.1, 2.7), 2));
                //C_2
                tempList.Add(Math.Round((kList[1] <= tempList[0] ? (c2List[0] + c2List[1]) : 0) * GetRandomNumber(0.1, 2.7), 2));
                //C_3
                tempList.Add(Math.Round((kList[2] <= tempList[0] ? (c3List[0] + c3List[1]) : 0) * GetRandomNumber(0.1, 2.7), 2));
                //C_4
                tempList.Add(Math.Round((kList[3] <= tempList[0] ? (c4List[0] + c4List[1]) : 0) * GetRandomNumber(0.1, 2.7), 2));
                //C_5
                tempList.Add(Math.Round((kList[4] <= tempList[0] ? (c5List[0] + c5List[1]) : 0) * GetRandomNumber(0.1, 2.7), 2));
                //sum C
                tempList.Add(Math.Round(tempList.Skip(tempList.Count - 5).Sum(), 2));
                //S_2
                tempList.Add(Math.Round((tempList.Last()) / Math.Pow((1 + tempList[2]), tempList[1]), 2));
                //Exp(tCi)_1
                tempList.Add(Math.Round((kList[0] <= tempList[0] ? (Math.Exp(t * tempList[6])) : 0) * GetRandomNumber(0.1, 2.7), 3));
                //Exp(tCi)_2
                tempList.Add(Math.Round((kList[1] <= tempList[0] ? (Math.Exp(t * tempList[7])) : 0) * GetRandomNumber(0.1, 2.7), 3));
                //Exp(tCi)_3
                tempList.Add(Math.Round((kList[2] <= tempList[0] ? (Math.Exp(t * tempList[8])) : 0) * GetRandomNumber(0.1, 2.7), 3));
                //Exp(tCi)_4
                tempList.Add(Math.Round((kList[3] <= tempList[0] ? (Math.Exp(t * tempList[9])) : 0) * GetRandomNumber(0.1, 2.7), 3));
                //Exp(tCi)_5
                tempList.Add(Math.Round((kList[4] <= tempList[0] ? (Math.Exp(t * tempList[10])) : 0) * GetRandomNumber(0.1, 2.7), 3));
                //sum Exp(tCi)
                tempList.Add(Math.Round(tempList.Skip(tempList.Count - 5).Sum(), 3));
                //S_3
                tempList.Add(Math.Round((tempList.Last()) / Math.Pow((1 + tempList[2]), tempList[1]), 3));
                //S
                tempList.Add(Math.Round(Math.Abs(tempList.Last() - tempList[18] - tempList[11]), 3));

                result.Add(tempList);
            }

            return result;
        }

        private static IList<List<double>>RiskResult(IList<List<double>> matrix)
        {
            var result = new List<List<double>>();
            var temp = new List<double>();
            //min
            temp.Add(matrix.Select(l => l.Last()).Max());
            //max
            temp.Add(matrix.Select(l => l.Last()).Min());
            //avCnvp
            temp.Add((matrix.Select(l => l.Last()).Max() + matrix.Select(l => l.Last()).Min()) / 2);
            //Cnvp
            temp.Add(matrix.Select(l => l.Last()).Last() - matrix.Select(l => l[18]).Last() - matrix.Select(l => l[11]).Last());
            //a
            if (temp.Last() < temp[1])
            {
                temp.Add(0);
            }
            else if (temp.Last() >= temp[1] && temp.Last() < temp[2])
            {
                temp.Add((temp.Last() - temp[1]) / (temp[2] - temp[1]));
            }
            else if (temp.Last() >= temp[1] && temp.Last() < temp[0])
            {
                temp.Add((temp[0] - temp.Last() / (temp[0] - temp[2])));
            }
            else
            {
                temp.Add(1);
            }

            //R
            if (temp[3]>=temp[0])
            {
                temp.Add(1);
            }
            else
            {
                temp.Add((temp[3] - temp[1]) / (temp[1] - temp[0])); 
            }
            //rnvp
            temp.Add(0);
            //RL
            if (temp[3]<=temp[2])
            {
                temp.Add(Math.Pow(temp[1],2)/ ( (temp[2]-temp[1]) * (temp[0] - temp[1]) ) );
            }
            else
            {
                temp.Add(1 - (Math.Pow(temp[0], 2)) / ((temp[0] - temp[2]) * (temp[0] - temp[1])));
            }

            result.Add(temp);
            return result;
        }

        public Dictionary<int, IList<List<double>>> FullResult()
        {
            var result = new Dictionary<int, IList<List<double>>> { { 0, CreateMatrix() } };
            result.Add(1, RiskResult(result[0]));
            return result;
        }
    }
}
        

