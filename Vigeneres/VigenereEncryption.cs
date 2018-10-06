using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace Vigeneres
{
class VigenereEncryption
{
public string VigenereEncryptionM(string key)
{
byte[] mYarray = File.ReadAllBytes("C:\\Users\\niraj\\Desktop\\USAmendments.txt"); // reading the main file in byte array
var result = string.Join(" ", mYarray.Select(c => ((int)c).ToString("X"))); //converting the byte array to hexadecimal and adding space between the values
Console.WriteLine("\n\n\n This is the byte array of hex converted USAmendments file: \n\n\n" + result);
var splitresult = result.Split(); // spliting the array for getting length to pop. the key accordingly
var keyHex = string.Join(" ", key.Select(c => ((int)c).ToString("X"))); //converting the key to hex. and adding space between the values
var splitResultkey = keyHex.Split(); // spliting the key
Console.WriteLine("\n\n\n The hex values of key: " + key + " is: \n\n"); // displaying the hex. values of key
for (int i = 0; i < splitResultkey.Length; i++)
{
Console.WriteLine(splitResultkey[i]);
}
StringBuilder popKey = new StringBuilder(); // declaring a stringbuilder class for populated key
for (int i = 0; i < splitresult.Length; i++) // populating the key so it matches the file length
{
for (int j = 0; j < key.Length; j++)
{
popKey.Append(splitResultkey[j]); // appending each ith key value
popKey.Append(" "); // appending space for smooth operation
}
}
string kSring = Convert.ToString(popKey); // converting the populated hex key to a string
var k = kSring.Split(" "); // spliting the key for xor operation
StringBuilder cipher = new StringBuilder(); // declaring a stringbuilder class for Cipher
for (int i = 0; i < splitresult.Length; i++) // performing the xor operation to encipher the file
{
int val = Convert.ToInt16(splitresult[i], 16); // getting the ith hex value of main file
int val2 = Convert.ToUInt16(k[i], 16); // getting the ith hex value of key
var val3 = (val ^ val2); // xor the two values
var val4 = val3.ToString("X"); // convert the xor'd value to hexadecimal
cipher.Append(val4); // append the value to stringbuilder cipher
cipher.Append(" "); // append space so that operation to decipher becomes easier
}
string cipherString = Convert.ToString(cipher); // getting the string value of cipher
System.IO.File.WriteAllText(@"C:\\Users\\niraj\\Desktop\\Cipher.txt", cipherString); // writing string value of cipher to a file
Console.WriteLine("\n\n\n\n This is the cipherString in hexadecimal: \n\n" + cipherString); // display the cipher
return cipherString;
}
}
}
