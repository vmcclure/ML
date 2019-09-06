using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3.Tests
{
    [TestClass()]
    public class NeuralNetworkTests
    {
        [TestMethod()]
        public void FeedForwardTest()
        {
            var dataset = new List<Tuple<double, double[]>>
            {
                new Tuple<double, double[]>(0, new double[]{0,0,0,0}),
                new Tuple<double, double[]>(0, new double[]{0,0,0,1}),
                new Tuple<double, double[]>(1, new double[]{0,0,1,0}),
                new Tuple<double, double[]>(0, new double[]{0,0,1,1}),
                new Tuple<double, double[]>(0, new double[]{0,1,0,0}),
                new Tuple<double, double[]>(0, new double[]{0,1,0,1}),
                new Tuple<double, double[]>(1, new double[]{0,1,1,0}),
                new Tuple<double, double[]>(0, new double[]{0,1,1,1}),
                new Tuple<double, double[]>(1, new double[]{1,0,0,0}),
                new Tuple<double, double[]>(1, new double[]{1,0,0,1}),
                new Tuple<double, double[]>(1, new double[]{1,0,1,0}),
                new Tuple<double, double[]>(1, new double[]{1,0,1,1}),
                new Tuple<double, double[]>(1, new double[]{1,1,0,0}),
                new Tuple<double, double[]>(0, new double[]{1,1,0,1}),
                new Tuple<double, double[]>(1, new double[]{1,1,1,0}),
                new Tuple<double, double[]>(1, new double[]{1,1,1,1}),
            };
            var topology = new Topology(4, 1,0.1, 2);
            var neuralNetwork = new NeuralNetwork(topology);
            var before = neuralNetwork.FeedForward(new double[] { 1, 1, 1, 1 }).Output;
            var difference = neuralNetwork.Learn(dataset, 100000);
            var r = new List<double>();
            foreach (var data in dataset )
            {
                r.Add(neuralNetwork.FeedForward(data.Item2).Output);
            }
            for (int i = 0; i <r.Count;i++)
            {
                var exp = Math.Round(dataset[i].Item1, 3);
                var actual = Math.Round(r[i], 4);

                //Assert.AreEqual(exp, actual);
            }
            var after = neuralNetwork.FeedForward(new double[] { 1, 1, 1, 1 }).Output;
        }
    }
}