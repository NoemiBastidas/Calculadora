using System;

    namespace multiplicidad;
{

    public class Estudiante
    {
       public string nombre;
       public string apellido;
       public string cedula;
        
        public Estudiante (string dato1, string dato2, string dato3 )
        {
            nombre= dato1;
            apellido= dato2;
            cedula= dato2;
        }  
    }

    
    public class Materias
    {
        string nombreMateria;
        string docente;
        public Materias (string materia, string profesor)
        {
            nombreMateria= materia;
            docente= profesor;
        }

        public class Campus
        {
            string norte;
            string centro;
            string sur;
            public Campus (string nor, string cent, string sour)
        {
            norte= nor;
            centro= cent;
            sur= sour;
        }

        }


    }
}