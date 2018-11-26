using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfWeatherApp.ViewModel.Commands
{
    public class RefreshCommand : ICommand
    {
        public RefreshCommand(WeatherViewModel viewModel)
        {
            ViewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public WeatherViewModel ViewModel { get; set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.GetWeather();
        }
    }
}
