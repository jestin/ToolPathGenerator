using NUnit.Framework;
using Rhino.Mocks;
using Service;
using Service.Interfaces;
using Service.Models;

namespace TestBlockerTests
{
    [TestFixture]
    public class SlicerTests
    {
        private readonly MockRepository _mock = new MockRepository();

        private Slicer _slicer;
        private IMeshHelper _meshHelper;
        private IGeometryHelper _geometryHelper;

        [SetUp]
        public void Setup()
        {
            _meshHelper = _mock.StrictMock(typeof(IMeshHelper)) as IMeshHelper;
            _geometryHelper = _mock.StrictMock(typeof(IGeometryHelper)) as IGeometryHelper;

            _slicer = new Slicer(_meshHelper, _geometryHelper);
        }

        [TearDown]
        public void TearDown()
        {
            _mock.BackToRecordAll();
        }

        // ReSharper disable InconsistentNaming

        [Test]
        public void Slice_Succeeds()
        {
            _slicer.Slice(new Mesh());
        }

        // ReSharper restore InconsistentNaming
    }
}
