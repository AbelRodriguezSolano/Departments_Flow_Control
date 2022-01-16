using EntitiesLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class CodigoDocumentoData
    {
        DocumentsControlEntities documentsControl = new DocumentsControlEntities();
        public void InsertDocuementsCode(Codigo_Documento codigoDocumento)
        {
            documentsControl.Codigo_Documento.Add(codigoDocumento);
            documentsControl.SaveChanges();
        }
        public List<VistaSecuencia_Result> ShowDocumentsCode()
        {
            return documentsControl.VistaSecuencia().ToList();
        }
        public void DeleteDocuementsCode(Codigo_Documento codigoDocumento)
        {
            var registro = documentsControl.Codigo_Documento.Find(codigoDocumento.ID);
            documentsControl.Codigo_Documento.Remove(registro);
            documentsControl.SaveChanges();
        }
        public void UpDateDocuementsCode(Codigo_Documento codigoDocumento)
        {
            var registro = documentsControl.Codigo_Documento.Find(codigoDocumento.ID);
            registro.FechaDoc = codigoDocumento.FechaDoc;
            registro.UserCorreo = codigoDocumento.UserCorreo;
            registro.Departamento_Origen = codigoDocumento.Departamento_Origen;
            registro.Departamento_Destino = codigoDocumento.Departamento_Destino;
            documentsControl.SaveChanges();
        }
        public Codigo_Documento FindCodigo(int? id)
        {
            return documentsControl.Codigo_Documento.Find(id);
        }
    }
}
