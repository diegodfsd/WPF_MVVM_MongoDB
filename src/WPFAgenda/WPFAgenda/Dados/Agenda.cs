using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using WPFAgenda.Dominio;

namespace WPFAgenda.Dados
{
    public class Agenda : IAgenda, IDisposable
    {
        private const string URL_MONGO = "mongodb://localhost";
        private const string NOME_DB = "db-agenda";
    	private MongoServer _server;
        private MongoDatabase _db;

    	public Agenda()
    	{
    		_server = MongoServer.Create(URL_MONGO);
			_server.Connect();
    	}

    	public IList<Contato> Todos()
    	{
    		return Db()
    			.GetCollection<Contato>("contatos")
    			.FindAll()
				.ToList();
    	}

        public Contato Detalhe(Guid id)
        {
            return Db()
					.GetCollection<Contato>("contatos")
					.FindOne(Query.EQ("Id", id));
        }

        public void Salvar(Contato contato)
        {
			Db().GetCollection<Contato>("contatos").Save(contato);
        }

    	public void Dispose()
    	{
    		_server.Disconnect();
    	}

		private MongoDatabase Db()
		{
			return _db ?? (_db = _server.GetDatabase(NOME_DB));
		}
    }
}
