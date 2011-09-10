using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using MvvmFoundation.Wpf;
using WPFAgenda.Dados;
using WPFAgenda.Dominio;
using WPFAgenda.Views;

namespace WPFAgenda.ViewModels
{
    public class TodosContatosViewModel : ObservableObject
    {
        private RelayCommand _novo;
        private RelayCommand<Contato> _detalhe;

        public TodosContatosViewModel()
        {
            CarregarContatos();
        }

        public ICommand NovoCommand
        {
            get { return _novo ?? (_novo = new RelayCommand(Novo)); }
        }

        public ICommand DetalheCommand
        {
            get { return _detalhe ?? (_detalhe = new RelayCommand<Contato>(Detalhe)); }
        }

        private void Detalhe(Contato contato)
        {
            MessageBox.Show(
                "Editar", 
                "Editar", 
                MessageBoxButton.OK, 
                MessageBoxImage.Information);
        }

        public ObservableCollection<Contato> Contatos { get; private set; }

        private void Novo()
        {
            var contatoView = new ContatoView {DataContext = new ContatoViewModel()};
        	contatoView.Show();
            contatoView.Focus();
        }

        private void CarregarContatos()
        {
			using (var agenda = new Agenda())
			{
				Contatos = new ObservableCollection<Contato>(agenda.Todos());
			}
        }
    }
}
