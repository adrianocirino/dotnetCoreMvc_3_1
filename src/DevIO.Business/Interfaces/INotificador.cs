using System.Collections.Generic;
using DevIO.Business.Notificacoes;

namespace DevIO.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> obterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
