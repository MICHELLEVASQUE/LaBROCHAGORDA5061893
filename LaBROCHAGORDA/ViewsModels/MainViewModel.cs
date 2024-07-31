using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LaBROCHAGORDA.ViewsModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private double _Alto;//Crear variables
        //se pone variable ;
        [ObservableProperty]
        private double _Largo;//Crear variables
                              //se pone variable ;
        [ObservableProperty]
        private string? _Resultado1 ;//Crear variables
        [ObservableProperty]
        private string? _Resultado2;//Crear variables
        //se pone variable ;
        [ObservableProperty]
        private double _costototal;//Crear variables
                                   //se pone variable ;
        [ObservableProperty]
        private double _PrecioM2 = 2;//Crear variables
        //se pone variable ;

        [RelayCommand]//Constructor 

        //declarar una variable para mostrar el resultado en el entry y devuelva el resultado

        public void Medir()
        {

            double Medir = Largo * Alto;
            double costototal = Medir * PrecioM2;
            Resultado1 = Medir.ToString("F2") ;
            Resultado2 = costototal.ToString("F3");
            //calculos
        }
    }
}
