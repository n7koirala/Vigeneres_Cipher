using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace Vigeneres
{
class VigenereBreaking
{
public string VigenereBreakingM()
{
VigenereEncryption v = new VigenereEncryption(); // declaring a new object for VigenereEncryption
Console.Write("Please enter the key: \n");
string myKey = Console.ReadLine(); // getting the key as an input
string cipherString = v.VigenereEncryptionM(myKey); // storing the cipher in a string using the input value as the key
var cipherVar = cipherString.Split(" "); // using space as an delimiter to return an array of hex values of the cipher
int alpha = 1;
while (alpha != 27) // key with a max length 27 can only be sampled
{
List<string> dict = new List<string>(); // declaring a generic collection list object
for (int j = 0; j < cipherVar.Length; j = j + alpha) // adding the jth values of cipher into the list
{
dict.Add(Convert.ToString(cipherVar[j])); // converting the values to string before adding
}
int dicount = dict.Count; // storing the count of each individual jth values
List<int> coun1 = new List<int>(); // declaring generic collection list objects
List<String> list = new List<string>();
for (int o = 0; o < dicount; o++)
{
int count = 1;
Boolean found = false;
foreach (string item in list)
{
if (item.Contains(Convert.ToString(dict[o]))) // to avoid repeated counting of character
{
found = true;
}
}
if (!found) // if character is found it has already been counted so no need to count
{
for (int j = o + 1; j < dict.Count; j++)
{
if (dict[o] == dict[j]) // if there is match between oth element and jth element of list then increase the counter
{
count++;
}
}
coun1.Add(count); // recording the count of each distinct element into the list
list.Add(Convert.ToString(dict[o])); // adding the counted elements in the list
}
}
float sss = 1;
int len = dict.Count; // getting the length of the cipher
for (int kk = 0; kk < coun1.Count; kk++) // find the summation of qi squared
{
int a = coun1[kk] * coun1[kk];
sss = sss + a; // summation is stored in sss
}
float threshold = (sss / (len * len)); // getting the summation of probability of each length passed
if (threshold > 0.047) // length found if the sum. of prob. crosses 0.047
{
break;
}
alpha++;
}
Console.WriteLine("\n\n The key period is :: " + alpha + "\n\n"); // diplaying the key length (period)
StringBuilder highest = new StringBuilder();
for (int mm = 0; mm < alpha; mm++) // using the period to add individual characters into the list object
{
List<String> dict = new List<String>();
for (int nn = mm; nn < cipherVar.Length; nn = nn + (alpha))
{
dict.Add(Convert.ToString(cipherVar[nn])); // adding the ciphervalues to the stringlist using the period
}
Dictionary<string, int> coun2 = new Dictionary<string, int>(); // declaring the dictionary class object
List<String> list = new List<string>();
for (int o = 0; o < dict.Count; o++) // counting the number of characters repeated in the dictionary
{
int count = 1;
Boolean found = false;
foreach (string item in list)
{
if (item.Contains(Convert.ToString(dict[o])))
{
found = true;
}
}
if (!found)
{
for (int j = o + 1; j < dict.Count; j++)
{
if (dict[o] == dict[j])
{
count++;
}
}
list.Add(Convert.ToString(dict[o])); // add distinct elements
coun2.Add(Convert.ToString(dict[o]), count); // add dict elements to coun2
}
}
var sortDict = from pair in coun2 orderby pair.Value descending select pair; // getting key of the highest value element
foreach (KeyValuePair<string, int> pair in sortDict)
{
int val = Convert.ToInt16(pair.Key, 16); // getting the key of the most frequent element in the dictionary
var val3 = Convert.ToChar(val ^ 32); // xor with the most frequent character: space ( dec. value 32 )
highest.Append(val3); // appending the character to the stringbuilder
break;
}
}
string decodedKey = Convert.ToString(highest); // getting the key in string
return decodedKey;
}
}
}
