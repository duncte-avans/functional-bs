type TrippleIndex =
    | First
    | Second
    | Third

type Square =
    | Empty
    | Circle
    | Cross

type Row = Square * Square * Square
type Board = Row * Row * Row

let symbolOfSquare (s: Square) : string =
    match s with
    | Empty -> " "
    | Circle -> "0"
    | Cross -> "X"

let squareOfRow (index: TrippleIndex) (row: Row) : Square =
    match index, row with
    | First, (appelflap, _, _) -> appelflap
    | Second, (_, pannenkoek, _) -> pannenkoek
    | Third, (_, _, duikboot) -> duikboot

let rowOfBoard (index: TrippleIndex) (board: Board) : Row =
    match index, board with
    | First, (r, _, _) -> r
    | Second, (_, r, _) -> r
    | Third, (_, _, r) -> r

let row1: Row = Empty, Empty, Empty
let row2: Row = Empty, Cross, Empty
let row3: Row = Empty, Empty, Empty

let board: Board = row1, row2, row3

let row = rowOfBoard Second board
let square = squareOfRow Second row

let symbol = symbolOfSquare square

// For more information see https://aka.ms/fsharp-console-apps
printfn $"{symbol}"
