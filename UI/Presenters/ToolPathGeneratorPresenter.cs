﻿using Framework.MVP;
using Service.Interfaces;
using UI.Views;

namespace UI.Presenters
{
    public class ToolPathGeneratorPresenter : BasePresenter<IToolPathGeneratorView, IToolPathGeneratorPresenter>, IToolPathGeneratorPresenter
    {
        #region Dependencies

        private readonly IStlReader _stlReader;
        private readonly ISlicer _slicer;
        private readonly IPather _pather;
        private readonly IMeshHelper _meshHelper;
        private readonly IGCodeGenerator _generator;

        #endregion

        #region Constructors

        public ToolPathGeneratorPresenter(
            IStlReader stlReader,
            ISlicer slicer,
            IPather pather,
            IMeshHelper meshHelper,
            IGCodeGenerator generator)
        {
            _stlReader = stlReader;
            _generator = generator;
            _meshHelper = meshHelper;
            _pather = pather;
            _slicer = slicer;
        }

        #endregion

        #region IToolPathGeneratorPresenter Implementation

        public void CreateGCodeFromModel()
        {
            var mesh = _stlReader.ReadStl(View.FileName);
            mesh = _meshHelper.CenterMesh(mesh);
            var layers = _slicer.Slice(mesh);
            var path = _pather.GeneratePath(layers);
            View.GCode = _generator.GenerateGCode(path);
        }

        #endregion
    }
}