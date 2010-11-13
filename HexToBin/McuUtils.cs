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

using System;
using System.IO;
public class McuUtils
{
	private string _hexfile = "";
	private string _binfile = "";
	private string _hex = "";
	private byte[] _bin = new byte[0];
	public string HexFile {
		get { return _hexfile; }
		set { _hexfile = value; }
	}
	public string BinFile {
		get { return _binfile; }
		set { _binfile = value; }
	}
	public string Hex {
		get { return _hex; }
		set { _hex = value; }
	}
	public byte[] Bin {
		get { return _bin; }
		set { _bin = value; }
	}
	public Boolean ReadHexFile ()
	{
		if (File.Exists (_hexfile)) {
			try {
				FileStream fs = new FileStream (_hexfile, FileMode.Open);
				StreamReader sr = new StreamReader (fs);
				fs.Position = 0;
				_hex = sr.ReadToEnd ();
				sr.Close ();
				sr.Dispose ();
				fs.Close ();
				fs.Dispose ();
				return true;
			} catch (Exception ex) {
				ConsoleOutput.WriteError ("E:{0}", ex.Message);
				return false;
			}
			
		} else {
			ConsoleOutput.WriteError ("E:File not exists when reading hex file.");
			return false;
		}
	}

	public Boolean ReadBinFile ()
	{
		return false;
	}
	public Boolean WriteHexFile ()
	{
		return false;
	}

	public Boolean WriteBinFile ()
	{
		return false;
	}

	public McuUtils ()
	{
	}
	
	
}

