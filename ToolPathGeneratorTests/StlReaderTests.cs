using System.IO;
using System.Text;
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

        private Stream _stream;

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
        public void ReadStl_From_Filename_Succeeds()
        {
        }

        [Test]
        public void ReadStl_From_Stream_Succeeds()
        {
            _stream = new MemoryStream(Encoding.Default.GetBytes("SOLID"));
            _reader.ReadStl(_stream);
        }

        [Test]
        public void ReadAsciiStl_Succeeds()
        {
        }

        [Test]
        public void ReadBinaryStl_Succeeds()
        {
        }

        [Test]
        public void CreateMeshFromAscii_Succeeds()
        {
        }

        [Test]
        public void CreateMeshFromBinary_Succeeds()
        {
        }

// ReSharper restore InconsistentNaming
    }
}
