using Service.Models;

namespace Service.Interfaces
{
    public interface IMeshHelper
    {
        Mesh CenterMesh(Mesh mesh);
        Mesh PutMeshOnPlatform(Mesh mesh);
    }
}