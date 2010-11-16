
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Table tableMain;

	private global::Gtk.HBox hboxHex;

	private global::Gtk.Label labelHex;

	private global::Gtk.FileChooserButton filechooserbuttonHex;

	private global::Gtk.HButtonBox hbuttonboxMain;

	private global::Gtk.Button buttonConvert;

	private global::Gtk.Button buttonAbout;

	private global::Gtk.Button buttonQuit;

	private global::Gtk.Image imageLogo;

	private global::Gtk.Label labelTitle;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("HexToBin");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.tableMain = new global::Gtk.Table (((uint)(4)), ((uint)(1)), false);
		this.tableMain.Name = "tableMain";
		this.tableMain.RowSpacing = ((uint)(6));
		this.tableMain.ColumnSpacing = ((uint)(6));
		// Container child tableMain.Gtk.Table+TableChild
		this.hboxHex = new global::Gtk.HBox ();
		this.hboxHex.Name = "hboxHex";
		this.hboxHex.Spacing = 6;
		// Container child hboxHex.Gtk.Box+BoxChild
		this.labelHex = new global::Gtk.Label ();
		this.labelHex.Name = "labelHex";
		this.labelHex.Xalign = 0f;
		this.labelHex.LabelProp = global::Mono.Unix.Catalog.GetString ("Hex文件");
		this.hboxHex.Add (this.labelHex);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hboxHex[this.labelHex]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hboxHex.Gtk.Box+BoxChild
		this.filechooserbuttonHex = new global::Gtk.FileChooserButton (global::Mono.Unix.Catalog.GetString ("选择Hex文件"), ((global::Gtk.FileChooserAction)(0)));
		this.filechooserbuttonHex.Name = "filechooserbuttonHex";
		this.hboxHex.Add (this.filechooserbuttonHex);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxHex[this.filechooserbuttonHex]));
		w2.Position = 1;
		this.tableMain.Add (this.hboxHex);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tableMain[this.hboxHex]));
		w3.TopAttach = ((uint)(2));
		w3.BottomAttach = ((uint)(3));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableMain.Gtk.Table+TableChild
		this.hbuttonboxMain = new global::Gtk.HButtonBox ();
		this.hbuttonboxMain.Name = "hbuttonboxMain";
		// Container child hbuttonboxMain.Gtk.ButtonBox+ButtonBoxChild
		this.buttonConvert = new global::Gtk.Button ();
		this.buttonConvert.CanFocus = true;
		this.buttonConvert.Name = "buttonConvert";
		this.buttonConvert.UseUnderline = true;
		this.buttonConvert.Label = global::Mono.Unix.Catalog.GetString ("转换(_C)");
		this.hbuttonboxMain.Add (this.buttonConvert);
		global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonboxMain[this.buttonConvert]));
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbuttonboxMain.Gtk.ButtonBox+ButtonBoxChild
		this.buttonAbout = new global::Gtk.Button ();
		this.buttonAbout.CanFocus = true;
		this.buttonAbout.Name = "buttonAbout";
		this.buttonAbout.UseUnderline = true;
		this.buttonAbout.Label = global::Mono.Unix.Catalog.GetString ("关于(_A)");
		this.hbuttonboxMain.Add (this.buttonAbout);
		global::Gtk.ButtonBox.ButtonBoxChild w5 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonboxMain[this.buttonAbout]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbuttonboxMain.Gtk.ButtonBox+ButtonBoxChild
		this.buttonQuit = new global::Gtk.Button ();
		this.buttonQuit.CanFocus = true;
		this.buttonQuit.Name = "buttonQuit";
		this.buttonQuit.UseUnderline = true;
		this.buttonQuit.Label = global::Mono.Unix.Catalog.GetString ("退出(_Q)");
		this.hbuttonboxMain.Add (this.buttonQuit);
		global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonboxMain[this.buttonQuit]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.tableMain.Add (this.hbuttonboxMain);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableMain[this.hbuttonboxMain]));
		w7.TopAttach = ((uint)(3));
		w7.BottomAttach = ((uint)(4));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child tableMain.Gtk.Table+TableChild
		this.imageLogo = new global::Gtk.Image ();
		this.imageLogo.Name = "imageLogo";
		this.imageLogo.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("HexToBin.icon.main.hextobin_192x192.png");
		this.tableMain.Add (this.imageLogo);
		// Container child tableMain.Gtk.Table+TableChild
		this.labelTitle = new global::Gtk.Label ();
		this.labelTitle.Name = "labelTitle";
		this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("<span font_desc='16'>Hex转Bin工具</span>");
		this.labelTitle.UseMarkup = true;
		this.tableMain.Add (this.labelTitle);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableMain[this.labelTitle]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add (this.tableMain);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 263;
		this.DefaultHeight = 322;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonConvert.Clicked += new global::System.EventHandler (this.OnButtonConvertClicked);
		this.buttonAbout.Clicked += new global::System.EventHandler (this.OnButtonAboutClicked);
		this.buttonQuit.Clicked += new global::System.EventHandler (this.OnButtonQuitClicked);
		this.filechooserbuttonHex.SelectionChanged += new global::System.EventHandler (this.OnFilechooserbuttonHexSelectionChanged);
	}
}
