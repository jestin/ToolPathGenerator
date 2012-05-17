using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using Service;
using Service.Models;

namespace TestBlockerTests
{
    [TestFixture]
    public class PatherTests
    {
        private readonly MockRepository _mock = new MockRepository();

        private Pather _pather;

        [SetUp]
        public void Setup()
        {
            _pather = new Pather();
        }

        [TearDown]
        public void TearDown()
        {
            _mock.BackToRecordAll();
        }

        // ReSharper disable InconsistentNaming

        [Test]
        public void GeneratePath_Succeeds()
        {
            _pather.GeneratePath(GetLayerList());
        }

        [Test]
        public void GeneratePath_Single_Layer_Succeeds()
        {
            _pather.GeneratePath(GetLayerListSingleLayer());
        }

        [Test]
        public void GeneratePath_No_Layers_Succeeds()
        {
            _pather.GeneratePath(GetEmptyLayerList());
        }

        // ReSharper restore InconsistentNaming

        private IEnumerable<Layer> GetLayerList()
        {
            return new List<Layer>
            {
                new Layer(),
                new Layer(),
                new Layer(),
                new Layer(),
                new Layer(),
                new Layer(),
                new Layer(),
                new Layer(),
                new Layer()
            };
        }

        private IEnumerable<Layer> GetLayerListSingleLayer()
        {
            return new List<Layer>
            {
                new Layer()
            };
        }

        private IEnumerable<Layer> GetEmptyLayerList()
        {
            return new List<Layer>();
        }
    }
}
