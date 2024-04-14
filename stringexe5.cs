/String handle
using System;
class Program{
public static void Main(string[] args){
string ori="HELLO WORLD";
string cloned=(string)ori.Clone();
Console.WriteLine("1.Original str:"+ori);
Console.WriteLine("\nCloned str:"+cloned);
string str1="hello, ";
string str2="world";
string res=string.Concat(str1,str2);
Console.WriteLine("\n2.Concatenated str:"+res);
string sen="The quick brown fox";
string search="fox";
bool contains=sen.Contains(search);
Console.WriteLine("\n3.Contains:"+contains);
string original="copy me";
char[] arr=new char[7];
original.CopyTo(0,arr,0,7);
string copy=new string(arr);
Console.WriteLine("\n4.Copy:"+copy);
int index=sen.IndexOf("fox");
Console.WriteLine("\n5.Index of:"+index);
string inserted=ori.Insert(6,"beautiful ");
Console.WriteLine("\n6.Inserted str:"+inserted);
string trim=" hello,world ";
string trimmed=trim.Trim();
Console.WriteLine("\n7.Trimmed str:"+trimmed);
}
}
/exception
using System;
class Program {
static void Main(string[] args)
{
int[] arr = {19, 0, 75, 52};
try {
for (int i = 0; i < arr.Length; i++) {
Console.WriteLine(arr[i] / arr[i + 1]);
}
}
catch (IndexOutOfRangeException e) {
Console.WriteLine("An Exception has occurred : {0}", e.Message);
}
catch (DivideByZeroException e) {
Console.WriteLine("An Exception has occurred : {0}", e.Message);
}
catch (ArgumentOutOfRangeException e) {
Console.WriteLine("An Exception has occurred : {0}", e.Message);
}
finally {
for (int i = 0; i < arr.Length; i++) {
Console.Write(" {0}", arr[i]);
}
}
}
}
