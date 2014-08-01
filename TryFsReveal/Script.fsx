﻿#I @"..\packages\FSharp.Formatting.2.4.18\lib\net40"
#r "FSharp.Literate.dll"
#I @"..\packages\FSharp.Compiler.Service.0.0.57\lib\net40"
#r "FSharp.Compiler.Service.dll"
#r @"..\packages\FsReveal.0.0.1-beta\lib\net40\FsReveal.dll"
open FsReveal

let outDir = @"g:\output"

open System.IO
let inputMd = Path.Combine( __SOURCE_DIRECTORY__, "input.md")
let inputFsx = Path.Combine( __SOURCE_DIRECTORY__, "input.fsx")

FsReveal.GenerateOutputFromMarkdownFile outDir "index.html" inputMd
FsReveal.GenerateOutputFromScriptFile outDir "index.html" inputFsx