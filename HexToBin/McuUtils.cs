using System;
using System.IO;
public class McuUtils
{
	private string _hexfile;
	private string _binfile;
	private string _hex;
	private byte[] _bin;
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
		set {
			_hex = value.ToUpper ();
			HexToBin ();
		}
	}
	public byte[] Bin {
		get { return _bin; }
		set { _bin = value; }
	}
	public Boolean ReadHexFile ()
	{
		if (_hexfile == null) {
			ConsoleOutput.WriteError ("E:Have not given hex filename.");
			return false;
		} else if (File.Exists (_hexfile)) {
			try {
				FileStream fs = new FileStream (_hexfile, FileMode.Open);
				StreamReader sr = new StreamReader (fs);
				fs.Position = 0;
				Hex = sr.ReadToEnd ();
				sr.Close ();
				sr.Dispose ();
				fs.Close ();
				fs.Dispose ();
				sr = null;
				fs = null;
				return true;
			} catch (Exception ex) {
				ConsoleOutput.WriteError ("E:ReadHexFile:{0}", ex.Message);
				return false;
			}
			
		} else {
			ConsoleOutput.WriteError ("E:File not exists when reading hex file.");
			return false;
		}
	}

	public Boolean ReadBinFile ()
	{
		if (_hexfile == null) {
			ConsoleOutput.WriteError ("E:Have not given bin filename.");
			return false;
		} else if (File.Exists (_hexfile)) {
			try {
				FileStream fs = new FileStream (_hexfile, FileMode.Open);
				fs.Position = 0;
				byte[] temp = new byte[fs.Length];
				fs.Read (temp, 0, (int)fs.Length);
				Bin = temp;
				temp = null;
				fs.Close ();
				fs.Dispose ();
				fs = null;
				return true;
			} catch (Exception ex) {
				ConsoleOutput.WriteError ("E:{0}", ex.Message);
				return false;
			}
			
		} else {
			ConsoleOutput.WriteError ("E:File not exists when reading bin file.");
			return false;
		}
		
	}
	public Boolean WriteHexFile ()
	{
		return false;
	}

	public Boolean WriteBinFile ()
	{
		if (_binfile == null) {
			ConsoleOutput.WriteError ("E:Have not given bin filename.");
			return false;
		} else {
			try {
				FileStream fs = new FileStream (_binfile, FileMode.OpenOrCreate);
				fs.SetLength (0);
				fs.Position = 0;
				fs.Write (_bin, 0, _bin.Length);
				fs.Close ();
				fs.Dispose ();
				fs = null;
				return true;
			} catch (Exception ex) {
				ConsoleOutput.WriteError ("E:{0}", ex.Message);
				return false;
			}
		}
	}

	private Boolean HexToBin ()
	{
		if (_hex == null) {
			ConsoleOutput.WriteError ("E:Null hex.");
			return false;
		} else {
			int HexEnd = _hex.LastIndexOf (":00000001FF");
			//Console.WriteLine ("Last:{0}", HexEnd);
			if (HexEnd < 0) {
				ConsoleOutput.WriteError ("E:Hex file too short.");
				return false;
			}
			
			int Begin_addr_seg = 0;
			int Begin_addr_line = 0;
			int Max_addr_seg = 0;
			int Max_addr_line = 0;
			bool SkipSeg = false;
			bool SkipLine = false;
			int Now_addr = 0;
			int start_addr = 0;
			byte Now_len = 0;
			byte len = 0;
			byte addr1, addr2, addr3, addr4;
			byte sum, rbyte;
			int i, j, bin_length;
			bool Error = false;
			
			HexEnd--;
			
			bin_length = 0;
			i = 0;
			while (i < HexEnd) {
				if (_hex[i] == ':') {
					len = Convert.ToByte (_hex.Substring (i + 1, 2), 16);
					addr1 = Convert.ToByte (_hex.Substring (i + 3, 2), 16);
					addr2 = Convert.ToByte (_hex.Substring (i + 5, 2), 16);
					start_addr = (addr1 << 8) + addr2;
					
					//-----checksum  start
					sum = 0;
					for (j = 0; j < (len + 5); j++) {
						//5: length,addr1,addr2,label,checksum
						rbyte = Convert.ToByte (_hex.Substring (i + 1 + j * 2, 2), 16);
						sum += rbyte;
					}
					if (sum != 0) {
						ConsoleOutput.WriteError ("E:Checksum error in hex file.");
						Error = true;
						return false;
					}
					//-----checksum  end 					
					switch (_hex[i + 8]) {
					case '0':
						//Data record
						if ((SkipSeg == false) && (SkipLine == false)) {
							if (start_addr >= Now_addr) {
								Now_addr = start_addr;
								Now_len = len;
							}
							bin_length += len;
						}
						break;
					
					case '1':
						//End of file record
						ConsoleOutput.WriteError ("E:Wrong label in hex file.");
						
						Error = true;
						
						break;
					
					case '2':
						//Extended segment address record
						addr1 = Convert.ToByte (_hex.Substring (i + 9, 2), 16);
						addr2 = Convert.ToByte (_hex.Substring (i + 11, 2), 16);
						
						
						if (Max_addr_seg <= (((addr1 << 8) + addr2) << 4)) {
							Max_addr_seg = ((addr1 << 8) + addr2) << 4;
							SkipSeg = false;
							Now_addr = 0;
						} else {
							SkipSeg = true;
						}
						break;
					
					case '4':
						//Extended linear address record
						addr1 = Convert.ToByte (_hex.Substring (i + 9, 2), 16);
						addr2 = Convert.ToByte (_hex.Substring (i + 11, 2), 16);
						
						if (Max_addr_line <= ((addr1 << 8) + addr2) << 16) {
							Max_addr_line = ((addr1 << 8) + addr2) << 16;
							SkipLine = false;
							Now_addr = 0;
						} else {
							SkipLine = true;
						}
						break;
					
					case '3':
						//Start segment address record
						addr1 = Convert.ToByte (_hex.Substring (i + 9, 2), 16);
						addr2 = Convert.ToByte (_hex.Substring (i + 11, 2), 16);
						addr3 = Convert.ToByte (_hex.Substring (i + 13, 2), 16);
						addr4 = Convert.ToByte (_hex.Substring (i + 15, 2), 16);
						
						Begin_addr_seg = (addr1 << 24) + (addr2 << 16) + (addr3 << 8) + addr4;
						Console.WriteLine ("\tAddress segment begin:{0}", Begin_addr_seg.ToString ("X4"));
						break;
					
					case '5':
						//Start linear address record
						addr1 = Convert.ToByte (_hex.Substring (i + 9, 2), 16);
						addr2 = Convert.ToByte (_hex.Substring (i + 11, 2), 16);
						
						Begin_addr_line = ((addr1 << 8) + addr2) << 16;
						Console.WriteLine ("\tAddress Line begin:{0}", Begin_addr_line.ToString ("X4"));
						break;
					default:
						ConsoleOutput.WriteError ("E:Wrong label in hex file.");
						Error = true;
						break;
					}
					
					i += len * 2 + 11;
				} else {
					i++;
				}
			}
			
			if (!Error) {
				
				Now_addr += Now_len;
				if (Now_addr >= bin_length)
					bin_length = Now_addr;
				
				//Console.WriteLine ("\tBin Length={0}", bin_length);
// ================================================================
				byte Fill = 0xff;
				byte[] result = new byte[bin_length];
				for (j = 0; j < bin_length; j++)
					result[j] = Fill;
				
				Max_addr_seg = 0;
				Max_addr_line = 0;
				i = 0;
				while (i < HexEnd) {
					
					if (Error)
						break;
					
					if (_hex[i] == ':') {
						len = Convert.ToByte (_hex.Substring (i + 1, 2), 16);
						addr1 = Convert.ToByte (_hex.Substring (i + 3, 2), 16);
						addr2 = Convert.ToByte (_hex.Substring (i + 5, 2), 16);
						
						start_addr = (addr1 << 8) + addr2;
						
						switch (_hex[i + 8]) {
						case '0':
							//Data record
							start_addr += Max_addr_seg + Max_addr_line;
							for (j = 0; j < len; j++) {
								rbyte = Convert.ToByte (_hex.Substring (i + 9 + (j * 2), 2), 16);
								result[start_addr + j] = rbyte;
								//Begin_addr_seg  Begin_addr_line
							}

							
							
							break;
						
						case '1':
							//End of file record
							ConsoleOutput.WriteError ("E:Wrong label in hex file.");
							Error = true;
							break;
						
						case '2':
							//Extended segment address record
							addr1 = Convert.ToByte (_hex.Substring (i + 9, 2), 16);
							addr2 = Convert.ToByte (_hex.Substring (i + 11, 2), 16);
							
							Max_addr_seg = ((addr1 << 8) + addr2) << 4;
							break;
						
						case '4':
							//Extended linear address record
							addr1 = Convert.ToByte (_hex.Substring (i + 9, 2), 16);
							addr2 = Convert.ToByte (_hex.Substring (i + 11, 2), 16);
							
							Max_addr_line = ((addr1 << 8) + addr2) << 16;
							break;
						
						case '3':
						//Start segment address record
						case '5':
							//Start linear address record
							break;
						default:
							
							ConsoleOutput.WriteError ("E:Wrong label in hex file.");
							Error = true;
							break;
						}
						
						i += len * 2 + 11;
					} else {
						i++;
					}
				}
				_bin = result;
			}
		}
		return true;
	}
	public McuUtils ()
	{
	}
	
	
}

