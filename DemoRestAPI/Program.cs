using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CustomerRestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {



            BuildWebHost(args).Run();

        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .CaptureStartupErrors(true)
                .UseStartup<Startup>()
                .Build();


        /*
                string[] Ingredients =
                            {
                            "Protein",
                            "Fedt",
                            "mættede fedtsyrer",
                            "monoumætt fedtsyrer",
                            "polyumætt fedtsyrer",
                            "Kulhydrat",
                            "sukker",
                            "kostfibre",
                            "Alkohol",
                            "Aske",
                            "Vand",
                            "A-vitamin",
                            "Retinol",
                            "β-caroten",
                            "D-vitamin",
                            "cholecalciferol",
                            "ergocalciferol",
                            "hydroxycholecalciferol",
                             "E-vitamin",
                            "alfa-tokoferol",
                            "K-vitamin",
                            "B1-vitamin",
                            "B2-vitamin",
                            "Niacin",
                            "niacin",
                            "tryptofans",
                            "B6-vitamin",
                            "Pantothensyre",
                            "Biotin",
                            "Folat",
                            "B12-vitamin",
                            "C-vitamin",
                            "Natrium",
                            "Kalium",
                            "Calcium",
                            "Magnesium",
                            "Phosphor",
                            "Jern",
                            "Kobber",
                            "Zink",
                            "Jod",
                            "Mangan",
                            "Chrom",
                            "Selen",
                            "Nikkel",
                            "Fructose",
                            "Glucose",
                            "Lactose",
                            "Maltose",
                            "Saccharose",
                            "Sukkerarter",
                            "Stivelse",
                            "Kostfibre",
                            "Transfedtsyrer",
                            "Cholesterol",
                            "Isoleucin",
                            "Leucin",
                            "Lysin",
                            "Methionin",
                            "Cystin",
                            "Phenylalanin",
                            "Tyrosin",
                            "Threonin",
                            "Tryptofan",
                            "Valin",
                            "Arginin",
                            "Histidin",
                            "Alanin",
                            "Asparaginsyre",
                            "Glutaminsyre",
                            "Glycin",
                            "Prolin",
                            "Serin",
                    };
        */




    }

}


