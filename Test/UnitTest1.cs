using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using models;


namespace Test
{
    /// <summary>
    /// UnitTest1 的摘要说明
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion



        //[TestMethod]
        //public void TestMethod2()
        //{
        //    Accessor accessor = Accessor.Instance;
        //    Users user = new Users { id = 0, name = "abc", role = "abc" ,password = 123456 ,email = "1548@.com"};
        //    accessor.CreateUser(user);
        //}


        //[TestMethod]
        //public void TestMethod4()
        //{
        //    Accessor accessor = Accessor.Instance;
        //    assetdelete adelete = new assetdelete { id = 0, name = "abc", safedepartment = "12", deleteperson = "oii", deletedate = "20120514", type = "eii" };
        //    accessor.Createassetdelete(adelete);
        //}
        //[TestMethod]
        //public void TestMethod5()
        //{
        //    Accessor accessor = Accessor.Instance;
        //    assetimformation aimformation = new assetimformation
        //    {
        //        id = 0,
        //        name = "abc",
        //        buydate = "20120525",
        //        sort = "oii",
        //        amount = 2154,
        //        price = 566,
        //        safedepartment = "eii",
        //        safeplace = "eii",
        //        usedepatment = "wieg",
        //        depreciation = "eii"
        //    };
        //    accessor.Createassetimformation(aimformation);
        //}

        //[TestMethod]
        //public void TestMethod7()
        //{
        //    Accessor accessor = Accessor.Instance;
        //    Users user = accessor.GetUsersById(0);
        //    user.email = "gefeg";
        //    user.name = "ziji";
        //    accessor.UpdateUsers(user);
        //}
        //[TestMethod]
        ////public void TestMethod8()
        ////{
        ////    Accessor accessor = Accessor.Instance;
        ////    IList<Users> s = accessor.GetUsersByFirstname("ziji");
        ////    Assert.AreEqual(2, s.Count);
            
        ////}
    }
}
