using DataLayer;
using EntitiesLayer;
using System.Collections.Generic;

namespace LogicBusinessLayer
{
    public class UserBusiness
    {

        UserData UserData = new UserData();
        public void InsertUser(Usuario usuario)
        {
            UserData.InsertUser(usuario);
        }
        public void UpDateUser(Usuario usuario)
        {
            UserData.UpDateUser(usuario);
        }
        public void DeleteUser(Usuario usuario)
        {
            UserData.DeleteUser(usuario);
        }
        public List<VistaUsuarios_Result> ShowUser()
        {
            return UserData.ShowUsers();
        }
        public Usuario FindUser(int? id)
        {
            return UserData.FindUser(id);
        }
    }
}
