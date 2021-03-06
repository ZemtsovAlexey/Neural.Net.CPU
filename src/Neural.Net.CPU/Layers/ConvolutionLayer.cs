﻿using System.Linq;
using Neural.Net.CPU.ActivationFunctions;
using Neural.Net.CPU.Domain.Layers;
using Neural.Net.CPU.Domain.Save;
using Neural.Net.CPU.Models;
using Neural.Net.CPU.Neurons;

namespace Neural.Net.CPU.Layers
{
    public class ConvolutionLayer : IConvolutionLayer
    {
        public LayerType Type { get; set; } = LayerType.Convolution;
        public ActivationType ActivationFunctionType { get; }
        public ConvolutionNeuron[] Neurons { get; set; }
        public Matrix[] Outputs { get; private set; }
        public int OutputWidht { get; private set; }
        public int OutputHeight { get; private set; }
        public int KernelSize { get; private set; }
        public bool UseReferences { get; }

        public int NeuronsCount => Neurons.Length;
        public ConvolutionNeuron this[int index] => Neurons[index];

        private IActivationFunction _function;
        
        public ConvolutionLayer(ActivationType activationType, int neuronsCount, int kernelSize = 3, bool useReferences = false)
        {
            ActivationFunctionType = activationType;
            _function = activationType.Get();
            KernelSize = kernelSize;
            Neurons = new ConvolutionNeuron[neuronsCount];
            Outputs = new Matrix[neuronsCount];
            UseReferences = useReferences;
        }

        public void Init(int inputWidth, int inputHeight, int? outsPerNeuron)
        {
            OutputWidht = inputWidth - KernelSize + 1;
            OutputHeight = inputHeight - KernelSize + 1;
            
            for (var i = 0; i < NeuronsCount; i++)
            {
                int? parentNeuron = null;
                
                if (UseReferences)
                    parentNeuron = outsPerNeuron.HasValue && outsPerNeuron.Value > 0 ? i / outsPerNeuron : 0;
                
                Neurons[i] = new ConvolutionNeuron(_function, inputWidth, inputHeight, KernelSize, parentNeuron);
            }
        }

        public void Randomize()
        {
            foreach (var neuron in Neurons)
            {
                neuron.Randomize();
            }
        }

        public Matrix[] Compute(Matrix[] input)
        {
            var outputs = Neurons.AsParallel().Select(n => n.Compute(input)).ToArray();

            Outputs = outputs;

            return outputs;
        }
    }
}
