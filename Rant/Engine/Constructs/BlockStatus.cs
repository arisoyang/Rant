﻿namespace Rant.Engine.Constructs
{
	/// <summary>
	/// Supplies state information about an active block, such as the iteration, item count, and current index.
	/// </summary>
	internal class BlockStatus
	{
		private readonly int _count;
		private int _iterNum;
		private int _index;

		public int Count => _count;

		public int Iteration => _iterNum;

		public int Index => _index;

		public BlockStatus(int count)
		{
			_count = count;
		}

		public void Next(int index)
		{
			_index = index;
			_iterNum++;
		}
	}
}