using SOLID._0_SRP.AtendeSRP.Interfaces;
using System;

namespace SOLID._0_SRP.AtendeSRP
{
    public class GerenciadorHabilitacao
    {
        #region Attributes

        private Habilitacao _habilitacao;

        #endregion

        #region DI

        private readonly IProvaDetran _provaDetran;
        private readonly IConferenciaDocumentosPoupaTempo _conferenciaDocumentosPoupaTempo;
        private readonly IGraficaPoupaTempo _graficaPoupaTempo;
        private readonly IHabilitacaoServices _habilitacaoServices;
        private readonly IEstudioFotografiaPoupaTempo _estudioFotografiaPoupaTempo;

        #endregion

        public GerenciadorHabilitacao(IProvaDetran provaDetran,
                                        IConferenciaDocumentosPoupaTempo conferenciaDocumentosPoupaTempo,
                                        IGraficaPoupaTempo graficaPoupaTempo,
                                        IHabilitacaoServices habilitacaoServices,
                                        IEstudioFotografiaPoupaTempo estudioFotografiaPoupaTempo)
        {
             _provaDetran = provaDetran;
            _conferenciaDocumentosPoupaTempo = conferenciaDocumentosPoupaTempo;
            _graficaPoupaTempo = graficaPoupaTempo;
            _habilitacaoServices = habilitacaoServices;
            _estudioFotografiaPoupaTempo = estudioFotografiaPoupaTempo;
        }

        public Habilitacao ProcessDocumento()
        {
            if (_conferenciaDocumentosPoupaTempo.IsValid())
            {
                _habilitacao = new Habilitacao();
                _provaDetran.Executar();
                if (_provaDetran.ResultadoOK())
                {
                    _habilitacao.Numero = _habilitacaoServices.GetNumero();
                    _habilitacao.Fotografia = _estudioFotografiaPoupaTempo.GetFotoDocumento();
                    _habilitacao.DocumentoImagem = _graficaPoupaTempo.GetDocumentoImagem();
                }
                else
                {
                    throw new Exception("Não passou na Prova.");
                }
                return _habilitacao;
            }
            else
            {
                throw new Exception("Documentos inválidos para prosseguir.");
            }
        }
    }
}
