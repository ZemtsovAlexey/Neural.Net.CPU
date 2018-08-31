using Neural.Net.CPU.Models;

namespace Neural.Net.CPU.Domain.Layers
{
    public interface ILayer
    {
        LayerType Type { get; }
        
        int NeuronsCount { get; }
    }
}
