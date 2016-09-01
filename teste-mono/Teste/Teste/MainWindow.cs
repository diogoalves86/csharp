using System;
using Gtk;
using Teste;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void btnAddEventoClicado (object sender, EventArgs e)
	{
		AdicionaEvento janelaAdicionaEvento = new AdicionaEvento ();
		janelaAdicionaEvento.Show ();
	}

	protected void SelecionaDiaCalendario (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}
}
