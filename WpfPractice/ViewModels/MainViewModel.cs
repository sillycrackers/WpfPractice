using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPractice.ViewModels
{
    public class MainViewModel
    {
        public PersonViewModel person { get; set; }
        public MainViewModel()
        {
            person = new PersonViewModel("Erik");
        }
    }
}
