using System;
namespace HexToBin
{
	public partial class AboutWindow : Gtk.Dialog
	{
		protected virtual void OnButtonOkClicked (object sender, System.EventArgs e)
		{
			this.Destroy();
		}
		
		
		public AboutWindow ()
		{
			this.Build ();
			labelTitle.Text=labelTitle.Text.Replace("{VERSION}",System.Reflection.Assembly.GetExecutingAssembly ().GetName ().Version.ToString ());
		    labelTitle.UseMarkup=true;
		}
	}
}

