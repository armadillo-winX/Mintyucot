namespace Mintyucot
{
    internal class PathInfo
    {
        /// <summary>
        /// アプリケーションのアセンブリのファイルパスを取得します．
        /// </summary>
        public static string AssemblyFilePath => typeof(App).Assembly.Location;

        /// <summary>
        /// アプリケーションのアセンブリがあるディレクトリのパスを取得します．
        /// </summary>
        public static string AssemblyBaseDirectoryPath => AppDomain.CurrentDomain.BaseDirectory;
    }
}
