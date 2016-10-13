using System;
using Accord.Controls;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Kernels;
using Accord.IO;


namespace Alura.MachineLearning
{
    class Program
    {
        [MTAThread]
        static void Main(string[] args)
        {

            double[][] inputs =
            {
                /* 1.*/ new double[] { 0, 0 ,1},
                /* 2.*/ new double[] { 1, 0, 1 },
                /* 3.*/ new double[] { 0, 1 ,1},
                /* 4.*/ new double[] { 1, 1 ,1},
                new double[] { 1, 0 ,0},
                new double[] { 1, 0 ,1}

            };

            int[] outputs =
            { 
                /* 1. 0 xor 0 = 0: */ -1,
                /* 2. 1 xor 0 = 1: */ +1,
                /* 3. 0 xor 1 = 1: */ +1,
                /* 4. 1 xor 1 = 0: */ +1,
                -1,
                1
            };


            // Create a new machine with a polynomial kernel and two inputs
            KernelSupportVectorMachine ksvm = new KernelSupportVectorMachine(
                new Gaussian(),3);

            // Create the learning algorithm with the given inputs and outputs
            SequentialMinimalOptimization smo = new SequentialMinimalOptimization(
                machine: ksvm, inputs: inputs, outputs: outputs)
            {
                Complexity = 100  // Create a hard-margin SVM
            };

            // Teach the machine
            double error = smo.Run();

            error = smo.ComputeError(inputs,outputs);

            error = smo.Run();

            Console.WriteLine("error: " + error);

            // Show results on screen
            //ScatterplotBox.Show("Training data", inputs, outputs);

           // ScatterplotBox.Show("SVM results", inputs, inputs.Apply(p => ksvm.Compute(p)));

            Console.ReadKey();
        }
    }
}
