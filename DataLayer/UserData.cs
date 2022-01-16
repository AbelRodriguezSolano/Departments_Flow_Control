using EntitiesLayer;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class UserData
    {
        DocumentsControlEntities documentsControl = new DocumentsControlEntities();
        public void InsertUser(Usuario usuario)
        {
            documentsControl.Usuarios.Add(usuario);
            documentsControl.SaveChanges();
        }
        public List<VistaUsuarios_Result> ShowUsers()
        {

            return documentsControl.VistaUsuarios().ToList(); ;
        }
        public void DeleteUser(Usuario usuario)
        {
            var registro = documentsControl.Usuarios.Find(usuario.ID);
            documentsControl.Usuarios.Remove(registro);
            documentsControl.SaveChanges();
        }
        public void UpDateUser(Usuario usuario)
        {
            var registro = documentsControl.Usuarios.Find(usuario.ID);
            registro.Nombre = usuario.Nombre;
            registro.Correo = usuario.Correo;
            registro.Departamento = usuario.Departamento;
            registro.Cargo = usuario.Cargo;
            documentsControl.SaveChanges();
        }
        public Usuario FindUser(int? id)
        {
            return documentsControl.Usuarios.Find(id);
        }
    }
}
