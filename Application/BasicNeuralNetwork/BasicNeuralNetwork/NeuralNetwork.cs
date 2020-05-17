using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNeuralNetwork
{
    class NeuralNetwork
    {
        double[] weights;
        public NeuralNetwork()
        {
            Random rand = new Random();
            weights = new double[] { rand.NextDouble(), rand.NextDouble(), rand.NextDouble() };
        }

        public double predict(int[] neuron_inputs)
        {
            double sum_of_weighted_inputs = _sum_of_weighted_input(neuron_inputs);
            double neuron_output = _activation(sum_of_weighted_inputs);
            return neuron_output;
        }

        public double[] train(List<TrainingSet> training_set_examples, long number_of_iterations)
        {
            for(int iteration=0;iteration<number_of_iterations;iteration++)
            {
                foreach(TrainingSet training_set_example in training_set_examples)
                {
                    double predicted_output = predict(training_set_example.Inputs.ToArray());
                    double error_in_output = _error_cost(training_set_example.Output, predicted_output);

                    for(int index=0;index<this.weights.Length;index++)
                    {
                        int neuron_input = training_set_example.Inputs[index];

                        this.weights[index] += _adjust_weight(neuron_input, error_in_output, predicted_output);
                    }
                }
            }

            return this.weights;
        }

        private double _sum_of_weighted_input(int[] neuron_inputs)
        {
            double sum_of_weighted_inputs = 0;
            for(int index=0;index<neuron_inputs.Length;index++)
            {
                sum_of_weighted_inputs += this.weights[index] * neuron_inputs[index];
            }
            return sum_of_weighted_inputs;
        }

        private double _activation(double sum_of_weighted_inputs)
        {
            //sigmoid function
            return 1 / (1 + Math.Exp(-sum_of_weighted_inputs));
        }

        private double _error_cost(double output,double predicted)
        {
            double error_in_output = output - predicted;
            return error_in_output;
        }

        private double _adjust_weight(double neuron_input, double error_in_output, double predicted_output)
        {
            //sigmoid gradient
            double sigmoid_gradient = predicted_output * (1 - predicted_output);
            double adjust_weight = neuron_input * error_in_output * sigmoid_gradient;
            return adjust_weight;
        }
    }
}
