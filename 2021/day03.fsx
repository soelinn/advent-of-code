open System
open System.IO

// Hard-coded as this code is intended for efficiently solving puzzles
// and not for error handling like in a real application.
let siglen = 12 // signal length

let inputSeq = File.ReadLines("./inputs/day03.txt")

let seed = (0, Array.zeroCreate siglen)

// count (1) number of lines and (2) 1s per column per string
let (lineCount, ones) =
    (seed, inputSeq)
    ||> Seq.fold (fun tupleAcc s ->
        let curr =
            s.ToCharArray()
            |> Array.map (fun c -> if c = '1' then 1 else 0)

        let (lineCount, acc) = tupleAcc

        // (increment lineCount, new accumulator counting 1s)
        (lineCount + 1, Array.init siglen (fun index -> acc[index] + curr[index])))

let gammaBits =
    ones
    |> Array.map (fun i -> if (i >= lineCount - i) then 1 else 0)

let epsilonBits =
    gammaBits
    |> Array.map (fun i -> if i = 0 then 1 else 0) // simply flip opposite

let gamma =
    Convert.ToInt32(String.Join("", gammaBits), 2)

let epsilon =
    Convert.ToInt32(String.Join("", epsilonBits), 2)

printfn "Part 1 Answer: %i" (gamma * epsilon)
