using Microsoft.Toolkit.Mvvm.Input;
using PruebaTecnica.Cliente.Services.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Cliente.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PruebaTecnicaJJT.Cliente.ViewModels.Vm
{
    public sealed class TipoIdentificacionViewModel : BaseViewModel
    {
        #region Fields
        private int _idTipoIdentificacion;
        private string _nombre;
        private string _descripcion;
        private string _codigo;
        private int _idPais;
        private ObservableCollection<DTOTipoIdentificacion> _listaTipoIdentificacion;
        private readonly ITipoIdentificacionService _serviceTipoId;
        #endregion

        #region Ctor
        public TipoIdentificacionViewModel()
        {
            ListarTipoIdentificacionCommand = new RelayCommand(async () => await ListarTipoIdentifacion());
            _serviceTipoId = new TipoIdentificacionService();
        }
        #endregion

        #region Properties

        public int IdTipoIdentificacion
        {
            get => _idTipoIdentificacion;
            set => SetProperty(ref _idTipoIdentificacion, value);
        }
        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }
        public string Descripcion
        {
            get => _descripcion;
            set => SetProperty(ref _descripcion, value);
        }
        public string Codigo
        {
            get => _codigo;
            set => SetProperty(ref _codigo, value);
        }
        public int IdPais
        {
            get => _idPais;
            set => SetProperty(ref _idPais, value);
        }

        public ObservableCollection<DTOTipoIdentificacion> ListaTipoIdentificacion
        {
            get => _listaTipoIdentificacion;
            set => SetProperty(ref _listaTipoIdentificacion, value);
        }
        #endregion

        #region Methods
        private async Task ListarTipoIdentifacion()
        {
            IsBusy = true;
            try
            {
                ListaTipoIdentificacion = new ObservableCollection<DTOTipoIdentificacion>
                     (await _serviceTipoId.ListarTiposDeIdentificacion());
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
        public ICommand ListarTipoIdentificacionCommand { get; }
        #endregion
    }
}
