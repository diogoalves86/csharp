using System;

namespace Teste
{
	public partial class AdicionaEvento : Gtk.Window
	{
		public AdicionaEvento () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

