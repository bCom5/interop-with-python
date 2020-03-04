// Learn more about F# at http://fsharp.org

open Python.Runtime
open FSharp.Interop.Dynamic
open System.Collections.Generic
open System

[<EntryPoint>]
let main argv =
    use gil = Py.GIL()
    let pyScope = Py.CreateScope("test")

    let pyCodeExample = 
        "import os\n\
        os.system(\"git add .\")\n\
        os.system(\"git commit -m 'commit ran from fsharp ran from python'\")\n\
        os.system(\"git push'\")"
    pyScope.Exec(pyCodeExample)
    0 // return an integer exit code
