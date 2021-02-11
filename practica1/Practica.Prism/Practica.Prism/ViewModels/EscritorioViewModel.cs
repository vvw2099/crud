using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica.Prism.ViewModels
{
    public class EscritorioViewModel : ViewModelBase
    {
        public EscritorioViewModel(INavigationService navigationService):base(navigationService)
        {
            Title = "Escritorio";
        }
    }
}
