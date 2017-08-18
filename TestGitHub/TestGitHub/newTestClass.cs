using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    [Serializable]
    public class newTestClass : INotifyPropertyChanged
    {
        public string UserName { get; set; }
        public int Age { get; set; }
        public string UserEmail { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;


        public void Notify ([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
