using System;
using System.Windows.Forms;

namespace FormsGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StructureMap.ObjectFactory.Initialize(x =>
            {
                x.AddRegistry(new DependencyRegistry());
                x.AddRegistry(new UI.DependencyRegistry());
                x.AddRegistry(new Service.DependencyRegistry());
            });

            Application.Run(new Form1());
        }
    }
}
