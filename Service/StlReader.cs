using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
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
            var headerString = Encoding.ASCII.GetString(header, 0, file.Read(header, 0, 80)).ToUpper();
            file.Position = 0;

            try
            {
                return headerString.StartsWith("SOLID")
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
            var lines = data.ToUpper().Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            var mesh = new Mesh { Facets = new Collection<Facet>() };

            Facet facet = null;
            foreach (var line in lines)
            {
                var tokens = line.Split();

                if (tokens[0] == ("FACET"))
                {
                    facet = new Facet
                                {
                                    Normal = new Point
                                                 {
                                                     X = float.Parse(tokens[2]),
                                                     Y = float.Parse(tokens[3]),
                                                     Z = float.Parse(tokens[4])
                                                 }
                                };
                }

                if(tokens[0] == "OUTER" && tokens[1] == "LOOP")
                {
                    if (facet != null)
                    {
                        facet.Vertices = new Collection<Point>();
                    }
                    else
                    {
                        throw new ApplicationException();
                    }
                }

                if (tokens[0] == "VERTEX")
                {
                    if (facet != null && facet.Vertices != null)
                    {
                        facet.Vertices.Add(new Point
                                               {
                                                   X = float.Parse(tokens[1]),
                                                   Y = float.Parse(tokens[2]),
                                                   Z = float.Parse(tokens[3])
                                               });
                    }
                    else
                    {
                        throw new ApplicationException();
                    }
                }

                if (tokens[0] == "ENDFACET")
                {
                    mesh.Facets.Add(facet);
                }
            }

            return mesh;
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
                br.ReadInt16();
            }

            return mesh;
        }
    }
}