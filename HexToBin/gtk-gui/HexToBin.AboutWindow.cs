
// This file has been generated by the GUI designer. Do not modify.
namespace HexToBin
{
	public partial class AboutWindow
	{
		private global::Gtk.Table tableMain;
		private global::Gtk.Image imageLogo;
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
			w1.Name = "VBoxMain";
			w1.BorderWidth = ((uint)(2));
			// Container child VBoxMain.Gtk.Box+BoxChild
			this.tableMain = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.tableMain.Name = "tableMain";
			this.tableMain.RowSpacing = ((uint)(6));
			this.tableMain.ColumnSpacing = ((uint)(6));
			// Container child tableMain.Gtk.Table+TableChild
			this.imageLogo = new global::Gtk.Image ();
			this.imageLogo.Name = "imageLogo";
			this.imageLogo.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("HexToBin.icon.main.hextobin_192x192.png");
			this.tableMain.Add (this.imageLogo);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tableMain [this.imageLogo]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableMain.Gtk.Table+TableChild
			this.labelTitle = new global::Gtk.Label ();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc='32'>Hex转Bin工具</span>\n<span font_desc='16'>版本:{VERSION}</span>\n<span font_desc='16'>协议:GNU GPL V3</span>\n\n<span font_desc='16'>黄锐,兰州大学</span>\n<span font_desc='16'>vowstar@gmail.com</span>");
			this.tableMain.Add (this.labelTitle);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tableMain [this.labelTitle]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w1.Add (this.tableMain);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.tableMain]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Internal child HexToBin.AboutWindow.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "ActionAreaMain";
			w5.Spacing = 10;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child ActionAreaMain.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonOk]));
			w6.Expand = false;
			w6.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 556;
			this.DefaultHeight = 265;
			this.Show ();
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
