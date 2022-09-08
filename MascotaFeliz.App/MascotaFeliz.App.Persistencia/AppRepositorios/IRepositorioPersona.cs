
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Dueno AddPersona(Persona persona);
        Dueno UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Dueno GetPersona(int idPersona);
        IEnumerable<Persona> GetPersonasPorFiltro(string filtro);
    }
}