// Learn more about F# at http://fsharp.org

open Python.Runtime
open FSharp.Interop.Dynamic
open System.Collections.Generic
open System

[<EntryPoint>]
let main argv =
    use gil = Py.GIL()

    let np = Py.Import("numpy")

    let sinResult = np?sin(5)

    Py.Print sinResult

    // printfn "%d" sinResult
    0 // return an integer exit code
