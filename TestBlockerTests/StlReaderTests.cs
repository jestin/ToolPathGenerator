using NUnit.Framework;
using Rhino.Mocks;
using Service;

namespace TestBlockerTests
{
    [TestFixture]
    public class StlReaderTests
    {
        private readonly MockRepository _mock = new MockRepository();

        private StlReader _reader;

        [SetUp]
        public void Setup()
        {
            _reader = new StlReader();
        }

        [TearDown]
        public void TearDown()
        {
            _mock.BackToRecordAll();
        }

// ReSharper disable InconsistentNaming

        [Test]
        public void ReadStl_From_Filename()
        {
        }

        [Test]
        public void ReadStl_From_FileStream()
        {
        }

// ReSharper restore InconsistentNaming
    }
}
