using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class Topology
    {
        public static void Main(string[] args)
        {
           // var topology = new Topology(4, 1, 2);
        }
        public int InputCount { get; }
        public int OutputCount { get; }
        public double LearningRate { get; }
        public List<int> HiddenLayers { get; }
        public Topology(int inputCount, int outpuCount, double learningRate, params int[] layers)
        {
            InputCount = inputCount;
            OutputCount = outpuCount;
            LearningRate = learningRate;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);

        }
    }
}
