namespace Neural.Net.CPU.Domain.Layers
{
    public interface ILinearCompute
    {
        double[] Compute(double[] inputs);
    }
}
