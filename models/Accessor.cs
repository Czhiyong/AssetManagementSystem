using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

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

        public void CreateUser(Users user)
        {
            session.Save(user);
            session.Flush();
        }


        public void Createassetdelete(assetdelete adelete)
        {
            session.Save(adelete);
            session.Flush();
            
        }
        public void Createassetimformation(assetimformation aimformation)
        {
            session.Save(aimformation);
            session.Flush();

        }
    }
}
