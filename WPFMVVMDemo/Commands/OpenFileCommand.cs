using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMDemo.ViewModels;

namespace WPFMVVMDemo.Commands
{
    class OpenFileCommand : ICommand
    {
        private MainViewModel _data;
        public event EventHandler CanExecuteChanged;


        public OpenFileCommand(MainViewModel data)
        {
            _data = data;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                _data.ImagePath = dialog.FileName;
            }
        }
    }
}
