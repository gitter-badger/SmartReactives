using System.Threading;

namespace SmartReactives.Test
{
	class Waiter
	{
		bool waiting = true;

		public void Wait()
		{
			while (waiting)
			{
				Thread.Sleep(10);
			}
		}

		public void Release()
		{
			waiting = false;
		}
	}
}