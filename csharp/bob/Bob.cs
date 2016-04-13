using System;
using System.Linq;
using NUnit.Framework;

public class Bob
{
	public static string Hey(string text)
	{
		if (Empty(text))
			return "Fine. Be that way!";

		if (Yell(text))
			return "Whoa, chill out!";

		if (Question(text))
			return "Sure.";

		return "Whatever.";
	}

	private static bool Empty(string text)
	{
		return String.IsNullOrWhiteSpace(text);
	}

	private static bool Yell(string text)
	{
		return text.Any(char.IsLetter) && text.Equals(text.ToUpper());
	}

	private static bool Question(string text)
	{
		var textWithTrimEnd = text.TrimEnd();
		return textWithTrimEnd[textWithTrimEnd.Length - 1] == '?';
	}
}
