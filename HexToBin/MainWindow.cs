// --------------------------------------------------------------------------------------
// 本软件是自由软件,使用的是GNU通用公共许可证,许可证应使用第二版本或您所选择的更新的版本.
// 发布本软件的目的是希望它能够在一定程度上帮到您.但我们并不为它提供任何形式的担保，
// 也无法保证它可以在特定用途中得到您希望的结果.请参看GNU GPL许可中的更多细节.
// 使用本软件或者与本软件相关的代码,文档,图标之前,您必须接受本软件的协议及许可.
// 您应该在获取本代码同时获得了GNU GPL协议的副本.
// 如果您没有获得GNU GPL协议的副本的话,请给自由软件基金会写信,地址是:
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// 本软件及其代码的作者是黄锐,(Email:vowstar@gmail.com),Lanzhou University
// --------------------------------------------------------------------------------------
//#define _USEING_GTK_
//#if _USEING_GTK_
using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	HexToBin.AboutWindow aboutWindow;
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
		FileFilter filter = new FileFilter ();
		filter.AddPattern ("*.[hH][eE][xX]");
		filter.Name = "Hex 文件";
		FileFilter filterAll = new FileFilter ();
		filterAll.AddPattern ("*");
		filterAll.Name = "所有文件";
		filechooserbuttonHex.AddFilter (filter);
		filechooserbuttonHex.AddFilter (filterAll);
		
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected virtual void OnButtonConvertClicked (object sender, System.EventArgs e)
	{
		FileChooserDialog fcd = new FileChooserDialog ("保存Bin文件      ", this, FileChooserAction.Save, "Cancel", ResponseType.Cancel, "Open", ResponseType.Accept);
		
		fcd.SelectMultiple = false;
		fcd.Modal = true;
		
		fcd.ShowAll ();
		
	}
	protected virtual void OnButtonQuitClicked (object sender, System.EventArgs e)
	{
		DeleteEventArgs a = new DeleteEventArgs ();
		OnDeleteEvent (this, a);
	}

	protected virtual void OnButtonAboutClicked (object sender, System.EventArgs e)
	{
		if (aboutWindow == null) {
			aboutWindow = new HexToBin.AboutWindow ();
		} else {
			if (!aboutWindow.Visible)
				aboutWindow = new HexToBin.AboutWindow ();
		}
	}
	
	
	
}

//#endif
