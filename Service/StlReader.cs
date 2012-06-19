using System;
using System.IO;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    public class StlReader : IStlReader
    {
        public Mesh ReadStl(string fileName)
        {
            try
            {
                return ReadStl(new FileStream(fileName, FileMode.Open));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Mesh ReadStl(Stream file)
        {
            // read header
            var header = new byte[80];
            file.Read(header, 0, 80);
            file.Position = 0;

            return header.ToString().ToUpper() == "SOLID" ? CreateMeshFromAscii(ReadAsciiStl(file)) : CreateMeshFromBinary(ReadBinaryStl(file));
        }

        public string ReadAsciiStl(Stream file)
        {
            var sr = new StreamReader(file);
            return sr.ReadToEnd();
        }

        public byte[] ReadBinaryStl(Stream file)
        {
            byte[] data;
            var buffer = new byte[32768];
            using (var ms = new MemoryStream())
            {
                while (true)
                {
                    var read = file.Read(buffer, 0, buffer.Length);
                    if (read <= 0)
                    {
                        data = ms.ToArray();
                        break;
                    }
                    ms.Write(buffer, 0, read);
                }
            }

            return data;
        }

        public Mesh CreateMeshFromAscii(string data)
        {
            // do all the stuff to create a mesh

            return new Mesh();
        }

        public Mesh CreateMeshFromBinary(byte[] data)
        {
            // do all the stuff to create a mesh

            return new Mesh();
        }
    }
}
