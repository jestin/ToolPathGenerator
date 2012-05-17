using System.IO;
using Service.Models;

namespace Service.Interfaces
{
    public interface IStlReader
    {
        Mesh ReadStl(string fileName);
        Mesh ReadStl(FileStream file);
    }
}