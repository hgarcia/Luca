﻿namespace Luca.Core.Encoders
{
    public interface IEncoder
    {
        string Encode(object toSerialize);
    }
}