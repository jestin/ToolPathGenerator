using System;
using System.Collections.ObjectModel;
using System.IO;
using Service.Interfaces;
using Service.Models;

namespace Service
{
    /// <summary>
    /// This class is for creating meshes from both binary and ascii stl files
    /// </summary>
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

            try
            {
                return header.ToString().ToUpper() == "SOLID"
                       ? CreateMeshFromAscii(ReadAsciiStl(file))
                       : CreateMeshFromBinary(ReadBinaryStl(file));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string ReadAsciiStl(Stream file)
        {
            var sr = new StreamReader(file);
            return sr.ReadToEnd();
        }

        public MemoryStream ReadBinaryStl(Stream file)
        {
            var buffer = new byte[32768];
            var ms = new MemoryStream();
            var read = 0;
            while ((read = file.Read(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
            }

            return ms;
        }

        public Mesh CreateMeshFromAscii(string data)
        {
            // do all the stuff to create a mesh

            return new Mesh();
        }

        public Mesh CreateMeshFromBinary(MemoryStream stream)
        {
            var br = new BinaryReader(stream);

            // seeks past the header
            br.BaseStream.Seek(80, SeekOrigin.Begin);

            var numberOfFacets = br.ReadInt32();

            var mesh = new Mesh {Facets = new Collection<Facet>()};

            for (long i = 0; i < numberOfFacets; i++)
            {
                mesh.Facets.Add(new Facet
                                    {
                                        Normal =
                                            new Point {X = br.ReadSingle(), Y = br.ReadSingle(), Z = br.ReadSingle()},
                                        Vertices = new Collection<Point>
                                                       {
                                                           new Point
                                                               {
                                                                   X = br.ReadSingle(),
                                                                   Y = br.ReadSingle(),
                                                                   Z = br.ReadSingle()
                                                               },
                                                           new Point
                                                               {
                                                                   X = br.ReadSingle(),
                                                                   Y = br.ReadSingle(),
                                                                   Z = br.ReadSingle()
                                                               },
                                                           new Point
                                                               {
                                                                   X = br.ReadSingle(),
                                                                   Y = br.ReadSingle(),
                                                                   Z = br.ReadSingle()
                                                               }
                                                       }
                                    });

                // unused attribute byte count
                var dummy = br.ReadInt16();
            }

            return mesh;
        }
    }
}