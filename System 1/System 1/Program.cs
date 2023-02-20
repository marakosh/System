using System.Diagnostics;

ProcessStartInfo startInfo = new ProcessStartInfo();
startInfo.FileName = "childProcess.exe";

Process childProcess = new Process();
childProcess.StartInfo = startInfo;

Console.WriteLine("Запуск дочернего процесса...");
childProcess.Start();

childProcess.WaitForExit();

Console.WriteLine($"Дочерний процесс завершен с кодом {childProcess.ExitCode}");