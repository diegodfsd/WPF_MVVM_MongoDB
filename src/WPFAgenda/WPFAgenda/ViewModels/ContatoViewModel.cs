using System.Windows.Input;
using MvvmFoundation.Wpf;
using WPFAgenda.Dados;
using WPFAgenda.Dominio;

namespace WPFAgenda.ViewModels
{
    public class ContatoViewModel : ObservableObject
    {
        private Contato _contato;
        private RelayCommand _salvar;


        public ICommand SalvarCommand
        {
            get { return _salvar ?? (_salvar = new RelayCommand(Salvar)); }
        }

        public Contato Contato
        {
            get { return _contato ?? (_contato = new Contato()); }
            set { 
                _contato = value;
                RaisePropertyChanged("Contato");
            }
        }

        private void Salvar()
        {
        	using (var agenda = new Agenda())
        	{
				agenda.Salvar(_contato);	
        	}
        }
    }
}
