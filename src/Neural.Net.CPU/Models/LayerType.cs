using System;

namespace Neural.Net.CPU.Models
{
    [Serializable]
    public enum LayerType
    {
        Convolution = 0,
        FullyConnected = 1,
        MaxPoolingLayer = 2
    }
}