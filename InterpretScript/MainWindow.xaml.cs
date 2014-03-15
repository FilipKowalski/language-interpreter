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

namespace InterpretScript
{
    public partial class MainWindow : Window
    {
        Script Script;

        public MainWindow()
        {
            InitializeComponent();
            Script = new Script();
        }

        private void RunScript_Click(object sender, RoutedEventArgs e)
        {
            Script.RunScript(new TextRange(ScriptText.Document.ContentStart, ScriptText.Document.ContentEnd).Text);
            ResultText.Document.Blocks.Clear();

            ResultText.SelectAll();
            ResultText.Selection.Text = Script.GetResult;
        }
    }
}
