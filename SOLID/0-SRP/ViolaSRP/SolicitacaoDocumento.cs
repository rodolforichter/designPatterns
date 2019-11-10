using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._0_SRP.ViolaSRP
{
    public class SolicitacaoDocumento
    {
        private TipoSolicitacaoDocumento _tipoSolicitacaoDocumento;
        private Documento _documento;

        public SolicitacaoDocumento(TipoSolicitacaoDocumento tipoSolicitacaoDocumento)
        {
            _tipoSolicitacaoDocumento = tipoSolicitacaoDocumento;
        }

        public Documento ProcessDocumento()
        {
            if (_tipoSolicitacaoDocumento.Equals(TipoSolicitacaoDocumento.RG)){
                _documento = new RG();
                ConferirDocumentosRg();
                ColetarDigital();
                FotografarParaDocumento();
                ObterNumeroRg();
                ConfeccionaRg();
            }
            else
            {
                _documento = new Habilitacao();
                ConferirDocumentosHabilitacao();
                EfetuarProva();
                FotografarParaDocumento();
                ObterNumeroHabilitacao();
                ConfeccionaHabilitacao();
            }

            return _documento;
        }

        private void FotografarParaDocumento()
        {
            //Obtém a fotografia para o documento
        }

        private void ConfeccionaRg()
        {
            //Confeciona rg impresso
        }

        private void ConfeccionaHabilitacao()
        {
            //Confeciona habilitação impressa
        }

        private void ObterNumeroHabilitacao()
        {
            //Obtém o próximo número disponível para a habilitação naquela UF
        }

        private void ObterNumeroRg()
        {
            //Obtém o próximo número disponível para a rg naquela UF
        }

        private void EfetuarProva()
        {
            //Encaminha prova online
        }

        private void ColetarDigital()
        {
            //Coleta Digital
        }

        private void ConferirDocumentosHabilitacao()
        {
            //Confere documentos de habilitação
        }

        private void ConferirDocumentosRg()
        {
            //Confere documentos de rg
        }
    }
}
