open System

let input = List.ofArray [|
  "forward 6";"forward 8";"down 6";"down 6";"forward 9";"down 7";"down 3";"forward 4";"forward 7";"up 3";
  "forward 9";"up 4";"forward 4";"down 3";"up 2";"forward 2";"down 4";"forward 9";"up 4";"forward 8";
  "up 9";"forward 3";"down 7";"down 4";"down 7";"up 5";"down 5";"down 5";"forward 5";"up 9";
  "down 5";"down 3";"up 3";"forward 2";"forward 2";"down 2";"forward 1";"down 4";"down 1";"down 6";
  "down 9";"forward 4";"forward 7";"down 4";"up 7";"forward 8";"down 3";"down 6";"down 5";"down 2";
  "down 1";"up 9";"forward 2";"forward 3";"up 3";"forward 5";"down 4";"up 3";"up 9";"forward 6";
  "up 5";"up 8";"up 8";"forward 6";"up 1";"forward 4";"down 4";"forward 9";"down 9";"down 7";
  "forward 5";"down 7";"forward 7";"up 2";"down 9";"down 2";"forward 8";"forward 9";"down 4";"down 4";
  "down 7";"down 4";"down 8";"forward 4";"down 9";"down 6";"forward 8";"down 8";"down 8";"forward 7";
  "up 9";"forward 7";"up 3";"down 5";"forward 9";"down 7";"down 5";"down 8";"forward 5";"down 1";
  "down 5";"down 5";"forward 8";"down 8";"up 8";"down 6";"down 3";"forward 1";"down 2";"down 3";
  "up 4";"forward 8";"down 6";"up 8";"forward 2";"forward 8";"forward 9";"forward 5";"forward 5";"forward 2";
  "forward 1";"down 8";"forward 8";"forward 9";"up 8";"up 8";"down 7";"down 5";"forward 1";"forward 1";
  "up 9";"up 3";"forward 5";"down 8";"down 4";"up 2";"down 7";"down 4";"down 3";"forward 3";
  "forward 7";"forward 3";"forward 1";"forward 8";"down 9";"up 4";"down 8";"down 3";"down 9";"up 8";
  "up 6";"up 9";"up 2";"down 9";"down 9";"down 6";"up 3";"down 4";"down 3";"down 9";
  "forward 2";"forward 2";"forward 7";"forward 9";"up 5";"up 8";"forward 8";"down 8";"up 7";"forward 4";
  "up 7";"up 7";"down 9";"down 7";"down 1";"forward 4";"forward 6";"up 4";"forward 7";"up 4";
  "down 6";"forward 2";"up 4";"forward 2";"up 2";"down 4";"down 2";"forward 4";"forward 8";"down 9";
  "up 7";"forward 3";"down 5";"down 2";"down 7";"up 9";"down 2";"up 5";"down 9";"down 4";
  "forward 8";"forward 9";"down 7";"up 3";"down 4";"up 3";"down 3";"down 3";"up 5";"forward 7";
  "down 8";"down 1";"up 7";"forward 8";"forward 9";"forward 3";"forward 1";"up 4";"forward 4";"down 6";
  "forward 3";"down 9";"forward 2";"up 8";"down 4";"forward 7";"forward 1";"up 9";"forward 6";"down 1";
  "down 8";"forward 7";"forward 8";"forward 2";"up 6";"forward 3";"forward 2";"forward 7";"down 6";"up 8";
  "down 2";"down 8";"forward 6";"forward 1";"up 9";"down 8";"down 4";"forward 3";"down 2";"forward 1";
  "forward 8";"down 9";"down 9";"forward 3";"down 5";"down 5";"down 1";"down 3";"up 3";"down 6";
  "forward 9";"forward 7";"up 5";"forward 8";"up 1";"up 4";"down 8";"up 3";"forward 1";"up 9";
  "forward 5";"down 8";"down 1";"up 3";"down 1";"down 7";"forward 2";"down 9";"forward 3";"down 2";
  "up 5";"down 5";"forward 9";"down 2";"down 3";"forward 4";"forward 2";"down 5";"forward 9";"down 5";
  "forward 9";"down 9";"down 8";"forward 8";"forward 9";"down 2";"forward 4";"forward 9";"up 1";"down 2";
  "down 5";"forward 8";"forward 5";"up 5";"forward 2";"up 8";"forward 3";"down 2";"forward 1";"forward 7";
  "forward 7";"forward 1";"up 9";"down 5";"down 3";"down 7";"forward 2";"up 5";"forward 1";"forward 7";
  "up 7";"down 3";"up 5";"down 1";"forward 9";"down 7";"forward 4";"forward 5";"down 1";"down 5";
  "up 7";"forward 1";"down 4";"down 8";"down 6";"forward 8";"forward 4";"forward 2";"up 8";"down 5";
  "down 2";"forward 2";"down 1";"down 8";"down 5";"forward 5";"forward 8";"down 9";"forward 1";"forward 3";
  "down 3";"down 1";"down 5";"forward 6";"forward 6";"down 3";"forward 5";"forward 8";"down 9";"down 9";
  "forward 4";"forward 4";"forward 1";"forward 7";"down 6";"up 2";"down 2";"up 6";"forward 7";"forward 8";
  "up 3";"down 7";"up 9";"down 5";"down 7";"down 7";"forward 3";"down 3";"up 9";"up 5";
  "forward 4";"down 7";"down 7";"forward 1";"down 1";"down 2";"forward 8";"down 9";"down 2";"forward 3";
  "forward 5";"down 4";"up 7";"forward 1";"forward 4";"forward 7";"forward 1";"up 1";"down 6";"forward 2";
  "down 1";"forward 2";"forward 7";"forward 7";"up 3";"down 8";"forward 6";"forward 1";"down 6";"down 8";
  "down 1";"up 3";"up 6";"down 6";"down 1";"up 8";"forward 6";"up 6";"forward 5";"up 4";
  "up 7";"up 4";"down 5";"forward 2";"forward 7";"down 1";"forward 6";"down 5";"up 3";"up 4";
  "forward 1";"up 4";"forward 7";"up 5";"up 1";"up 2";"forward 4";"forward 2";"forward 7";"down 6";
  "forward 1";"up 5";"up 2";"down 8";"forward 5";"up 2";"down 9";"up 4";"down 2";"down 1";
  "forward 8";"down 2";"up 8";"down 8";"up 7";"up 4";"up 2";"forward 8";"up 1";"up 6";
  "forward 8";"forward 8";"forward 2";"down 5";"up 2";"down 1";"forward 2";"up 5";"forward 4";"forward 9";
  "down 1";"down 6";"forward 4";"down 3";"down 7";"down 5";"down 6";"up 6";"forward 4";"down 2";
  "down 4";"down 3";"forward 3";"forward 2";"up 7";"forward 7";"forward 6";"forward 3";"forward 1";"forward 8";
  "forward 3";"forward 2";"forward 3";"forward 9";"down 3";"forward 9";"up 9";"up 1";"down 8";"down 2";
  "up 9";"down 8";"forward 5";"down 8";"up 8";"down 3";"up 7";"down 3";"down 7";"up 9";
  "up 8";"down 5";"down 1";"forward 1";"down 9";"forward 5";"down 1";"forward 5";"forward 6";"up 2";
  "forward 5";"down 2";"up 3";"forward 8";"forward 9";"down 1";"up 9";"forward 6";"down 9";"down 2";
  "forward 2";"forward 4";"forward 9";"forward 3";"down 6";"down 9";"forward 8";"forward 3";"down 9";"up 6";
  "forward 5";"forward 8";"down 7";"forward 9";"forward 5";"forward 4";"forward 3";"down 9";"forward 7";"forward 7";
  "forward 8";"down 7";"down 3";"up 5";"forward 2";"up 6";"down 6";"down 5";"up 2";"down 1";
  "forward 7";"forward 3";"down 2";"up 4";"forward 8";"down 8";"down 2";"forward 8";"up 8";"forward 1";
  "forward 1";"down 1";"forward 4";"forward 7";"forward 2";"forward 6";"down 9";"down 2";"up 7";"up 5";
  "forward 4";"down 3";"down 4";"up 7";"forward 7";"up 6";"forward 6";"up 4";"forward 5";"forward 7";
  "forward 3";"down 2";"forward 2";"forward 2";"up 1";"down 8";"up 7";"down 4";"down 9";"forward 2";
  "forward 9";"down 7";"down 4";"down 8";"forward 9";"up 1";"forward 6";"forward 7";"down 3";"forward 9";
  "forward 3";"down 3";"up 2";"down 8";"down 7";"forward 1";"down 9";"up 3";"forward 6";"forward 1";
  "forward 7";"down 3";"forward 2";"forward 1";"down 8";"down 7";"forward 1";"forward 5";"down 7";"up 7";
  "forward 4";"down 3";"forward 7";"forward 2";"up 2";"forward 1";"up 2";"up 6";"forward 3";"forward 2";
  "down 3";"down 7";"down 2";"down 9";"down 6";"forward 8";"down 4";"forward 6";"up 7";"down 8";
  "up 5";"down 8";"up 6";"down 2";"down 1";"forward 9";"forward 8";"down 6";"down 3";"up 8";
  "down 1";"forward 2";"down 6";"forward 4";"forward 9";"forward 6";"down 2";"down 9";"up 3";"forward 8";
  "forward 1";"forward 6";"forward 8";"forward 4";"forward 8";"up 7";"down 7";"forward 7";"down 6";"forward 1";
  "down 9";"forward 5";"down 3";"down 6";"down 6";"down 9";"forward 8";"forward 5";"down 4";"forward 1";
  "down 8";"down 5";"down 5";"down 9";"forward 1";"forward 1";"forward 9";"forward 5";"down 4";"forward 3";
  "down 2";"forward 3";"up 7";"down 2";"down 5";"down 4";"up 2";"forward 7";"down 3";"down 4";
  "down 8";"down 2";"forward 3";"up 8";"down 9";"down 1";"down 2";"forward 3";"down 1";"down 7";
  "down 9";"forward 9";"forward 7";"down 2";"down 5";"up 8";"forward 1";"forward 2";"forward 6";"up 3";
  "forward 3";"down 6";"forward 1";"up 8";"down 3";"down 1";"forward 6";"up 7";"forward 3";"down 5";
  "down 5";"up 8";"down 4";"forward 1";"up 5";"down 4";"forward 5";"up 6";"forward 2";"up 4";
  "forward 9";"forward 1";"forward 9";"forward 5";"forward 9";"up 2";"forward 8";"forward 6";"down 5";"forward 9";
  "forward 7";"down 1";"forward 7";"forward 7";"forward 3";"up 9";"down 2";"up 7";"down 1";"up 7";
  "forward 6";"forward 2";"forward 5";"forward 6";"down 4";"down 8";"forward 6";"down 1";"forward 7";"up 8";
  "forward 7";"up 5";"down 2";"forward 9";"forward 7";"forward 8";"up 2";"down 9";"forward 5";"forward 8";
  "forward 5";"forward 7";"down 8";"down 8";"up 4";"down 8";"up 2";"up 6";"down 2";"forward 2";
  "forward 9";"forward 8";"forward 3";"up 3";"up 1";"down 3";"forward 7";"down 2";"up 2";"forward 5";
  "down 3";"forward 2";"forward 4";"up 2";"down 1";"down 5";"up 6";"down 7";"up 7";"up 6";
  "forward 5";"down 7";"forward 9";"forward 2";"up 8";"down 1";"down 6";"forward 9";"down 8";"up 7";
  "down 6";"forward 9";"forward 2";"down 1";"up 4";"up 7";"down 7";"up 6";"forward 4";"up 1";
  "forward 5";"forward 9";"down 3";"up 2";"down 3";"up 7";"down 8";"forward 1";"down 9";"down 1";
  "down 9";"forward 8";"down 4";"down 7";"down 7";"forward 4";"up 5";"forward 1";"forward 7";"down 9";
  "forward 6";"up 8";"down 5";"down 8";"up 9";"forward 6";"down 1";"forward 8";"up 8";"up 1";
  "up 7";"down 9";"forward 8";"down 8";"forward 4";"down 1";"down 5";"forward 9";"down 7";"forward 3";
  "forward 1";"forward 2";"down 9";"up 2";"up 1";"forward 6";"up 1";"down 3";"forward 3";"down 7";
  "down 4";"forward 2";"forward 8";"forward 7";"down 6";"up 1";"forward 8";"down 8";"forward 5";"down 4";
  "forward 2";"up 8";"down 5";"down 9";"forward 1";"down 8";"down 5";"forward 6";"down 1";"down 6";
  "up 5";"up 8";"forward 7";"forward 4";"down 5";"down 1";"forward 4";"up 9";"forward 9";"up 7";
  "down 4";"forward 8";"forward 5";"up 8";"down 9";"up 8";"forward 7";"down 8";"forward 4";"down 8";
  "up 7";"forward 4";"down 9";"forward 5";"up 7";"forward 5";"forward 9";"down 6";"up 6";"forward 2";
  "down 4";"down 8";"forward 9";"forward 4";"forward 6";"up 6";"down 6";"forward 6";"forward 7";"forward 5";
  "forward 3";"forward 7";"up 3";"down 6";"forward 2";"down 9";"up 8";"down 2";"forward 7";"down 9";
  "down 3";"up 9";"up 6";"down 6";"forward 8";"up 2";"up 1";"down 5";"forward 4";"down 2";
  "up 2";"forward 2";"forward 3";"up 5";"down 6";"forward 9";"up 3";"forward 6";"forward 4";"down 3";
  "up 9";"forward 1";"up 6";"down 9";"down 7";"forward 5";"down 2";"down 6";"forward 5";"forward 1";
  "forward 5";"forward 8";"up 2";"forward 9";"down 8";"forward 2";"down 6";"down 1";"down 9";"forward 6"|]

