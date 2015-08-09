# IPUDecoderGUI
## Introduction
[IPUDecoder](https://github.com/samehb/IPUDecoder) decodes IPU videos and converts them into the M2V format. IPUDecoderGUI provides an easy to use drag and drop interface to the IPUDecoder project. It also allows the handling of IPS files (that contain IPUs). The interface is limited and does not provide multithreading support. I might enhance the interface and add MT support, in the future.

## How to Use
Compile both the [IPUDecoder](https://github.com/samehb/IPUDecoder) and IPUDecoderGUI projects, then do the following:

1. Place both executables from IPUDecoder and IPUDecoderGUI into same the folder.
2. Open IPUDecoderGUI.
3. Place the IPS/IPU files you want converted into the same folder from step 1. The executables and the IPS/IPU files must be in the same folder.
4. Drag and drop the files you want to convert into the IPUDecoderGUI box. Note that the box only accepts IPS and IPU files.
5. Click Process, then wait for the message to the bottom show. The statusbar tells you whether or not the files were converted successfully.
6. Open the converted M2V files and see if they are showing properly. If that is not the case, check the Alternative Mode checkbox on IPUDecoderGUI then hit process again. That should fix it.

If you receive an error message, that means you did not follow the steps above correctly. Read step 3, carefully. Also, note that the processing might take a while depending on file sizes. So, wait for the statusbar message to show. That is when you know, the tool has finished.

## Copyright
The GUI utilizes the [IPUDecoder](https://github.com/samehb/IPUDecoder). The IPUDecoder belongs to Holger Kuhn (hawkear@gmx.de). Contact him if you are planning on using this for something that is not free.

## Links
[Blog](http://sres.tumblr.com/)
