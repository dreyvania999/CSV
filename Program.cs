using System;
using System.Diagnostics.Metrics;
using System.Text;

namespace Practika_5_zadanie5
{
    struct Lenght
    {
        public string Km;
        public string Metr;
        public string Mil;
        public string Fut;
        public string Yard;
        public string Duym;
        public string Verst;
        public void show()
        {

            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3, -15} {4, -15} {5,-15} {6,-15} ", Km, Metr, Mil, Fut, Yard, Duym, Verst);
        }
        public string concat()
        {
            return $"{Km};{Metr};{Mil};{Fut};{Yard};{Duym};{Verst}";
        }

    }
    public class Program
    {

        static void getData(string path, List<Lenght> L)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string[] array = sr.ReadLine().Split(';');
                    L.Add(new Lenght()
                    {
                        Km = array[0],
                        Metr = array[1],
                        Mil = array[2],
                        Fut = array[3],
                        Yard = array[4],
                        Duym = array[5],
                        Verst = array[6]
                    });
                }
            }
        }

        static void printData(List<Lenght> L)
        {
            foreach (Lenght u in L)
            {
                u.show();
            }
        }
        static void createData(string path, List<Lenght> L)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Lenght u in L)
                {
                    sw.WriteLine(u.concat());
                }
            }
        }
        static void check(List<Lenght> L)
        {
            for (int i = 1; i < L.Count; i++)
            {
                Lenght l = L[i];
                if ((l.Km == "") && (l.Metr == ""))
                {
                    try
                    {
                        if (l.Mil != "")
                        {
                            double Mils = Convert.ToDouble(l.Mil);
                            double result = (Mils * 1609.344) / 1000;
                            string otv = "" + Math.Round(result, 3);
                            string[] arrayOtv = otv.Split(',');
                            l.Km = arrayOtv[0];
                            l.Metr = arrayOtv[1];
                        }
                        else l.Mil = "";
                        if (l.Fut != "")
                        {
                            double Futs = Convert.ToDouble(l.Fut);
                            double result = (Futs * 0.3048) / 1000;
                            string otv = "" + Math.Round(result, 3);
                            string[] arrayOtv = otv.Split(',');
                            l.Km = arrayOtv[0];
                            l.Metr = arrayOtv[1];
                        }
                        else l.Fut = "";
                        if (l.Yard != "")
                        {
                            double Yards = Convert.ToDouble(l.Yard);
                            double result = (Yards * 0.9144) / 1000;
                            string otv = "" + Math.Round(result, 3);
                            string[] arrayOtv = otv.Split(',');
                            l.Km = arrayOtv[0];
                            l.Metr = arrayOtv[1];
                        }
                        else l.Yard = "";
                        if (l.Duym != "")
                        {
                            double Duyms = Convert.ToDouble(l.Duym);
                            double result = (Duyms * 0.0254) / 1000;
                            string otv = "" + Math.Round(result, 3);
                            string[] arrayOtv = otv.Split(',');
                            l.Km = arrayOtv[0];
                            l.Metr = arrayOtv[1];
                        }
                        else l.Duym = "";
                        if (l.Verst != "")
                        {
                            double Versts = Convert.ToDouble(l.Verst);
                            double result = (Versts * 1066.8) / 1000;
                            string otv = "" + Math.Round(result, 3);
                            string[] arrayOtv = otv.Split(',');
                            l.Km = arrayOtv[0];
                            l.Metr = arrayOtv[1];
                        }
                        else l.Verst = "";
                    }
                    catch
                    {
                        l.Mil = "null;";
                        l.Metr = "null;";
                        l.Km = "null;";
                        l.Fut = "null;";
                        l.Yard = "null;";
                        l.Duym = "null;";
                        l.Verst = "null";
                    }
                }
                else if ((l.Km == "") && (l.Metr != ""))
                {
                    try
                    {
                        double Metrs = Convert.ToDouble(l.Metr);
                        double Milg = (0 + Metrs) / 1609.344;
                        double Futn = (0 + Metrs) / 0.3048;
                        double Yardn = (0 + Metrs) / 0.9144;
                        double Duymn = (0 + Metrs) / 0.0254;
                        double Verstn = (0 + Metrs) / 1066.8;
                        l.Mil = Math.Round(Milg, 3) + "";
                        l.Fut = Math.Round(Futn, 3) + "";
                        l.Yard = Math.Round(Yardn, 3) + "";
                        l.Duym = Math.Round(Duymn, 3) + "";
                        l.Verst = Math.Round(Verstn, 3) + "";


                    }
                    catch
                    {
                        l.Mil = "null;";
                        l.Metr = "null;";
                        l.Km = "null;";
                        l.Fut = "null;";
                        l.Yard = "null;";
                        l.Duym = "null;";
                        l.Verst = "null";
                    }

                }
                else if ((l.Km != "") && (l.Metr == ""))
                {
                    try
                    {
                        double Kms = Convert.ToDouble(l.Km);
                        double Milg = (Kms * 1000) / 1609.344;
                        double Futn = (Kms * 1000) / 0.3048;
                        double Yardn = (Kms * 1000) / 0.9144;
                        double Duymn = (Kms * 1000) / 0.0254;
                        double Verstn = (Kms * 1000) / 1066.8;
                        l.Mil = Math.Round(Milg, 3) + "";
                        l.Fut = Math.Round(Futn, 3) + "";
                        l.Yard = Math.Round(Yardn, 3) + "";
                        l.Duym = Math.Round(Duymn, 3) + "";
                        l.Verst = Math.Round(Verstn, 3) + "";
                    }
                    catch
                    {
                        l.Mil = "null;";
                        l.Metr = "null;";
                        l.Km = "null;";
                        l.Fut = "null;";
                        l.Yard = "null;";
                        l.Duym = "null;";
                        l.Verst = "null";
                    }
                }
                else if ((l.Km != "") && (l.Metr != ""))
                {
                    try
                    {
                        double Kms = Convert.ToDouble(l.Km);
                        double Metrs = Convert.ToDouble(l.Metr);
                        double Milg = ((Kms * 1000) + Metrs) / 1609.344;
                        double Futn = ((Kms * 1000) + Metrs) / 0.3048;
                        double Yardn = ((Kms * 1000) + Metrs) / 0.9144;
                        double Duymn = ((Kms * 1000) + Metrs) / 0.0254;
                        double Verstn = ((Kms * 1000) + Metrs) / 1066.8;
                        l.Mil = Math.Round(Milg, 3) + "";
                        l.Fut = Math.Round(Futn, 3) + "";
                        l.Yard = Math.Round(Yardn, 3) + "";
                        l.Duym = Math.Round(Duymn, 3) + "";
                        l.Verst = Math.Round(Verstn, 3) + "";
                    }
                    catch
                    {
                        l.Mil = "null;";
                        l.Metr = "null;";
                        l.Km = "null;";
                        l.Fut = "null;";
                        l.Yard = "null;";
                        l.Duym = "null;";
                        l.Verst = "null";
                    }
                }
                else
                {
                    l.Mil = "null;";
                    l.Metr = "null;";
                    l.Km = "null;";
                    l.Fut = "null;";
                    l.Yard = "null;";
                    l.Duym = "null;";
                    l.Verst = "null";
                }
                L[i] = l;
            }

        }

        static void Main(string[] args)
        {
            List<Lenght> Lenght = new List<Lenght>();
            getData("dataLenght.csv", Lenght);
            check(Lenght);
            printData(Lenght);
            Console.WriteLine();
            createData("Lenght.csv", Lenght);
        }
    }
}
