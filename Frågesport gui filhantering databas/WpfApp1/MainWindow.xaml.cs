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
using System.IO;
using Path = System.IO.Path;

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

        private string dbName = "sqlite.db";
        private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

       
        public MainWindow()
        {
            InitializeComponent();
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathAndFileName = Path.Combine(docPath, fileName);

            text.Text = pathAndFileName;
            ReadFile();


           
            
     

            fragan.Text = fragor[nummer].Question;
        }

        public string GetPathAndDbName()
        {
            return Path.Combine(docPath, dbName); ;
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


        private void ReadFile()
        {
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(pathAndFileName))
                {
                    // Read the stream as a string, and write the string to the console.
                    
                    String question = sr.ReadLine();
                    String answer = sr.ReadLine();

                    while(question != null && answer != null)
                    {
                        fragor.Add(new QuestionText(question, answer));
                        question = sr.ReadLine();
                        answer = sr.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                output.Text = "The file could not be read:" + e.Message;
            }
        }
    }

}