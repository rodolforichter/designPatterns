using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._0_SRP.ViolaSRP
{
    public class GerenciadorRegistroGeral_V1
    {
        public RG _rg;

        public GerenciadorRegistroGeral_V1()
        {
        }

        public RG ProcessDocumento()
        {
            _rg = new RG();
            ConferirDocumentosRg();
            ColetarDigital();
            FotografarParaDocumento();
            ObterNumeroRg();
            ConfeccionarRg();
            return _rg;
        }

        private void FotografarParaDocumento()
        {
            //Obtém fotografia.
        }

        private void ConfeccionarRg()
        {
            //Confeciona rg
        }

        private void ObterNumeroRg()
        {
            //Obtém o próximo número disponível para a rg naquela UF
        }

        private void ColetarDigital()
        {
            //Coleta Digital
        }

        private void ConferirDocumentosRg()
        {
            //Confere documentos de rg
        }
    }
}
