using DataLayer;
using EntitiesLayer;
using System.Collections.Generic;

namespace LogicBusinessLayer
{
    public class DepartamentosBusiness
    {
        DepartamnetosData departamnetosData = new DepartamnetosData();

        public void InsertDepartments(Departamento departamento)
        {
            departamnetosData.InsertDeparment(departamento);
        }

        public Departamento FindDepartamento(int? id)
        {
            return departamnetosData.FindDeparment(id);
        }
        public void UpDateDepartments(Departamento departamento)
        {
            departamnetosData.UpDateDeparment(departamento);
        }
        public void DeleteDepartments(Departamento departamento)
        {
            departamnetosData.DeleteDeparment(departamento);
        }
        public List<Departamento> ShowDepartments()
        {
            return departamnetosData.ShowDeparmentes();
        }
    }
}
