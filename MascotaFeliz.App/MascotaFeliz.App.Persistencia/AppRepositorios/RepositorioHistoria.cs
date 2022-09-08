using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{

    public class RepositorioHistoria : IRepositorioHistoria
    {
        /// <summary>
        /// Referencia al contexto de Historia
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }


        public Historia AddHistoria(Historia historia)
        {
            var historiaAdicionado = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionado.Entity;

        }

        public void DeleteHistoria(int idHistoriao)
        {
            var historiaEncontrado = _appContext.Historia.FirstOrDefault(d => d.Id == idhistoria);
            if (historiaEncontrado == null)
                return;
            _appContext.Historias.Remove(historiaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Historia> GetAllHistorias()
        {
            return GetAllHistorias_();
        }

        public IEnumerable<Historia> GetHistoriasPorFiltro(string filtro)
        {
            var historias = GetAllHistorias(); // Obtiene todos los saludos
            if (historia != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    historia = historia.Where(s => s.Nombres.Contains(filtro));
                }

            }
            return historia;

        }

        public IEnumerable<Historia> GetAllHistorias_()
        {
            return _appContext.Veterinarios;
        }

        public Historia GetHistoria(int idHistoria)
        {
            return _appContext.Historias.FirstOrDefault(d => d.Id == idHistoria);
        }

        public Historia UpdateHistoria(Historia historia)
        {
            var historiaEncontrado = _appContext.Historia.FirstOrDefault(d => d.Id == historia.Id);
            if (historiaEncontrado != null)
            {
                historiaEncontrado.Nombres = historia.Nombres;
                veterinarioEncontrado.Apellidos = historia.Apellidos;
               

                historiaEncontrado.Direccion = historia.Direccion;
                historiaEncontrado.Telefono = historia.Telefono;
                historiaEncontrado.TarjetaProfesional = historia.TarjetaProfesional;
                






                _appContext.SaveChanges();


            }
            return historiaEncontrado;
        }
    }
}
    