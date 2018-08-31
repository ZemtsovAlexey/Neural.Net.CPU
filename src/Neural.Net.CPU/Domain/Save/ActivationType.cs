using System;

namespace Neural.Net.CPU.Domain.Save
{
    [Serializable]
    public enum ActivationType
    {
        None,
        BipolarSigmoid,
        Sigmoid,
        ELU,
        LeakyReLu,
        ReLu,
        LeCunTanh,
        AbsoluteReLU
    }
}