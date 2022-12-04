namespace SearchIndexer;
using System;

// Github: tldmbruno

// WIP - Prototyping stage
// A modular search indexer for quick and easy search results for projects.
// It returns a tagged search result, easily parsable to apply in websites and UIs.

/*
	USAGE:
	searchindexer <search> <file>
	'search' is the search query
	'file' is any multi line text file
*/

class Program {
	public static void Main(string[] args) {
		string results = "";
		
		if (args.Length > 0) {
			results = args[0];
		}
		
		Console.WriteLine("RESULTS: " + results);
	}
}