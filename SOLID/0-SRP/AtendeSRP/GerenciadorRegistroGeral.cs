using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._0_SRP.AtendeSRP
{
    public class GerenciadorRegistroGeral
    {
        #region Attributes

        private RG _rg;

        #endregion

        #region DI

        private readonly IColetorDigital _coletorDigital;
        private readonly IConferenciaDocumentosPoupaTempo _conferenciaDocumentosPoupaTempo;
        private readonly IGraficaPoupaTempo _graficaPoupaTempo;
        private readonly IRegistroGeralServices _registroGeralServices;
        private readonly IEstudioFotografiaPoupaTempo _estudioFotografiaPoupaTempo;

        #endregion

        public GerenciadorRegistroGeral(IColetorDigital coletorDigital,
                                        IConferenciaDocumentosPoupaTempo conferenciaDocumentosPoupaTempo,
                                        IGraficaPoupaTempo graficaPoupaTempo,
                                        IRegistroGeralServices registroGeralServices,
                                        IEstudioFotografiaPoupaTempo estudioFotografiaPoupaTempo)
        {
            _coletorDigital = coletorDigital;
            _conferenciaDocumentosPoupaTempo = conferenciaDocumentosPoupaTempo;
            _graficaPoupaTempo = graficaPoupaTempo;
            _registroGeralServices = registroGeralServices;
            _estudioFotografiaPoupaTempo = estudioFotografiaPoupaTempo;
        }

        public RG ProcessDocumento()
        {           
            if (_conferenciaDocumentosPoupaTempo.IsValid())
            {
                _rg = new RG();
                _rg.Digital = _coletorDigital.Coletar();
                _rg.Numero = _registroGeralServices.GetNumero();
                _rg.Fotografia = _estudioFotografiaPoupaTempo.GetFotoDocumento();
                _rg.DocumentoImagem = _graficaPoupaTempo.GetDocumentoImagem();                
                return _rg;
            }
            else
            {
                throw new Exception("Documentos inválidos para prosseguir.");
            }
        }
    }
}
