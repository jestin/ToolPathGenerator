﻿using Service.Helpers;
using Service.Interfaces;
using StructureMap.Configuration.DSL;

namespace Service
{
    public class DependencyRegistry : Registry
    {
        public DependencyRegistry()
        {
            For<IStlReader>().Use<StlReader>();
            For<ISlicer>().Use<Slicer>();
            For<IPather>().Use<Pather>();
            For<IMeshHelper>().Use<MeshHelper>();
            For<IPathHelper>().Use<PathHelper>();
            For<IGCodeGenerator>().Use<GCodeGenerator>();
            For<IGeometryHelper>().Use<GeometryHelper>();
        }
    }
}
