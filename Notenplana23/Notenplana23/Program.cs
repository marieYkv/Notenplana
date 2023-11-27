namespace Notenplana23
{
    internal static class Program
    {   
        private ViewLoggin viewLoggin;
        private ViewRegestrierung viewRegestrierung;
        private ViewHauptprogramm viewHauptprogramm;
        private ViewProfil viewProfil;
        private ViewProfiBearbeiten viewProfiBearbeiten;
        private ViewFachHj1 viewFachHj1;
        private ViewFachBearbeitenHj1 viewFachBearbeitenHj1;
        private ViewNoteHj1 viewNoteHj1;
        private ViewNoteBearbeitenHj1 viewNoteBearbeitenHj1;
        private ViewFachHj2 viewFachHj2;
        private ViewFachBearbeitenHj2 viewFachBearbeitenHj2;
        private ViewNoteHj2 viewNoteHj2;
        private ViewNoteBearbeitenHj2 viewNoteBearbeitenHj2;

        private ControllerLoggin controllerLoggin;
        private ControllerRegestrierung controllerRegestrierung;
        private ControllerHauptprogramm controllerHauptprogramm;
        private ControllerProfil controllerProfil;
        private ControllerProfiBearbeiten controllerProfiBearbeiten;
        private ControllerFachHj1 controllerFachHj1;
        private ControllerFachBearbeitenHj1 controllerFachBearbeitenHj1;
        private ControllerNoteHj1 controllerNoteHj1;
        private ControllerNoteBearbeitenHj1 controllerNoteBearbeitenHj1;
        private ControllerFachHj2 controllerFachHj2;
        private ControllerFachBearbeitenHj2 controllerFachBearbeitenHj2;
        private ControllerNoteHj2 controllerNoteHj2;
        private ControllerNoteBearbeitenHj2 controllerNoteBearbeitenHj2;

        private ModelLoggin modelLoggin;
        private ModelRegestrierung modelRegestrierung;
        private ModelHauptprogramm modelHauptprogramm;
        private ModelProfil modelProfil;
        private ModelProfiBearbeiten modelProfiBearbeiten;
        private ModelFachHj1 modelFachHj1;
        private ModelFachBearbeitenHj1 modelFachBearbeitenHj1;
        private ModelNoteHj1 modelNoteHj1;
        private ModelNoteBearbeitenHj1 modelNoteBearbeitenHj1;
        private ModelFachHj2 modelFachHj2;
        private ModelFachBearbeitenHj2 modelFachBearbeitenHj2;
        private ModelNoteHj2 modelNoteHj2;
        private ModelNoteBearbeitenHj2 modelNoteBearbeitenHj2;

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