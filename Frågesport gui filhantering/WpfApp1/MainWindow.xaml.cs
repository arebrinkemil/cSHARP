using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemoNestedStackPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       List<Questions12> fragor = new List<Questions12>();
        int nummer = 0;
        int pointsen = 0;
        public MainWindow()
        {
            InitializeComponent();

            fragor.Add(new QuestionText("Vad heter Norges huvudstad?", "Oslo"));
            fragor.Add(new QuestionText("Vad heter sveriges huvudstad?", "Stockholm"));
            fragor.Add(new QuestionText("Vad heter sveriges näst största stad?", "Göteborg"));
            fragor.Add(new QuestionText("Vad heter Egyptens huvudstad?", "Kairo"));
            fragor.Add(new QuestionText("Vad heter Spaniens huvudstad?", "Madrid"));
            fragor.Add(new QuestionText("Vad heter Islands huvudstad?", "Reykjavik"));
     

            fragan.Text = fragor[nummer].Question;
        }

        private void answer_Click(object sender, RoutedEventArgs e)
        {
            

            if (answer.Text == fragor[nummer].Answer)
            {
                output.Text = "rätt ";
                pointsen = pointsen + 1;
            }

           
            else
            {
                output.Text = "fel ";
            }

            svara.IsEnabled = false;


        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            nummer = nummer + 1;

            if (nummer >= fragor.Count)
            {
                next.IsEnabled = false;
                output.Text = "klart";
                answer.Text = String.Empty;
                output.Text = String.Empty;

                points.Visibility = Visibility.Visible;
                string score = pointsen.ToString();
                points.Text = "Antal poäng:" + score + " av " + fragor.Count;


            }

            else
            {
                fragan.Text = fragor[nummer].Question;
                svara.IsEnabled = true;
                answer.Text = String.Empty;
                output.Text = String.Empty;
            }

        }
    }

}