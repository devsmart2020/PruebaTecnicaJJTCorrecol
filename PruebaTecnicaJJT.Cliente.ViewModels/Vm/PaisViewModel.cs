using Microsoft.Toolkit.Mvvm.Input;
using PruebaTecnica.Cliente.Services.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Cliente.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PruebaTecnicaJJT.Cliente.ViewModels.Vm
{
    public sealed class PaisViewModel : BaseViewModel
    {
        #region Fields
        private int _idPais;
        private string _nombre;
        private string _paisIso1;
        private ObservableCollection<DTOPais> _listaPaises;
        private readonly IPaisService _service;
        #endregion

        #region Ctor
        public PaisViewModel()
        {
            ListarPaisesCommand = new RelayCommand(async () => await ListarPaises());
            _service = new PaisService();
        }
        #endregion

        #region Properties

        public int IdPais
        {
            get => _idPais;
            set => SetProperty(ref _idPais, value);
        }
        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }
        public string PaisIso1
        {
            get => _paisIso1;
            set => SetProperty(ref _paisIso1, value);
        }
        public ObservableCollection<DTOPais> ListaPaises
        {
            get => _listaPaises;
            set => SetProperty(ref _listaPaises, value);
        }
        #endregion

        #region Methods
        private async Task ListarPaises()
        {
            IsBusy = true;
            try
            {
                ListaPaises = new ObservableCollection<DTOPais>(await _service.ListarPaises());
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion

        #region Commands
        public ICommand ListarPaisesCommand { get; }
        #endregion
    }
}
