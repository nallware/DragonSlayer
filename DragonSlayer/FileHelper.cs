using System.IO;

namespace DragonSlayer
{
    public static class FileHelper
    {
        public static string UniqueFileName(string path, string filename, string extension)
        {
            string oldname = filename;
            if (File.Exists(path + "\\" + filename + extension))
            {
                int i = 1;
                while (File.Exists(path + "\\" + filename + extension))
                {
                    filename = filename.Replace(filename, oldname + "(" + i + ")");
                    i++;
                }

            }
            return filename + extension;
        }
    }
}
