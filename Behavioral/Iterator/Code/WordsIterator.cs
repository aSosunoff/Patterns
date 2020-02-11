using System.Collections;

namespace Iterator.Code
{
	abstract class WordsIterator : IEnumerator, IEnumerable
	{
		protected int _position = -1;
		public abstract bool MoveNext();

		public virtual void Reset()
		{
			_position = 0;
		}
		public abstract object Current { get; }

		public IEnumerator GetEnumerator()
		{
			return this;
		}
	}
}
