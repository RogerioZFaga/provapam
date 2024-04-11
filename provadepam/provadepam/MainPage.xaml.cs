namespace provadepam
{
    public partial class MainPage : ContentPage
    {
        Random rand = new Random();
        int randomNumber;

        public MainPage()
        {
            InitializeComponent();
            NumberPicker.SelectedIndex = 0;
        }

        private void NumberPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int DiceIndex = NumberPicker.SelectedIndex;

        }

        private void RolarDadoButton_Clicked(object sender, EventArgs e)
        {
            if (NumberPicker.SelectedIndex == 0)
            {
                randomNumber = rand.Next(1, 5);
                DiceResult.Text = randomNumber.ToString();
            }

            else if (NumberPicker.SelectedIndex == 1)
            {
                randomNumber = rand.Next(1, 7);
                DiceResult.Text = randomNumber.ToString();
            }

            else if (NumberPicker.SelectedIndex == 2)
            {
                randomNumber = rand.Next(1, 11);
                DiceResult.Text = randomNumber.ToString();
            }

            else if (NumberPicker.SelectedIndex == 3)
            {
                randomNumber = rand.Next(1, 21);
                DiceResult.Text = randomNumber.ToString();
            }

            else if (NumberPicker.SelectedIndex == 4)
            {
                randomNumber = rand.Next(1, 101);
                DiceResult.Text = randomNumber.ToString();
            }
        }
    }

}
