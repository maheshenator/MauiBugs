namespace MauiBugs
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            HTMLLable1.Text = @"<p>Text without Padding</p>
<p style=""padding-left: 40px;"">Text with Padding</p>
<p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Text prefixed with Spaces </p>
<p style=""margin: 40px;"">Text with Margin</p>";

        }

        
    }

}
