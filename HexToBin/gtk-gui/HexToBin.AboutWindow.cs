
// This file has been generated by the GUI designer. Do not modify.
namespace HexToBin
{
	public partial class AboutWindow
	{
		private global::Gtk.Label labelTitle;

		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HexToBin.AboutWindow
			this.Name = "HexToBin.AboutWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("关于");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child HexToBin.AboutWindow.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.labelTitle = new global::Gtk.Label ();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc='32'>Hex转Bin工具</span>\n\n<span font_desc='16'>蝶晓梦</span>\n<span font_desc='16'>vowstar@gmail.com</span>");
			this.labelTitle.UseMarkup = true;
			w1.Add (this.labelTitle);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(w1[this.labelTitle]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Internal child HexToBin.AboutWindow.ActionArea
			global::Gtk.HButtonBox w3 = this.ActionArea;
			w3.Name = "AboutWindow_ActionArea";
			w3.Spacing = 10;
			w3.BorderWidth = ((uint)(5));
			w3.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child AboutWindow_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w3[this.buttonOk]));
			w4.Expand = false;
			w4.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 193;
			this.Show ();
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
