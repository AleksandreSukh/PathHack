using System.IO;
using System.Reflection;

namespace PathHack
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = args[0];
            var fi = new FileInfo(input);
            var fullPath = fi.FullName;
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullPath);

            var textTemplate = $"start /b cmd /c \"{fullPath}\" %*";
            var binDirPath = GetBinDirPath();

            if (!Directory.Exists(binDirPath))
                Directory.CreateDirectory(binDirPath);
            var batFileName = fileNameWithoutExtension + ".bat";
            var shortcutFilePath = Path.Combine(binDirPath, batFileName);
            if (File.Exists(shortcutFilePath))
                File.Delete(shortcutFilePath);
            File.WriteAllText(shortcutFilePath, textTemplate);

        }

        private static string GetBinDirPath()
        {
            //Option 1 - Get directory of this exe
            return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            //Option 2 - Get C:\bin folder
            //var systemDriveRootPath = Path.GetPathRoot(Environment.SystemDirectory);
            //var binDirPath = Path.Combine(systemDriveRootPath, "bin");
            //return binDirPath;
        }
    }
}
