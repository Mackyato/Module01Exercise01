namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello!!";
            ColorRed = Colors.Black;

            this.BindingContext = this;

        }

        //DatePicker birthDatePicker = new DatePicker()
        //{
           
        //};

        private void OnChangedBackgroundColorG(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Aqua;
        }
        private void OnChangedBackgroundColorL(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightBlue;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var name = MyName.Text;
            var email = Email.Text;
        }

    }

}
