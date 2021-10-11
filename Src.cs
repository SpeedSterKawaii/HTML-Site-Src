// Displays the Current Website HTML Source

public void DisplaySource(string site, int times)
{
if (site.Contains("https://"))
{
Process.Start("view-source:" + site);
times = 1;
}
else
{
return "no";
times = 0;
}
}
