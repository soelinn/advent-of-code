open System
open System.IO

let inputSeq = File.ReadLines("./inputs/day02.txt")

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


let (x1, y1) = Seq.fold execCmd (0, 0) inputSeq
let (x2, y2, _) = Seq.fold execCmdWithAim (0, 0, 0) inputSeq

printfn "Part 1 Answer: %i" (x1 * y1)
printfn "Part 2 Answer: %i" (x2 * y2)
