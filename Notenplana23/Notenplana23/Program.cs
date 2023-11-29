namespace Notenplana23
{
    internal static class Program
    {   
        private static ViewLoggin viewLoggin;
        private static ViewRegestrierung viewRegestrierung;
        private static ViewHauptprogramm viewHauptprogramm;
        private static ViewProfil viewProfil;
        private static ViewProfiBearbeiten viewProfiBearbeiten;
        private static ViewFachHj1 viewFachHj1;
        private static ViewFachBearbeitenHj1 viewFachBearbeitenHj1;
        private static ViewNoteHj1 viewNoteHj1;
        private static ViewNoteBearbeitenHj1 viewNoteBearbeitenHj1;
        private static ViewFachHj2 viewFachHj2;
        private static ViewFachBearbeitenHj2 viewFachBearbeitenHj2;
        private static ViewNoteHj2 viewNoteHj2;
        private static ViewNoteBearbeitenHj2 viewNoteBearbeitenHj2;

        private static ConrtollerLoggin controllerLoggin;
        private static ControllerRegestrierung controllerRegestrierung;
        private static ControllerHauptprogramm controllerHauptprogramm;
        private static ControllerProfil controllerProfil;
        private static ConrollerProfilBearbeiten controllerProfiBearbeiten;
        private static ControllerFachHj1 controllerFachHj1;
        private static ControllerFachBearbeitenHj1 controllerFachBearbeitenHj1;
        private static ControllerNoteHj1 controllerNoteHj1;
        private static ControlleNoteBearbeitenHj1 controllerNoteBearbeitenHj1;
        private static ControllerFachHj2 controllerFachHj2;
        private static ControllerFachBearbeitenHj2 controllerFachBearbeitenHj2;
        private static ControllerNoteHj2 controllerNoteHj2;
        private static ControllerNoteBearbeitenHj2 controllerNoteBearbeitenHj2;

        private static ModelLoggin modelLoggin;
        private static ModelRegestrierung modelRegestrierung;
        private static ModelHauptprogramm modelHauptprogramm;
        private static ModelProfil modelProfil;
        private static ModelProfilBearbeiten modelProfiBearbeiten;
        private static ModelFachHj1 modelFachHj1;
        private static ModelFachBearbeitenHj1 modelFachBearbeitenHj1;
        private static ModelNoteHj1 modelNoteHj1;
        private static ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1;
        private static ModelFachHj2 modelFachHj2;
        private static ModelFachBearbeitenHj2 modelFachBearbeitenHj2;
        private static ModelNoteHj2 modelNoteHj2;
        private static ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ViewLoggin());
        }
    }
}