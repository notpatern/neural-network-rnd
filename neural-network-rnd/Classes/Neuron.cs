
using neural_network_rnd.Interfaces;
using System;
using System.Collections.Generic;

namespace neural_network_rnd.Classes {
    public class Neuron {
        NeuralFactor m_bias;
        double m_biasWeight;
        double m_error;
        Dictionary<INeuronSignal, NeuralFactor> m_input;
        double m_output;

        NeuralFactor Bias {
            get { return m_bias; }
            set { m_bias = value; }
        }

        double BiasWeight {
            get { return m_biasWeight; }
            set { m_biasWeight = value; }
        }

        double Error {
            get { return m_errorl; }
            set { m_error = value; }
        }

        Dictionary<INeuronSignal, NeuralFactor> Input {
            get { return m_input; }
            set { m_input = value; }
        }

        double Output {
            get { return m_output; }
            set { m_output = value; }
        }

        void ApplyLearning() {

        }

        public Neuron() {

        }

        void Pulse() {
            lock (this) {
                m_output = 0;
                foreach (KeyValuePair<INeuronSignal, NeuralFactor> item in m_input)
                    m_output += item.Key.Output * item.Value.Weight;
                m_output += m_bias.Weight * BiasWeight;
                m_output = Sigmoid(m_output);
            }
        }

        double Sigmoid(double value) {
            return 1 / (1 + Math.Exp(-value));
        }
    }
}
