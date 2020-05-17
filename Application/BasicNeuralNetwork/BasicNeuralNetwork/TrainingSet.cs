using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNeuralNetwork
{
    class TrainingSet
    {
        [JsonProperty("inputs")]
        public List<int> Inputs { get; set; }

        [JsonProperty("output")]
        public int Output { get; set; }
    }
}
