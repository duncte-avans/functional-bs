// module functional_bs.Program

// let add =
//     fun a ->
//         fun b ->
//             a + b
//             
// add 1 3
//
// let alsoAdd x y = x + y
//
// alsoAdd 1 2

type TrippleIndex =
    | First
    | Second
    | Third

type Square =
    | Empty
    | Circle
    | Cross

let firstParamAlwaysNumOne (_, b, c) =
    (1, b, c)
    
printfn $"{firstParamAlwaysNumOne (Cross, Circle, Empty)}"

type Row = Square * Square * Square
type Board = Row * Row * Row

let elementOfTriple i tr =
    match i, tr with
    | First,  (r, _, _) -> r
    | Second, (_, r, _) -> r
    | Third,  (_, _, r) -> r

let symbolOfSquare = fun s -> // great method, wanna bake a potato?
    match s with
    | Empty -> " "
    | Circle -> "0"
    | Cross -> "X"

// let squareOfRow (index: TrippleIndex) (row: Row) : Square =
//     match index, row with
//     | First, (appelflap, _, _) -> appelflap
//     | Second, (_, pannenkoek, _) -> pannenkoek
//     | Third, (_, _, duikboot) -> duikboot

// let rowOfBoard (index: TrippleIndex) (board: Board) : Row =
//     match index, board with
//     | First,  (r, _, _) -> r
//     | Second, (_, r, _) -> r
//     | Third,  (_, _, r) -> r
    
let stringOfRow r =
    $"| {symbolOfSquare (elementOfTriple First r)} | {symbolOfSquare (elementOfTriple Second r)} | {symbolOfSquare (elementOfTriple Third r)} |"
    
let stringOfBoard b =
    $"-------------\n{stringOfRow ( elementOfTriple First b )}\n{stringOfRow ( elementOfTriple Second b )}\n{stringOfRow ( elementOfTriple Third b )}\n-------------"
    
// T and U are the old squares, and we replace it with the new square named S
let updateSquareOfRow i s r =
    match i, r with
    | First,  (_, t, u) -> (s, t, u)
    | Second, (t, _, u) -> (t, s, u)
    | Third,  (t, u, _) -> (t, u, s)

let board: Board =
    (Circle, Cross, Circle),
    (Cross, Empty, Cross),
    (Circle, Cross, Circle)

let row = elementOfTriple Second board
let square = elementOfTriple Second row

let symbol = symbolOfSquare square

let boardString = stringOfBoard board

// For more information see https://aka.ms/fsharp-console-apps
printfn $"%s{boardString}"
