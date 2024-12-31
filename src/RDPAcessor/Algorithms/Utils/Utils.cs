using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace RDPAcessor.Algorithms.Utils
{
    class Utils
    {
        private static Random random = new Random();

        #region Assembly Changer
        public static string AssemblyClone(string sourceFilePath, string targetFilePath)
        {
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(sourceFilePath);

            string versionInfoText = $"{fileVersionInfo.InternalName ?? "N/A"}\n" +
                                     $"{fileVersionInfo.FileDescription ?? "N/A"}\n" +
                                     $"{fileVersionInfo.CompanyName ?? "N/A"}\n" +
                                     $"{fileVersionInfo.ProductName ?? "N/A"}\n" +
                                     $"{fileVersionInfo.LegalCopyright ?? "N/A"}\n" +
                                     $"{fileVersionInfo.LegalTrademarks ?? "N/A"}\n" +
                                     $"{fileVersionInfo.FileMajorPart}.{fileVersionInfo.FileMinorPart}.{fileVersionInfo.FileBuildPart}.{fileVersionInfo.FilePrivatePart}\n" +
                                     $"{fileVersionInfo.ProductMajorPart}.{fileVersionInfo.ProductMinorPart}.{fileVersionInfo.ProductBuildPart}.{fileVersionInfo.ProductPrivatePart}";

            try
            {
                File.WriteAllText(targetFilePath, versionInfoText);
                return targetFilePath;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Form Helper & Random String Generator
        public static string PrintDateInfo()
        {
            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string userName = Environment.UserName;
            return $"{currentDateTime} - {userName}";
        }
        public static string GenerateRandStr(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion
    }
}
