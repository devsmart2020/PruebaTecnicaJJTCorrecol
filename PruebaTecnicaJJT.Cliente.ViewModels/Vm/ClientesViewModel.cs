using Microsoft.Toolkit.Mvvm.Input;
using PruebaTecnica.Cliente.Services.Implementation;
using PruebaTecnica.Cliente.Services.Interfaces;
using PruebaTecnicaJJT.Business.DTOs;
using PruebaTecnicaJJT.Cliente.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PruebaTecnicaJJT.Cliente.ViewModels.Vm
{
    public sealed class ClientesViewModel : BaseViewModel
    {
        #region Fields
        private int _idCliente;
        private int _idTipoDocumento;
        private string _nombres;
        private string _apellidos;
        private string _email;
        private string _telefono;
        private string _razonSocial;
        private string _telAlterno;
        private int _idPais;
        private int _idDepartamento;
        private int _idMunicipio;
        private readonly IClienteService _service;
        private ObservableCollection<DTOClientesGetAll> _listadoClientes;
        private DTOClientes _clienteEntidad;
        #endregion

        #region Ctor
        public ClientesViewModel()
        {
            CrearClienteCommand = new RelayCommand(async () => await CrearoActualizarCliente());
            ListarClientesCommand = new RelayCommand(async () => await ListarClientes());
            EliminarClienteCommand = new RelayCommand(async () => await EliminarCliente());
            _service = new ClienteService();
            //ListarClientes().ConfigureAwait(true);
        }
        #endregion

        #region Properties

        public int IdCliente
        {
            get => _idCliente;
            set => SetProperty(ref _idCliente, value);
        }

        public int IdTipoDocumento
        {
            get => _idTipoDocumento;
            set => SetProperty(ref _idTipoDocumento, value);
        }

        private string _numeroDocumento;

        public string NumeroDocumento
        {
            get => _numeroDocumento;
            set => SetProperty(ref _numeroDocumento, value);
        }

        public string Nombres
        {
            get => _nombres;
            set => SetProperty(ref _nombres, value);
        }

        public string Apellidos
        {
            get => _apellidos;
            set => SetProperty(ref _apellidos, value);
        }

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string Telefono
        {
            get => _telefono;
            set => SetProperty(ref _telefono, value);
        }


        public string TelAlterno
        {
            get => _telAlterno;
            set => SetProperty(ref _telAlterno, value);
        }

        public string RazonSocial
        {
            get => _razonSocial;
            set => SetProperty(ref _razonSocial, value);
        }


        public int IdPais
        {
            get => _idPais;
            set => SetProperty(ref _idPais, value);
        }

        public int IdDepartamento
        {
            get => _idDepartamento;
            set => SetProperty(ref _idDepartamento, value);
        }

        public int IdMunicipio
        {
            get => _idMunicipio;
            set => SetProperty(ref _idMunicipio, value);
        }

        public ObservableCollection<DTOClientesGetAll> ListadoClientes
        {
            get => _listadoClientes;
            set => SetProperty(ref _listadoClientes, value);
        }


        public DTOClientes ClienteEntidad
        {
            get => _clienteEntidad;
            set => SetProperty(ref _clienteEntidad, value);
        }


        #endregion

        #region Methods
        private async Task CrearoActualizarCliente()
        {
            IsBusy = true;
            try
            {
                DTOClientes cliente = new()
                {
                    ClnId = default,
                    ClnTpoId = IdTipoDocumento,
                    ClnNumeroIdentificacion = NumeroDocumento,
                    ClnNombres = Nombres,
                    ClnApellidos = Apellidos,
                    ClnEmail = Email,
                    ClnTelefono = Telefono,
                    ClnTelefonoAlterno = TelAlterno,
                    ClnRazonSocial = RazonSocial,
                    ClnPaisCodigo = IdPais,
                    ClnDptColCodigoDane = IdDepartamento,
                    ClnDvsPltColCodigoDane = IdMunicipio
                };

                if (cliente != null)
                {
                    bool query = await _service.CrearActualizarCliente(cliente);
                    if (query)
                    {
                        Msj = "Datos registrados con éxito";
                    }
                    else
                    {
                        Msj = "Ocurrió un error al intentar guardar los datos, por favor verifique que todo esté debidamente diligenciado";

                    }
                }
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async Task ListarClientes()
        {
            IsBusy = true;
            try
            {
                ListadoClientes = new ObservableCollection<DTOClientesGetAll>(await _service.ListarClientes());
            }
            catch (Exception ex)
            {
                Msj = ex.Message;

                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }


        private async Task EliminarCliente()
        {
            IsBusy = true;
            try
            {
                bool query = await _service.EliminarCliente(IdCliente);
                if (query)
                {
                    Msj = "Cliente eliminado con éxito";
                }
                else
                {
                    Msj = "Error al eliminar el Cliente";
                    return;
                }
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
        #endregion

        #region Commands
        public ICommand CrearClienteCommand { get; }
        public ICommand ListarClientesCommand { get; }
        public ICommand EliminarClienteCommand { get; }
        #endregion
    }
}
