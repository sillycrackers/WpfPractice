using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice.ViewModels
{
    public class PersonViewModel : ObservableObject
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

        public PersonViewModel()
        {

        }
        public PersonViewModel(string name)
        {
            this.Name = name;
        }

    }
}
