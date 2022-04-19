using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGridView
{
    internal class PersonasDaoObjects
    {
        private List<Persona> listaPersonas = new List<Persona>();

        public PersonasDaoObjects()
        {
            Persona p1 = new Persona { Nombre = "Javier", Mail = "javier@email.com", Genero = "hombre", Telefono = "2228889993", ImagenGenero = "hombre.png" };
            Persona p2 = new Persona { Nombre = "Rebecca", Mail = "rebecca@email.com", Genero = "mujer", Telefono = "2226655447", ImagenGenero = "mujer.png" };
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
        }
        public List<Persona> listar()
        {
            return listaPersonas;   
        }
    }
}
