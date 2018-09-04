# PathHack
I often need to use external applications in command line 
and tired of "'some-app' is not recognized as an internal or external command".
Adding applications to PATH environment variable is tedious(ish) task in windows because 
1.you need to add the directory where the file exists to the PATH environment variable and can't just add one executable and the capacity.
2.you can't add many items in PATH because in regular development environment you need to add tens of directories to PATH and it doesn't have enough space for that.
Solution: 
1. We add one folder to PATH.
2.Put PathHack.exe in it. 
Now we can make any app callable from command line by running command "PathHack .\app-path-to-add.exe"
