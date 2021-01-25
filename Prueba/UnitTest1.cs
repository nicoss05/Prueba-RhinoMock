using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Prueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SiElJugadorConsigueElPuntajeNecesarioPasaDeNivel()
        {
            var jugador = MockRepository.GenerateStub<IJugador>();
            jugador.Stub(t => t.TotalPuntos()).Return(0.8);

            var level = new Level();
            level.Bono = 1500;
            level.Avanzar(jugador);

            Assert.IsTrue(level.Sipaso);
            jugador.AssertWasCalled(j => j.CantidadPuntos(level.Bono));
            jugador.AssertWasCalled(t => t.TotalPuntos());
        }
        [TestMethod]
        public void SiElJugadorNoConsigueElPuntajeNecesarioNoPasaDeNivel()
        {
            var jugador = MockRepository.GenerateStub<IJugador>();
            jugador.Stub(t => t.TotalPuntos()).Return(0.8);
            
            jugador.PuntuacionTotal = 1300;
            jugador.CantidadPuntos(300);

            var level = new Level();
            level.Bono = 100;
            level.Avanzar(jugador);

            Assert.IsTrue(level.Sipaso);
            jugador.AssertWasCalled(j => j.CantidadPuntos(level.Bono));
            jugador.AssertWasCalled(t => t.TotalPuntos());
        }
        [TestMethod]
        public void SiLaCantidadDePuntosMasELBonoElJugadorPasaDeNivel()
        {
            var jugador = MockRepository.GenerateStub<IJugador>();
            jugador.Stub(t => t.TotalPuntos()).Return(0.8);

            jugador.PuntuacionTotal = 1300;
            jugador.CantidadPuntos(1000);

            var level = new Level();
            level.Bono = 300;
            level.Avanzar(jugador);

            Assert.IsTrue(level.Sipaso);
            jugador.AssertWasCalled(j => j.CantidadPuntos(level.Bono));
            jugador.AssertWasCalled(t => t.TotalPuntos());
        }
    }
}