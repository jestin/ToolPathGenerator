using NUnit.Framework;
using Rhino.Mocks;
using Service;
using Service.Models;

namespace TestBlockerTests
{
    [TestFixture]
    public class SlicerTests
    {
        private readonly MockRepository _mock = new MockRepository();

        private Slicer _slicer;

        [SetUp]
        public void Setup()
        {
            _slicer = new Slicer();
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
