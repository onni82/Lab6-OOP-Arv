using Spectre.Console;
namespace Lab6_OOP_Arv
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Ask for the user's favorite fruit
			var fruit = AnsiConsole.Prompt(
				new SelectionPrompt<string>()
					.Title("What's your [green]favorite fruit[/]?")
					.PageSize(10)
					.MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
					.AddChoices(new[] {
			"Apple", "Apricot", "Avocado",
			"Banana", "Blackcurrant", "Blueberry",
			"Cherry", "Cloudberry", "Cocunut",
					}));

			// Echo the fruit back to the terminal
			AnsiConsole.WriteLine($"I agree. {fruit} is tasty!");
		}
	}
}
