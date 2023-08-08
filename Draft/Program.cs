using MonoLDtk.Shared;

using Newtonsoft.Json;

string line;
LDtk ldtk = new LDtk();

using (StreamReader reader = new StreamReader("test.ldtk"))
{
    line = reader.ReadToEnd();
}


