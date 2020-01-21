using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MonsterHunterAutoSteamworks
{
	public class KeyHandler
	{
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		private readonly int _key;
		private readonly IntPtr _hWnd;
		private readonly int _id;

		public KeyHandler(Keys key, Form form)
		{
			_key = (int)key;
			_hWnd = form.Handle;
			_id = this.GetHashCode();
		}

		public override int GetHashCode()
		{
			return _key ^ _hWnd.ToInt32();
		}

		public bool Register()
		{
			return RegisterHotKey(_hWnd, _id, 0, _key);
		}

		public bool Unregister()
		{
			return UnregisterHotKey(_hWnd, _id);
		}
	}
}
