// C# Map = Dictionary or HashTable
// output = KeyValuePair Class

using System;
using System.Collections.Generic;
public class Hello{
    public static void Main(){
        string line;
        Dictionary<string, int> lineArray = new Dictionary<string, int>();
        
        while ((line=Console.ReadLine()) != null) {
            // ここに、文字列を分割して、出力するコードを書く
            string[] lineSplit = line.Split(',');
            lineArray.Add(lineSplit[0], int.Parse(lineSplit[1]));
        }
        
        foreach(KeyValuePair<string, int> map in lineArray)
            Console.WriteLine(map.Key+"が"+map.Value+"匹現れた");
    }
}
