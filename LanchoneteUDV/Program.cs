using LanchoneteUDV.Infra.IoC;

namespace LanchoneteUDV
{

    public class Global
    {
        public static bool ExibeChurrasco { get; set; }
        public static bool ExibeSalgados { get; set; }
    }

    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    ApplicationConfiguration.Initialize();
        //    System.Windows.Forms.Application.Run(new PrincipalForm());

        //}
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new DependecyInjectionModule());

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Application.Run(CompositionRoot.Resolve<PrincipalForm>());

        }
    }
}