using EntitiesLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class DepartamnetosData
    {
        DocumentsControlEntities documentsControl = new DocumentsControlEntities();

        public void InsertDeparment(Departamento departamento)
        {
            documentsControl.Departamentoes.Add(departamento);
            documentsControl.SaveChanges();
        }

        public Departamento FindDeparment(int? id)
        {
            return documentsControl.Departamentoes.Find(id);
        }
        public List<Departamento> ShowDeparmentes()
        {
            return documentsControl.Departamentoes.ToList();
        }
        public void DeleteDeparment(Departamento departamento)
        {
            var registro = documentsControl.Departamentoes.Find(departamento.ID);
            documentsControl.Departamentoes.Remove(registro);
            documentsControl.SaveChanges();
        }
        public void UpDateDeparment(Departamento departamento)
        {
            var registro = documentsControl.Departamentoes.Find(departamento.ID);
            registro.Nombre = departamento.Nombre;
            registro.Siglas = departamento.Siglas;
            documentsControl.SaveChanges();
        }
    }
}
