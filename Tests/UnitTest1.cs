using NUnit.Framework;
using SIGSE.Context;
using SIGSE.Entities;
using SIGSE.SessionManager;

namespace Tests
{
    public class Tests
    {

        Sesion sesion;
        SigseContext context;

        [SetUp]
        public void Setup()
        {
            sesion = Sesion.obtenerSesion();
            context = SigseContext.obtenerInstancia();
        }

        [Test]
        public void Test1()
        {
            Usuario user = sesion.loguearseConUsuarioContraseña(context, "asd", "123");
            Assert.IsNull(user);
        }

        [Test]
        public void Test2()
        {
            Usuario user = sesion.loguearseConUsuarioContraseña(context, "celi", "2323");
            Assert.IsNull(user);
        }

        [Test]
        public void Test3()
        {
            Usuario user = sesion.loguearseConUsuarioContraseña(context, "celi", "123");
            Assert.IsNotNull(user);
        }
    }
}