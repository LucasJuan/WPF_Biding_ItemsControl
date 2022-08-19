using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItensControlLibrary
{
    public class MockModel
    {
        public ObservableCollection<MockNode> Nodes;

        public MockModel()
        {
            Nodes = new ObservableCollection<MockNode>();
        }
    }

    public class MockNode
    {
        public MockNode()
        {
        }

        private string itemname;
        public string FirstName
        {
            get { return this.itemname; }
            set { this.itemname = value; }
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
   
}
