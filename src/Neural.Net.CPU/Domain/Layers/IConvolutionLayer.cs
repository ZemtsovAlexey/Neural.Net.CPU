using Neural.Net.CPU.Domain.Save;
using Neural.Net.CPU.Neurons;

namespace Neural.Net.CPU.Domain.Layers
{
    public interface IConvolutionLayer : IRandomize, IMatrixLayer
    {
        ActivationType ActivationFunctionType { get; }
        int KernelSize { get; }
        ConvolutionNeuron[] Neurons { get; set; }
        bool UseReferences { get; }
        ConvolutionNeuron this[int index] { get; }

        void Init(int inputWidth, int inputHeight, int? outsPerNeuron);
    }
}
