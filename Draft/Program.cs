using MonoLDtk.Shared;

using Newtonsoft.Json;

string line;
LDtk ldtk;

using (StreamReader reader = new StreamReader("test.ldtk"))
{
    line = reader.ReadToEnd();
}


ldtk = JsonConvert.DeserializeObject<LDtk>(line);
System.Console.WriteLine(ldtk.ToString());