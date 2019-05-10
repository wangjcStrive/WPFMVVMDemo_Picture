using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMDemo.Commands;

namespace WPFMVVMDemo.ViewModels
{
    class MainViewModel:ViewModelBase
    {
        #region Fields
        private string _imagePath;
        private double _zoom = 1.0;
        private ICommand _openFileCommand;
        private ICommand _zoomCommand;
        #endregion

        #region Properties
        public string ImagePath
        {
            get => _imagePath;
            set  { _imagePath = value; OnPropertyChanged("ImagePath"); }
        }

        public double Zoom {
            get => _zoom;
            set
            {
                if (_zoom != value)
                {
                    _zoom = value;
                    OnPropertyChanged("Zoom");
                }
            }
        }

        public ICommand OpenFileCommand
        {
            get => _openFileCommand;
        }
        public ICommand ZoomCommand { get => _zoomCommand; }
        #endregion

        public MainViewModel()
        {
            _openFileCommand = new OpenFileCommand(this);
            _zoomCommand = new ZoomCommand(this);
        }

    }
}
