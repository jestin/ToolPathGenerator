using NUnit.Framework;
using Rhino.Mocks;
using Service;
using Service.Models;

namespace ToolPathGeneratorTests
{
    [TestFixture]
    public class GCodeGeneratorTests
    {
        private readonly MockRepository _mock = new MockRepository();

        private GCodeGenerator _generator;

        [SetUp]
        public void Setup()
        {
            _generator = new GCodeGenerator();
        }

        [TearDown]
        public void TearDown()
        {
            _mock.BackToRecordAll();
        }

        // ReSharper disable InconsistentNaming

        [Test]
        public void GenerateGCode_Succeeds()
        {
            _generator.GenerateGCode(new Path());
        }

        // ReSharper restore InconsistentNaming
    }
}
