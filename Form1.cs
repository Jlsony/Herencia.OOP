using OOP.WinFormsApp1.Transports;

namespace OOP.WinFormsApp1
{
    public partial class Form1 : Form
    {
        Car car;
        Bus bus;

        public Form1()
        {
            InitializeComponent();

            car = new Car(4, 50, "VW Sedan");
            bus = new Bus(90, "Mercedes Bens");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            car.Name = "Jetta 2009";

            car.Sound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bus.Sound();
        }

    }
}
