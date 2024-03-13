using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConcursDraexlmaier.ViewModels;

public class NotifyPropertyChangedBase : INotifyPropertyChanged
{
    public NotifyPropertyChangedBase()
    {
            
    }

    public void FirePropertyChanged([CallerMemberName] string propertyName = null)
    {
        this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
