using System;

namespace Observer;

public interface ISubject<Temperature> where Temperature : new() Temperature
{
    void Subscribe();
    void Unsubscribe();
    void GetTemperature();
}