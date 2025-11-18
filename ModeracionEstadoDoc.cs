using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace estado
{
    internal class ModeracionEstadoDoc : EstadoDoc
    {
        private Documento documento;

        public ModeracionEstadoDoc(Documento documento)
        {
            this.documento = documento;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Imprime {documento.Nombre} en Moderación");
        }

        public void Publicar()
        {
            documento.CambiaEstado(new PublicadoEstadoDoc(documento));
            Console.WriteLine($"Se publicó {documento.Nombre} desde Moderación");
        }
    }
}