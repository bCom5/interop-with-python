## Python in F Sharp

Holy Shit!!!

[](https://olney.ai/category/2015/11/15/fsharp-pythonnet.html)


`dotnet add package stuff`. Check the fsproj
```
<PackageReference Include="FSharp.Interop.Dynamic" Version="5.0.1.268" />
<PackageReference Include="Python.Runtime.OSX" Version="3.7.0" />
```

Fix in shell for library. It was 3.7.3
```sh
export LD_LIBRARY_PATH=/usr/local/Cellar/python/3.7.3/Frameworks/Python.framewor
k/Versions/3.7/lib/:$LD_LIBRARY_PATH
```# interop-with-python
