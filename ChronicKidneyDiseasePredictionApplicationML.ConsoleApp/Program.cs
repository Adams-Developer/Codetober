// This file was auto-generated by ML.NET Model Builder. 

using System;
using ChronicKidneyDiseasePredictionApplicationML.Model;

namespace ChronicKidneyDiseasePredictionApplicationML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Age = 48F,
                Bp = 80F,
                Sg = 1.02F,
                Al = 1F,
                Su = 0F,
                Rbc = @"unknown",
                Pc = @"normal",
                Pcc = @"notpresent",
                Ba = @"notpresent",
                Bgr = 121F,
                Bu = 36F,
                Sc = 1.2F,
                Sod = 0F,
                Pot = 0F,
                Hemo = 15.4F,
                Pcv = @"44",
                Wbcc = @"7800",
                Rbcc = 5.2F,
                Htn = true,
                Dm = true,
                Cad = false,
                Appet = @"good",
                Pe = false,
                Ane = false,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Class with predicted Class from sample data...\n\n");
            Console.WriteLine($"Age: {sampleData.Age}");
            Console.WriteLine($"Bp: {sampleData.Bp}");
            Console.WriteLine($"Sg: {sampleData.Sg}");
            Console.WriteLine($"Al: {sampleData.Al}");
            Console.WriteLine($"Su: {sampleData.Su}");
            Console.WriteLine($"Rbc: {sampleData.Rbc}");
            Console.WriteLine($"Pc: {sampleData.Pc}");
            Console.WriteLine($"Pcc: {sampleData.Pcc}");
            Console.WriteLine($"Ba: {sampleData.Ba}");
            Console.WriteLine($"Bgr: {sampleData.Bgr}");
            Console.WriteLine($"Bu: {sampleData.Bu}");
            Console.WriteLine($"Sc: {sampleData.Sc}");
            Console.WriteLine($"Sod: {sampleData.Sod}");
            Console.WriteLine($"Pot: {sampleData.Pot}");
            Console.WriteLine($"Hemo: {sampleData.Hemo}");
            Console.WriteLine($"Pcv: {sampleData.Pcv}");
            Console.WriteLine($"Wbcc: {sampleData.Wbcc}");
            Console.WriteLine($"Rbcc: {sampleData.Rbcc}");
            Console.WriteLine($"Htn: {sampleData.Htn}");
            Console.WriteLine($"Dm: {sampleData.Dm}");
            Console.WriteLine($"Cad: {sampleData.Cad}");
            Console.WriteLine($"Appet: {sampleData.Appet}");
            Console.WriteLine($"Pe: {sampleData.Pe}");
            Console.WriteLine($"Ane: {sampleData.Ane}");
            Console.WriteLine($"\n\nPredicted Class: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
