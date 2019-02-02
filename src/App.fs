module App

open Fable.Core

// MODEL

type Model = int

// INITIAL STATE

let init() : Model = 0

// STATE

let counter = init()

// UPDATE: TODO

// DISPLAY STATE
printfn "Hello World: %i" counter

// SEE RESULT IN BROWSER CONSOLE