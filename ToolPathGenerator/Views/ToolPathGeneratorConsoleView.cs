using System;
using UI.Presenters;
using UI.Views;

namespace ToolPathGenerator.Views
{
    class ToolPathGeneratorConsoleView : IToolPathGeneratorView
    {
        private string _fileName;

        public IToolPathGeneratorPresenter Presenter { get; set; }

        public string FileName {
            get
            {
                if (!string.IsNullOrEmpty(_fileName))
                {
                    return _fileName;
                }

                Console.WriteLine("Please enter the STL file:");
                _fileName = Console.ReadLine();

                // perform UI validation

                return _fileName;
            }

            set
            {
                // perform UI validation

                _fileName = value;
            }
        }

        public string StlData
        {
            get { throw new NotImplementedException(); }
        }

        public string GCode
        {
            set
            {
                Console.Write(value);

                Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
