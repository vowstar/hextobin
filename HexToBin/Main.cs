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
#define _USEING_GTK_
using System;
using System.IO;
#if _USEING_GTK_
using Gtk;
#endif


namespace HexToBin
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Boolean _ShowHelp = false;
			Boolean _Bye = false;
			Boolean _ShowVersion = false;
			Boolean _Desktop = false;
			Boolean Error = false;
			string HexPath = "";
			string BinPath = "";
			ConsoleOutput.WriteTitle ();
			if (args.Length > 0) {
				int i = 0;
				// Console.WriteLine ("Arguments Count:{0}", args.Length);
				while (i < args.Length) {
					if (args[i].Length > 0) {
						if (args[i][0] == '-') {
							if (args[i].Length > 1) {
								if (args[i].Length == 2) {
									switch (args[i]) {
									case "-h":
										_ShowHelp = true;
										break;
									case "-q":
										_Bye = true;
										break;
									case "-v":
										_ShowVersion = true;
										break;
									default:
										ConsoleOutput.WriteError ("E:At[{0}]:Unknown argument:\"{1}\".", i, args[i]);
										Error = true;
										break;
									}
									
								} else
									switch (args[i][1]) {
									case '-':
										if (args[i].Length > 2) {
											//To add something
											switch (args[i]) {
											case "--help":
												_ShowHelp = true;
												break;
											case "--exit":
												_Bye = true;
												break;
											case "--desktop":
												_Desktop = true;
												break;
											case "--version":
												_ShowVersion = true;
												break;
											default:
												ConsoleOutput.WriteError ("E:At[{0}]:Unknown argument:\"{1}\".", i, args[i]);
												Error = true;
												break;
											}
										} else {
											ConsoleOutput.WriteError ("E:At[{0}]:Half-baked argument:\"{1}\".", i, args[i]);
											Error = true;
										}
										break;
									default:
										ConsoleOutput.WriteError ("E:At[{0}]:Unknown argument:\"{1}\".", i, args[i]);
										Error = true;
										break;
									}
							} else {
								ConsoleOutput.WriteError ("E:At[{0}]:Half-baked argument:\"{1}\".", i, args[i]);
								Error = true;
							}
						} else {
							switch (args[i]) {
							case "?":
								_ShowHelp = true;
								break;
							default:
								if (HexPath == "") {
									HexPath = Path.GetFullPath (args[i]);
								} else if (BinPath == "") {
									BinPath = Path.GetFullPath (args[i]);
								} else {
									ConsoleOutput.WriteError ("E:At[{0}]:Unknown argument:\"{1}\".", i, args[i]);
									Error = true;
								}
								break;
							}
						}
					} else {
						ConsoleOutput.WriteError ("E:At[{0}]:Can not use null argument.", i);
						Error = true;
					}
					i++;
				}
//				Console.WriteLine("Hello");
//				Console.Write(1);
//				FileStream fs =new FileStream("out.txt",FileMode.OpenOrCreate);
//			    StreamWriter sw = new StreamWriter(fs);
//				sw.WriteLine(args[0]);
//				sw.WriteLine("aaa");
//				sw.Close();
//				sw.Dispose();
//				fs.Close();
//				fs.Dispose();
				//Console.WriteLine(Path.GetFullPath(args[0]));
				//File.Exists();
				
			} else {
				_Desktop = true;
			}
			// Engine code
			if (!Error) {
				if (_Bye) {
					Console.WriteLine ("\tBye bye!");
				} else {
					if (_ShowVersion) {
						Console.WriteLine ("\tVersion:{0}", System.Reflection.Assembly.GetExecutingAssembly ().GetName ().Version.ToString ());
					}
					if (_ShowHelp) {
						Console.WriteLine ("\tHex to bin help:");
					}
					if (HexPath.Length > 0) {
						Console.WriteLine ("\tHex input file:\n{0}", HexPath);
						if (BinPath.Length == 0) {
							BinPath = Path.Combine (Path.GetDirectoryName (HexPath), Path.GetFileNameWithoutExtension (HexPath) + ".bin");
						}
						Console.WriteLine ("\tBin output file:\n{0}", BinPath);
						ConsoleOutput.LongSingleLine();
						Console.WriteLine("\tBegin convert");
						if(!File.Exists(HexPath))
						{
							ConsoleOutput.WriteError("E:Hex input file NOT EXIST!");
							Error=true;
						}
						if(File.Exists(BinPath))
						{
							ConsoleOutput.Writewarning("W:Bin output file already exist.");
						}
						if(Path.GetExtension(HexPath).ToUpper()!=".HEX")
						{
							ConsoleOutput.Writewarning("W:Hex file\'s extension is not \".hex\"");
						}
						if(Path.GetExtension(BinPath).ToUpper()!=".BIN")
						{
							ConsoleOutput.Writewarning("W:Bin file\'s extension is not \".bin\"");
						}
						
					}
					
					if (_Desktop) {
					#if _USEING_GTK_
						Console.WriteLine ("\tRunning GUI interface...");
						Application.Init ();
						MainWindow win = new MainWindow ();
						win.Show ();
						Application.Run ();	
					#else
					    Console.WriteLine ("\tNo GUI interface to run,please download GUI version.");
                    #endif
					}
                    
					Console.WriteLine ("\tSafe exited.");
					ConsoleOutput.LongSingleLine();
				}
			} else {
				Console.WriteLine ("\tAn Error occured,exited.");
				ConsoleOutput.LongSingleLine();
			}
			// Engine code end
		}
	}
}

