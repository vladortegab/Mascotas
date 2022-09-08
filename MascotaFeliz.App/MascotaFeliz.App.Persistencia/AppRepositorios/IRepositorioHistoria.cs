
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistorias();
        Dueno AddHistoria(Historia historia);
        Dueno UpdateHistoria(Historia historia);
        void DeleteHistoria(int idHistoria);
        Dueno GetHistoria(int idHistoria);
        IEnumerable<Historia> GetHistoriasPorFiltro(string filtro);
    }
}