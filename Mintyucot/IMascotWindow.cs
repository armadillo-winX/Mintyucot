namespace Mintyucot
{
    internal interface IMascotWindow
    {
        public string MascotName { get; set; }

        public MascotType MascotType { get; set; }

        public string FilePath { get; set; }
    }
}
