
namespace neural_network_rnd.Interfaces {
    public interface INeuralNet {
        INeuralLayer HiddenLayer { get; set; }
        INeuralLayer OutputLayer { get; set; }
        INeuralLayer PerceptiontLayer { get;}
        void ApplyLearning();
        void Pulse();
    }
}
