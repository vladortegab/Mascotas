using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioPersona _repoPersona = new RepositorioPerson(new Persistencia.AppContext());
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());




        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos vamos a empezar a trabajar con las tablas");
                       
            //ListarDuenosFiltro();      
            AddDueno();
            //BuscarDueno(2);

            //ListarVeterinariosFiltro();
            AddVeterinario();
            //BuscarVeterinario(1);
            
           
            //ListarHistoriaFiltro();
            AddHistoria();
            //BuscarHistoria(1);     

            
            //ListarMascotaFiltro();
            AddMascota();
            //BuscarMascota(1);

            //ListarPersonaFiltro();
            AddPersona();
            //BuscarPersona(1);

            //ListarVisitasPyPFiltro();
            AddVisitasPyP();
            //BuscarVisitasPyP(1);
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Luis Felipe",
                Apellidos = "Fadul", 
                Direccion = "Calle 1 # 1-15",
                Telefono = "4564564566",
                Correo = "fadulitomenor@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Peter",
                Apellidos = "Pan", 
                Direccion = "Transversal 9 # 17A-155",
                Telefono = "3363365858",
                TarjetaProfesional = "TP52546"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos);
        }

        private static void ListarDuenosFiltro()
        {
            var duenosM = _repoDueno.GetDuenosPorFiltro("Fel");
            foreach (Dueno p in duenosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        private static void ListarVeterinariosFiltro()
        {
            var veterinariosM = _repoVeterinario.GetVeterinariosPorFiltro("e");
            foreach (Veterinario p in veterinariosM)
            {
                Console.WriteLine(p.Nombres + " " + p.Apellidos);
            }

        }

        private static void AddHistoria()
        {
            var historia = new Historia
            {
                Observacion = "Enfermerdad Ojos",
                Hoja = "2", 
                Revicion = "Transversal 9 # 17A-155",
                Fecha = "3363365858",
                TarjetaProfesional = "TP52546"
            };
            _repoHistoria.AddHistoria(historia);
        }

        
        
    }
}
