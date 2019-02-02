module App

(**
 The famous Increment/Decrement ported from Elm.
*)

// MODEL

type Model = int

type Msg =
| Increment
| Decrement

let init() : Model = 0

// UPDATE

let update (msg:Msg) (model:Model) =
    match msg with
    | Increment -> model + 1
    | Decrement -> model - 1

// VIEW (rendered as you decide)

let view (model:Model) dispatch =
  div []
      [ button [ OnClick (fun _ -> dispatch Increment) ] [ str "+" ]
        div [] [ str (string model) ]
        button [ OnClick (fun _ -> dispatch Decrement) ] [ str "-" ] ]

// App
Program.mkSimple init update view
|> Program.withConsoleTrace
|> Program.run
