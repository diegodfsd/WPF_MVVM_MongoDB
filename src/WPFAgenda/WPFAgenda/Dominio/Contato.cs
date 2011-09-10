using System;
using MvvmFoundation.Wpf;

namespace WPFAgenda.Dominio
{
    public class Contato : ObservableObject, IEquatable<Contato>
    {
        private string _email;
        private string _nome;
        private string _sobrenome;
        private string _twitter;

        public Guid Id { get; private set; }
     
        public string Email
        {
            get { return _email; } 
            set 
            { 
                _email = value;
                NotificarAlteracao("Email");
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            { 
                _nome = value;
                NotificarAlteracao("Nome");
            }
        }

        public string Sobrenome
        {
            get { return _sobrenome; }
            set 
            { 
                _sobrenome = value;
                NotificarAlteracao("Sobrenome");
            }
        }

        public String Twitter
        {
            get { return _twitter; }
            set 
            {
                _twitter = value;
                NotificarAlteracao("Twitter");
            }
        }

        public Contato()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(Contato other)
        {
            return other != null && other.Email.Equals(Email);
        }

        public override bool Equals(object other)
        {
            return base.Equals(other as Contato);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }

        private void NotificarAlteracao(string nomePropriedade)
        {
            RaisePropertyChanged(nomePropriedade);
        }
    }
}
