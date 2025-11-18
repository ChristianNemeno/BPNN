
using Backprop;

namespace BPNN
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBpnn_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, 10, 1);


        }

        private void TrainNeuralNet_Click(object sender, EventArgs e)
        {

            for (int x = 0; x < 10000; x++)
            {
                //1
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //2
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //3
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //4
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                //5
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //6
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();


                //7
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //8
                nn.setInputs(0, 0.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //9
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //10
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //11
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //12
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 0.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //13
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //14
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 0.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //15
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 0.0);
                nn.setDesiredOutput(0, 0.0);
                nn.learn();

                //16
                nn.setInputs(0, 1.0);
                nn.setInputs(1, 1.0);
                nn.setInputs(2, 1.0);
                nn.setInputs(3, 1.0);
                nn.setDesiredOutput(0, 1.0);
                nn.learn();

                if (x % 10 == 0 && CheckIfLearned())
                {
                   MessageBox.Show($"Learned successfully at epoch {x + 1}");
                   break;
                }

            }

        }


        private bool CheckIfLearned()
        {
            bool learned = true;
            double threshold = 0.1;

            
            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 0.0);
            nn.setInputs(3, 0.0);
            nn.run();
            if (Math.Abs(nn.getOuputData(0) - 0.0) > threshold)
                learned = false;

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.run();
            if (Math.Abs(nn.getOuputData(0) - 0.0) > threshold)
                learned = false;

            nn.setInputs(0, 0.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.run();
            if (Math.Abs(nn.getOuputData(0) - 0.0) > threshold)
                learned = false;


            nn.setInputs(0, 1.0);
            nn.setInputs(1, 0.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 0.0);
            nn.run();
            if (Math.Abs(nn.getOuputData(0) - 0.0) > threshold)
                learned = false;

            
            nn.setInputs(0, 1.0);
            nn.setInputs(1, 1.0);
            nn.setInputs(2, 1.0);
            nn.setInputs(3, 1.0);
            nn.run();
            if (Math.Abs(nn.getOuputData(0) - 1.0) > threshold)
                learned = false;

            return learned;
        }   



        private void Test_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox4.Text));
            nn.setInputs(3, Convert.ToDouble(textBox5.Text));
            nn.run();
            textBox3.Text = "" + nn.getOuputData(0);
        }

        
    }
}
