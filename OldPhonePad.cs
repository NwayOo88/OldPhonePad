using System;
using System.Collections.Generic;
using System.Text;

public static class OldPhonePadClass
{

	public static Dictionary<char, string> oldPhonePadList = new Dictionary<char, string>
	{
		{'2', "ABC"}, {'3', "DEF"}, {'4', "GHI"},
		{'5', "JKL"}, {'6', "MNO"}, {'7', "PQRS"},
		{'8', "TUV"}, {'9', "WXYZ"}
	};
	/// <summary>
	/// Convert a input keypress string to change the related character and return the corresponding string. 
	/// </summary>
	/// <param name="input">Keypress string entered by the user</param>
	/// <returns>Returning the corresponding string.</returns>
	public static String OldPhonePad(string input)
	{
		int count = 1;
		char previousKey = '\0';//set null character
		StringBuilder resultString = new StringBuilder();
		foreach (char c in input)
		{
			if (oldPhonePadList.ContainsKey(c))
			{
				if (c == previousKey)
				{
					count++;
					if (count > oldPhonePadList[previousKey].Length)
					{
						count = 1;
					}
					resultString[resultString.Length - 1] = oldPhonePadList[previousKey][(count - 1)];
				}
				else
				{
					count = 1;//reset the count if new char
					resultString.Append(oldPhonePadList[c][(count - 1)]);
					previousKey = c;
				}

			}
			else if (c == '*') //backspace
			{
				if (resultString.Length > 0)
				{
					resultString.Length--;//remove last character
					previousKey = '\0';
					count = 1;
				}
			}
			else if (c == ' ' || c == '#') //end of input
			{
				previousKey = '\0';
				count = 1;
			}

		}
		return resultString.ToString();
	}
}

