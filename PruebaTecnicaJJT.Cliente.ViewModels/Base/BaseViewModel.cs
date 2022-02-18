using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace PruebaTecnicaJJT.Cliente.ViewModels.Base
{
    public abstract class BaseViewModel : ObservableObject
    {
        #region Fields

        private bool _isBusy;
        private string _msj;
        private bool _isEnabled;
        private bool _isVisible;
        private bool _isNewItem;
        private bool _isNavigate;
        private bool _isError;
        #endregion

        #region Ctor      
        public BaseViewModel()
        {
            IsEnabled = true;
            IsNavigate = false;
        }
        #endregion

        #region Properties
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public string Msj
        {
            get => _msj;
            set => SetProperty(ref _msj, value);
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        public bool IsVisible
        {
            get => _isVisible;
            set => SetProperty(ref _isVisible, value);
        }

        public bool IsNewItem
        {
            get => _isNewItem;
            set => SetProperty(ref _isNewItem, value);
        }

        public bool IsNavigate
        {
            get => _isNavigate;
            set => SetProperty(ref _isNavigate, value);
        }

        public bool IsError
        {
            get => _isError;
            set => SetProperty(ref _isError, value);
        }

        #endregion

        #region Commands
        public IAsyncRelayCommand UpdateCommand { get; internal protected set; }
        public IAsyncRelayCommand GetAllCommand { get; internal protected set; }
        public IAsyncRelayCommand GetCommand { get; internal protected set; }
        public IAsyncRelayCommand DeleteCommand { get; internal protected set; }
        public IAsyncRelayCommand PostCommand { get; internal protected set; }
        public IAsyncRelayCommand PutCommand { get; internal protected set; }
        #endregion
    }
}
