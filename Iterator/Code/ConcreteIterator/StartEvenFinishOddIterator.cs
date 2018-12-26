using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Iterator.Code.ConcreteIterator
{
	class StartEvenFinishOddIterator : WordsIterator
	{
		private readonly WordsCollection _wordsCollection;
		private readonly List<int> _index = new List<int>();

		public StartEvenFinishOddIterator(WordsCollection wordsCollection)
		{
			_wordsCollection = wordsCollection;
			List<string> listInputElement = wordsCollection.GetList();
			List<int> listDigit = wordsCollection.GetList().Select(s => listInputElement.IndexOf(s)).ToList();
			List<int> resultEven = new List<int>();
			List<int> resultOdd = new List<int>();

			foreach (int index in listDigit)
			{
				if (index % 2 == 0)
					resultEven.Add(index);
				else
					resultOdd.Add(index);
			}

			_index.AddRange(resultEven);
			_index.AddRange(resultOdd);
		}
		public override bool MoveNext()
		{
			int updatePosition = _position + 1;
			if (updatePosition >= 0 && updatePosition < _wordsCollection.GetList().Count)
			{
				_position = updatePosition;
				return true;
			}
			else
			{
				return false;
			}
		}

		public override object Current => _wordsCollection.GetList()[_index[_position]];
	}
}
