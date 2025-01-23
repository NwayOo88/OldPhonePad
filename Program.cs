while (true)
{
	Console.Write("Enter keys (e.g., '222 2 22') or press ESC to exit:  ");

	string? input = Console.ReadLine();

	if (string.IsNullOrEmpty(input))
		continue;

	Console.WriteLine("Output: " + OldPhonePadClass.OldPhonePad(input));

	Console.WriteLine("Press ESC to exit or any key to continue...");

	if (Console.ReadKey(true).Key == ConsoleKey.Escape)
		Environment.Exit(0);
}
