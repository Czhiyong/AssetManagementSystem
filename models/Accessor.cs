using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;

namespace models
{
    public class Accessor
    {
        private ISession session;
        private static Accessor instance = null;
        private Accessor()
        {
            session = (new Configuration()).Configure().BuildSessionFactory().OpenSession();
        }
       
        public static Accessor Instance 
        {
            get {
                if (  instance == null )
                    instance = new Accessor();
                return instance;
            }
        }

        public void CreateUser(Users user) //保存用户信息
        {
            session.Save(user);
            session.Flush();
        }
        public Users GetUsersById(int UsersId) //以用户ID号获取一个用户实例
        {
            return session.Get<Users>(UsersId);
        }
        public void DeleteUsers(Users user) //删除用户信息
        {
            session.Delete(user);
            session.Flush();
        }
        public void UpdateUsers(Users user) //更新用户信息
        {
            session.Update(user);
            session.Flush();
        }
        public IList<Users> CreateCriteria()
        {
            ICriteria crit = session.CreateCriteria(typeof(Users));
            crit.SetMaxResults(50);
            IList<Users> user = crit.List<Users>();
            return user;
        }
        public IList<Users> GetUsersByFirstname(string firstname)
        {
            return session.CreateCriteria(typeof(Users))
               .Add(Restrictions.Eq("name", firstname))
               .List<Users>();
        }


        public void Createassetdelete(assetdelete adelete)  //保存表格assetdelete信息
        {
            session.Save(adelete);
            session.Flush();
        }
        public assetdelete GetassetdeleteById(int id) //以用户ID号获取一个实例
        {
            return session.Get<assetdelete>(id);
        }
        public void Deleteassetdelete(assetdelete adelete) //删除表格信息
        {
            session.Delete(adelete);
            session.Flush();
        }
        public void Updateassetdelete(assetdelete adelete) //更新表格信息
        {
            session.Update(adelete);
            session.Flush();
        }



        public void Createassetimformation(assetimformation aimformation) //保存表格assetdelete信息
        {
            session.Save(aimformation);
            session.Flush();
        }
        public assetimformation GetassetimformationById(int id) //以用户ID号获取一个实例
        {
            return session.Get<assetimformation>(id);
        }
        public void Deleteassetdelete(assetimformation aimformation) //删除表格信息
        {
            session.Delete(aimformation);
            session.Flush();
        }
        public void Updateassetdelete(assetimformation aimformation) //更新表格信息
        {
            session.Update(aimformation);
            session.Flush();
        }
        public IList<assetimformation> CreateCriteria2()  
        {
            ICriteria crit2 = session.CreateCriteria(typeof(assetimformation));
            crit2.SetMaxResults(100);
            IList<assetimformation> asset = crit2.List<assetimformation>();
            return asset;
        }
        public IList<assetimformation> GetAssetByDepartmentname(string Departmentname)
        {
            return session.CreateCriteria(typeof(assetimformation))
               .Add(Restrictions.Eq("safedepartment", Departmentname))
               .List<assetimformation>();
        }


       
    }
}
