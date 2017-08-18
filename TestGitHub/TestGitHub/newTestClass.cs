using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    [Serializable]
    public class newTestClass : INotifyPropertyChanged
    {
        public string UserName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}
