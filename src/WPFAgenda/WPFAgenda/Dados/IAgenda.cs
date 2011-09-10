using System;
using System.Collections.Generic;
using WPFAgenda.Dominio;

namespace WPFAgenda.Dados
{
    public interface IAgenda
    {
        IList<Contato> Todos();
        Contato Detalhe(Guid id);
        void Salvar(Contato contato);
    }
}