using Neural.Net.CPU.Models;

namespace Neural.Net.CPU.Domain.Layers
{
    public interface IMatrixLayer : ILayer
    {
        Matrix[] Outputs { get; }
     
        int OutputWidht { get; }
        
        int OutputHeight { get; }

        Matrix[] Compute(Matrix[] input);
    }
}
