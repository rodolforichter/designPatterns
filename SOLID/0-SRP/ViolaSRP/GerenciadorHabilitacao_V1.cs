using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._0_SRP.ViolaSRP
{
    public class GerenciadorHabilitacao_V1
    {
        public Habilitacao _habilitacao;

        public GerenciadorHabilitacao_V1()
        {
        }

        public Habilitacao ProcessDocumento()
        {
            _habilitacao = new Habilitacao();
            ConferirDocumentosHabilitacao();
            EfetuarProva();
            FotografarParaDocumento();
            ObterNumeroHabilitacao();
            ConfeccionarHabilitacao();
            return _habilitacao;
        }

        private void FotografarParaDocumento()
        {
            //Obtém fotografia
        }

        private void ConfeccionarHabilitacao()
        {
            //Confeciona habilitação
        }

        private void ObterNumeroHabilitacao()
        {
            //Obtém o próximo número disponível para a habilitação naquela UF
        }

        private void EfetuarProva()
        {
            //Encaminha prova online
        } 

        private void ConferirDocumentosHabilitacao()
        {
            //Confere documentos de habilitação
        }
    }
}
