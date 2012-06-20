using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using Service;
using Service.Interfaces;
using Service.Models;

namespace ToolPathGeneratorTests
{
    [TestFixture]
    public class PatherTests
    {
        private readonly MockRepository _mock = new MockRepository();

        private Pather _pather;
        private IPathHelper _pathHelper;

        [SetUp]
        public void Setup()
        {
            _pathHelper = _mock.StrictMock(typeof(IPathHelper)) as IPathHelper;
            _pather = new Pather(_pathHelper);
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
            _pathHelper.Stub(x => x.AppendPaths(Arg<Path>.Is.Anything, Arg<Path>.Is.Anything)).Return(new Path());

            _mock.ReplayAll();
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
