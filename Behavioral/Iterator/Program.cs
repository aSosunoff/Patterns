using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Code;
using Iterator.Code.ConcreteIterator;


namespace Iterator
{
	class Program
	{
		static void Main(string[] args)
		{
			WordsCollection wordsCollection = new WordsCollection();
			wordsCollection.Add("1");
			wordsCollection.Add("2");
			wordsCollection.Add("3");
			wordsCollection.Add("4");
			wordsCollection.Add("5");
			wordsCollection.Add("6");
			wordsCollection.Add("7");

			WordsIterator iterator = wordsCollection.GetConsistentlyIterator();
			foreach (var item in iterator)
				Console.WriteLine(item);

			Console.WriteLine("\n");

			iterator = wordsCollection.GetStartEvenFinishOddIterator();
			foreach (var item in iterator)
				Console.WriteLine(item);

			Console.ReadKey();
		}
	}

	class WordsCollection
	{
		private List<string> _list = new List<string>();

		public void Add(string item)
		{
			_list.Add(item);
		}

		public void Add(string[] item)
		{
			_list.AddRange(item);
		}

		public List<string> GetList()
		{
			return _list;
		}

		public StartEvenFinishOddIterator GetStartEvenFinishOddIterator()
		{
			return new StartEvenFinishOddIterator(this);
		}

		public ConsistentlyIterator GetConsistentlyIterator()
		{
			return new ConsistentlyIterator(this);
		}
	}
}