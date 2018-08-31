using Neural.Net.CPU.Neurons;

namespace Neural.Net.CPU.Domain.Layers
{
    public interface IMaxPoolingLayer : IMatrixLayer
    {
        MaxPoolingNeuron[] Neurons { get; }

        int KernelSize { get; set; }
        
        void Init(int neuronsCount, int inputWidth, int inputHeitght);
    }
}