type Move =
| Forward of int32
| Up of int32
| Down of int32
| NoOp

let parseCmd (s: string) =
  let arr = s.Split([|' '|], StringSplitOptions.RemoveEmptyEntries)
  match arr with
  | [|m; sn|] ->
    let n = Convert.ToInt32(sn)
    match m with
    | "forward" -> Forward n
    | "down" -> Down n
    | "up" -> Up n
    | _ -> NoOp
  | _ -> NoOp

let execCmd pos cmd =
    let (cx, cy) = pos
    match parseCmd cmd with
    | NoOp      -> pos
    | Up n      -> (cx, cy - n)
    | Down n    -> (cx, cy + n)
    | Forward n -> (cx + n, cy)

// Part 2 — with aim
let execCmdWithAim pos cmd =
    let (cx, cy, ca) = pos
    match parseCmd cmd with
    | NoOp      -> pos
    | Up n      -> (cx, cy, ca - n)
    | Down n    -> (cx, cy, ca + n)
    | Forward n -> (cx + n, cy + (ca * n), ca)


let (x1, y1) = List.fold execCmd (0, 0) input
let (x2, y2, _) = List.fold execCmdWithAim (0, 0, 0) input

printfn "Part 1 Answer: %i" (x1 * y1)
printfn "Part 2 Answer: %i" (x2 * y2)
