
using System.Collections.Generic;

namespace neural_network_rnd.Interfaces {
    public interface INeuralLayer : IList<INeuron> {
        void Pusle(INeuralNet net);
        void ApplyLearning(INeuralNet net);
    }
}
