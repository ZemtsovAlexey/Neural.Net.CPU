namespace Neural.Net.CPU.Learning
{
    public interface ILearning
    {
        double Run(double[] input, double[] output);
    }
}