
namespace neural_network_rnd.Classes {
    public class NeuralFactor {
        private double m_weight;
        private double m_delta;

        public NeuralFactor(double weight) {
            m_weight = weight;
            m_delta = 0;
        }

        public double Weight {
            get { 
                return m_weight;
            }

            set { 
                m_weight = value; 
            }
        }

        public double Delta { 
            get { 
                return m_delta; 
            }

            set {
                m_delta = value;
            } 
        }

        public void ApplyDelta() {
            m_weight += m_delta;
            m_delta = 0;
        }
    }
}   
