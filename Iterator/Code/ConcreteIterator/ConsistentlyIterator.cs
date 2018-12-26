using System.Collections;

namespace Iterator.Code.ConcreteIterator
{
	class ConsistentlyIterator : WordsIterator
	{
		private readonly WordsCollection _wordsCollection;
		public ConsistentlyIterator(WordsCollection wordsCollection)
		{
			_wordsCollection = wordsCollection;
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

		public override object Current => _wordsCollection.GetList()[_position];
	}
}
