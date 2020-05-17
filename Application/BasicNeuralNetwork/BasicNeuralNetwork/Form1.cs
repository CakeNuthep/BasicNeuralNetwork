using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicNeuralNetwork
{
    public partial class Form1 : Form
    {
        NeuralNetwork neuralNetwork;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_pathFile.Text = openFileDialog.FileName;

                    neuralNetwork = new NeuralNetwork();
                }
            }
        }

        private void button_train_Click(object sender, EventArgs e)
        {
            List<TrainingSet> training_set_example = JsonConvert.DeserializeObject<List<TrainingSet>>(File.ReadAllText(textBox_pathFile.Text));
            int number_of_iteration = int.Parse(textBox_numberOfIteration.Text);
            double[] weight = neuralNetwork.train(training_set_example, number_of_iteration);
            label_weight1.Text = weight[0].ToString("0.000");
            label_weight2.Text = weight[1].ToString("0.000");
            label_weight3.Text = weight[2].ToString("0.000");
        }

        private void button_predict_Click(object sender, EventArgs e)
        {
            if(neuralNetwork != null)
            {
                double predict = neuralNetwork.predict(new int[] { int.Parse(textBox_input1.Text),int.Parse(textBox_input2.Text),int.Parse(textBox_input3.Text)});
                if(predict > 0.50)
                {
                    textBox_predict.Text = "1";
                }
                else
                {
                    textBox_predict.Text = "0";
                }
            }
        }
    }
}
