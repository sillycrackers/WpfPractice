using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice.Models
{
    public class PersonModel : ObservableObject
    {
        public string Name
        {
            get
            {
                if (String.IsNullOrWhiteSpace(_name))
                {
                    return "No Name";
                }
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        private string _name;

        public PersonModel()
        {

        }
        public PersonModel(string name)
        {
            this.Name = name;
        }

    }
}
