namespace SearchIndexer;
using System;

class Program {
	public static void Main(string[] args) {
		// If there is arguments present, proceed normally
		if (args.Length > 0) {
			// Initialize relevant variables
			string searchQuery = args[args.Length-1];
			string<List> results = new string<List>;
			
			// Fetches all files
			for (int i = 0; i < args.Length-1; i++) {
				results[i] = args[i];
			}
		
			// Tells the search query
			Console.WriteLine($"Search Query: {searchQuery}");
			
			// Prints the search results
			Console.WriteLine("Top Results: ");
			
			foreach (string item in results) {
				Console.WriteLine($"- {item}");			
			}
		}
		else {
			// Show the user the help message
			Console.WriteLine("No arguments were included.");
			Console.WriteLine("Usage: search-indexer <file1> <file2> <file3> ... <search-query>");
		}
	}
}
