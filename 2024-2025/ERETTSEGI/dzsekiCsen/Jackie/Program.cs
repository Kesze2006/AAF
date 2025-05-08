using Jackie;

List<VersenyEv> versenyEvek = new List<VersenyEv>();
string[] sorok = File.ReadAllLines("jackie.txt");
for (int i = 1; i < sorok.Length; i++)
{
    string[] vag = sorok[i].Split("\t");
    versenyEvek.Add(new VersenyEv(int.Parse(vag[0]), int.Parse(vag[1]), int.Parse(vag[2]), int.Parse(vag[3]), int.Parse(vag[4]), int.Parse(vag[5])));
}

//3.feladat
Console.WriteLine("3.feladat: {0}",versenyEvek.Count());

//4.feladat
int maxIndex = 0;
for (int i = 0; i < versenyEvek.Count; i++)
{
    if (versenyEvek[i].versenyDarab > versenyEvek[maxIndex].versenyDarab)
    {
        maxIndex = i;
    }
}
Console.WriteLine("4.feladat: {0}", versenyEvek[maxIndex].ev);

//5.feladat
Dictionary<int,int> evtizedek = new Dictionary<int,int>();
for (int i = 0; i < versenyEvek.Count; i++)
{
    if (evtizedek.ContainsKey(versenyEvek[i].evtized))
    {
        evtizedek[versenyEvek[i].evtized] += versenyEvek[i].nyert;
    }
    else
    {
        evtizedek.Add(versenyEvek[i].evtized, versenyEvek[i].nyert);
    }
}
Console.WriteLine("5.feladat");
foreach (var elem in evtizedek)
{
   Console.WriteLine("  {0}-es évek:{1} megnyert verseny",elem.Key,elem.Value);
}

/*
<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
</head>
<body>
  
</body>
</html>
*/

string html = "<!DOCTYPE html>" +
                "<html lang=\"en\">" +
                "<head>" +
                    "<meta charset=\"UTF-8\">" +
                    "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
                    "<title>Document</title>" +
                "</head>" +
                "<body>" +
                "<h1> Jackie Stewart </h1>"+
                "<table>";

for (int i = 0; i < versenyEvek.Count; i++)
{
    html += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", versenyEvek[i].ev, versenyEvek[i].versenyDarab, versenyEvek[i].nyert);
}





html +=                "</table>"+
                "</body>" +
                "</html>";

File.WriteAllText("jackie.html", html);