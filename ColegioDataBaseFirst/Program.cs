using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioDataBaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSERTAR
            //ACTUALIZAR
            //ELIMINAR
            //BUSQUEDA O CONSULTA. 

            //AGREGAR UN NUEVO ESTUDIANTE A LA BASE DE DATOS 

            /*
            var NuevoEstudiante = new ESTUDIANTE();
            NuevoEstudiante.Dni = "452178";
            NuevoEstudiante.Nombre = "facundo";
            NuevoEstudiante.Apellido = "Acosta";
            NuevoEstudiante.Telefono = "4587777";
            NuevoEstudiante.CodigoCurso = 1;

            var dbCTX = new ColegioContext();
            dbCTX.ESTUDIANTE.Add(NuevoEstudiante);
            dbCTX.SaveChanges();*/

            //ACTUALIZAR ESTUDIANTE EN LA BASE DE DATOS 

            //LINQ

            /*
            var dbCTX = new ColegioContext();
            var EstudianteActualizar = (from alumno in dbCTX.ESTUDIANTE
                                        where alumno.Dni == "452178"
                                        select alumno).Single();

            EstudianteActualizar.Apellido = "Ager";
            dbCTX.SaveChanges();

            //ELIMINAR ESTUDIANTE EN LA BASE DE DATOS 
            var EstudianteEliminar = (from alumno in dbCTX.ESTUDIANTE
                                        where alumno.Dni == "54545"
                                        select alumno).Single();

            dbCTX.ESTUDIANTE.Remove(EstudianteEliminar);
            dbCTX.SaveChanges();*/


            //CONSULTAR ESTUDIANTE EN LA BASE DE DATOS 
            var dbCTX = new ColegioContext();
            var Alumnos = from alumno in dbCTX.ESTUDIANTE orderby alumno.Nombre ascending select alumno;

            foreach(var estudiante in Alumnos)
            {
                Console.WriteLine(estudiante.Nombre + "  " + estudiante.Apellido);
            }

            Console.ReadLine();

        }
    }
}
