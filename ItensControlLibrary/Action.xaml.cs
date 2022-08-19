using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ItensControlLibrary
{
    /// <summary>
    /// Interaction logic for Action.xaml
    /// </summary>
    public partial class Action : UserControl
    {
        public Action()
        {
            InitializeComponent();
            //Init Model
            MockModel myModel = new MockModel();

            for (int i = 0; i < 4; i++)
            {
                MockNode mn = new MockNode();
                mn.FirstName = String.Format("Node {0}", i);
                myModel.Nodes.Add(mn);
            }
            // Set DataContext for StackPanel
            icTodoList.ItemsSource = myModel.Nodes;
            //PersonCollection = new ObservableCollection<Person>()
            //{
            //    new Person() { FirstName = "John", LastName = "Doe" },
            //    new Person() { FirstName = "Richard", LastName = "Bryson" },
            //    new Person() { FirstName = "Bill", LastName = "Gates" },
            //    new Person() { FirstName = "Adam", LastName = "Sandler" }
            //};
            //icTodoList.ItemsSource = PersonCollection;

        }
        public ObservableCollection<Person> PersonCollection { get; set; }
    }
}
