using DataLayer;
using EntitiesLayer;
using System.Collections.Generic;

namespace LogicBusinessLayer
{
    public class CodigoDocumentoBusiness
    {
        CodigoDocumentoData codigoDocumento = new CodigoDocumentoData();

        public void InsertDocumentCode(Codigo_Documento codigo_Documento)
        {
            codigoDocumento.InsertDocuementsCode(codigo_Documento);
        }
        public void UpDateDocumentCode(Codigo_Documento codigo_Documento)
        {
            codigoDocumento.UpDateDocuementsCode(codigo_Documento);
        }
        public void DeleteDocumentCode(Codigo_Documento codigo_Documento)
        {
            codigoDocumento.DeleteDocuementsCode(codigo_Documento);
        }
        public List<VistaSecuencia_Result> ShowDocumentsCode()
        {
            return codigoDocumento.ShowDocumentsCode();
        }
        public Codigo_Documento FindCodigo(int? id)
        {
            return codigoDocumento.FindCodigo(id);
        }
    }
}
