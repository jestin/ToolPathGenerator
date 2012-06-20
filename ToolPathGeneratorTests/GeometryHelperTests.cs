using NUnit.Framework;
using Rhino.Mocks;
using Service.Helpers;
using Service.Models;

namespace ToolPathGeneratorTests
{
    [TestFixture]
    public class GeometryHelperTests
    {

        private readonly MockRepository _mock = new MockRepository();

        private GeometryHelper _geometryHelper;

        [SetUp]
        public void Setup()
        {
            _geometryHelper = new GeometryHelper();
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
            _geometryHelper.IntersectMeshWithPlane(new Mesh(), new Point());
        }

        // ReSharper restore InconsistentNaming
    }
}
