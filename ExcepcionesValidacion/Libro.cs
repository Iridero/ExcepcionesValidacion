using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesValidacion
{
    public class Libro
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El valor no debe estar vacío", "Titulo");
                }
                titulo = value;
            }
        }

        private ushort paginas;

        public ushort Paginas
        {
            get { return paginas; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El valor debe ser mayor a cero", "Paginas");
                }
                paginas = value;
            }
        }

        private string autor;

        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El valor no debe estar vacío", "Autor");
                }
                autor = value;
            }
        }

        private string editorial;

        public string Editorial
        {
            get { return editorial; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El valor no debe estar vacío", "Editorial");
                }
                editorial = value;
            }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor no puede ser negativo", "precio");
                }
                precio = value;
            }
        }

        public byte Existencias { get; set; }

        private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (value.Trim().Length != 13 && value.Trim().Length != 10)
                {
                    throw new ArgumentException("La longitud debe ser de 10 o 13 caracteres", "Isbn");
                }
                long x = 0;
                if (!long.TryParse(value, out x))
                {
                    throw new ArgumentException("El valor debe contener solo dígitos", "Isbn");
                }
                isbn = value;
            }
        }
        private ushort año;

        public ushort Año
        {
            get { return año; }
            set
            {
                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException("El valor del año no puede ser posterior al año actual");
                }
                año = value;
            }
        }

    }
}
