
using System.Collections.Generic;
using neural_network_rnd.Classes;

namespace neural_network_rnd.Interfaces {
    public interface INeuronReceptor {
        Dictionary<INeuronSignal, NeuralFactor> Input { get; }
    }
}
