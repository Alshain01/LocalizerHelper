namespace LocalizerHelper
{
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    public class LocalizerHelper : UnityEngine.MonoBehaviour
    {
        const string path = "GameData/LocalizerHelper/PluginData/";
        public void Awake()
        {
            var file = new System.IO.FileInfo(path + "Language.cfg");
            using (System.IO.StreamReader stream = file.OpenText())
            {
                KSP.Localization.Localizer.SwitchToLanguage(stream.ReadLine());
            }
        }
    }
}
