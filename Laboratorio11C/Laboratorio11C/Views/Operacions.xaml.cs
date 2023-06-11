using Laboratorio11C.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio11C.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operacions : ContentPage
    {
        public Operacions()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelOperaciones();
        }
    }
}