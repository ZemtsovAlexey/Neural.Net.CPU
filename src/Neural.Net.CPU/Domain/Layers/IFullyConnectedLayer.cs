using Neural.Net.CPU.ActivationFunctions;
using Neural.Net.CPU.Domain.Save;
using Neural.Net.CPU.Neurons;

namespace Neural.Net.CPU.Domain.Layers
{
    public interface IFullyConnectedLayer : ILayer, IRandomize, ILinearCompute
    {
        ActivationType ActivationFunctionType { get; }
        
        FullyConnectedNeuron[] Neurons { get; }
        
        double[] Outputs { get; }
        
        IActivationFunction Function { get; }
        
        FullyConnectedNeuron this[int index] { get; }

        void Init(int inputsCount);
    }
}
