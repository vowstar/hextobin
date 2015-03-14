# HexToBin #
## Convert Hex file to Bin file ##
## 将intel hex 文件转换成bin文件的小工具. ##
# 使用方法 #
> ## SYNOPSIS ##

> hextobin -v

> hextobin --desktop

> hextobin Hexfilename.hex Binaryfile‐name.bin

> ## OPTIONS ##
> > These programs follow the usual GNU  command  line  syntax,  with  long
> > options  starting  with  two  dashes  (`-').   A  summary of options is
> > included below.  For a complete description, see the Info files.


> -h, --help
> > Show summary of options.It will tell you how to use hextobin.


> -v, --version
> > Show version of program.


> -q, --quit
> > Do nothing but exit.


> --exit
> > Do nothing but exit.


> --desktop
> > Show GUI.


# 详细安装方法: #

### Linux下 ###

> ### Ubuntu下 ###
> #### Ubuntu 10.04，10.10，13.04, 13.10 下 ####

> 打开终端,
```
   sudo add-apt-repository ppa:huangr08/ppa

   sudo apt-get update

   sudo apt-get install hextobin
```
> 在此下载相关deb包.

> https://launchpad.net/~huangr08/+archive/ppa/+packages

> #### Ubuntu 8.04 下 ####
```
   sudo apt-key adv –keyserver keyserver.ubuntu.com –recv-keys D4A1DA23 
```

> 在/etc/apt/sources.list中添加:
```

   deb http://ppa.launchpad.net/huangr08/ppa/ubuntu hardy main 

   deb-src http://ppa.launchpad.net/huangr08/ppa/ubuntu hardy main

```

> 然后
```
   sudo apt-get update

   sudo apt-get install hextobin
```


> #### 其他发行版下: ####

  1. 下载最新的源码包
```
   hextobin-latest.tar.gz
```
> [到此下载](http://code.google.com/p/hextobin/downloads/list)
> 注:本文中使用的latest,要根据您实际使用的版本而定.
> 2.安装编译所依赖的库和软件包
```
   autotools-dev, 

   mono-devel,  

   libglade2.0-cil-dev,   

   libmono-addins-cil-dev (>= 0.3.1),

   libmono-addins-gui-cil-dev (>= 0.3.1),

   libglib2.0-cil-dev,

   libgtk2.0-cil-dev (>= 2.12), 

   gconf2,

   libglib2.0-dev,

   libgtk2.0-dev (>= 2.8)
```
> 3.编译安装
```
   tar -zxvf hextobin-latest.tar.gz

   cd hextobin-latest

   ./configure

   make

   sudo make install 
```
> 4.卸载编译所依赖的库和软件包,安装运行所依赖的库和软件包,以便您获得最干净的系统.
```
   mono

   libmono-i18n2.0-cil
```
> 5.终端运行
```
   hextobin
```
### Windows下: ###

> ### Windows 2000,XP ###
    1. 下载并且安装[.NET Framework 2.0](http://msdn.microsoft.com/en-us/netframework/aa731542.aspx)或者[.NET Framework 3.5](http://www.microsoft.com/downloads/details.aspx?displaylang=en&FamilyID=c17ba869-9671-4330-a63e-1fd44e0e2505)(当然3.5更好).
    1. 到 http://ftp.novell.com/pub/mono/gtk-sharp/ 下载最新的gtk-sharp并且安装.[下载gtk-sharp-2.12.9-2.win32.msi](http://ftp.novell.com/pub/mono/gtk-sharp/gtk-sharp-2.12.9-2.win32.msi)
    1. 下载[hextobin.exe](http://code.google.com/p/hextobin/downloads/list)并且运行.
> ### Windows Vista ###
    1. 先尝试Windows7的安装方法.
    1. 若上一步失败,尝试XP下的安装方法.
> ### Windows 7 ###
    1. 到 http://ftp.novell.com/pub/mono/gtk-sharp/ 下载最新的gtk-sharp并且安装.[下载gtk-sharp-2.12.9-2.win32.msi](http://ftp.novell.com/pub/mono/gtk-sharp/gtk-sharp-2.12.9-2.win32.msi)
    1. 下载[hextobin.exe](http://code.google.com/p/hextobin/downloads/list)并且运行.

### MAC OS下 ###
> 开发中

---


![http://i659.photobucket.com/albums/uu316/vowstar/screenshot22.png](http://i659.photobucket.com/albums/uu316/vowstar/screenshot22.png)


---


访问我的空间[蝶晓梦](http://hi.baidu.com/littlevowstar/item/e3008a219ec31ccaa5275aff/),在此留下建议.或者直接提交[Issues](https://code.google.com/p/hextobin/issues/list).


[欢迎反馈bug给作者](http://code.google.com/p/hextobin/issues/list)

黄锐,兰州大学