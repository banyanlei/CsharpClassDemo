

using Newtonsoft.Json;

StreamReader file = File.OpenText("C:\\CAYA\\cy\\c# test\\CsharpClassDemo\\Deserialize_Json\\PidLookupTable.json");
string wholeFile = file.ReadToEnd();
Dictionary<string, PidItem> productData = JsonConvert.DeserializeObject<Dictionary<string, PidItem>>(wholeFile);
string productNumber = "KRC 161 967/1";
string productname = productData[productNumber].productname;
string marketname = productData[productNumber].marketname;

uint max = uint.MaxValue;//4294967295
Console.WriteLine(max);


public class PidItem
{
    /// <summary>
    /// Market Name.
    /// </summary>
    public string marketname;
    /// <summary>
    /// Product Name.
    /// </summary>
    public string productname;
}