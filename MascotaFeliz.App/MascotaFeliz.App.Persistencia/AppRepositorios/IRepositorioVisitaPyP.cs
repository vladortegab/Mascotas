using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        IEnumerable<VisitaPyP> GetAllVisitaPyPs();
        Dueno AddVisitaPyP(VisitaPyP visitaPyP);
        Dueno UpdateVisitaPyP(VisitaPyP visitaPyP);
        void DeleteVisitaPyP(int idVisitaPyP);
        Dueno GetVisitaPyP(int idVisitaPyP);
        IEnumerable<VisitaPyP> GetVisitaPyPsPorFiltro(string filtro);
    }
}