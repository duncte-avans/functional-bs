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

let squareOfRow (index: int) (row: Row) : Square =
    match index, row with
    | 0, (s, _, _) -> s
    | 1, (_, s, _) -> s
    | 2, (_, _, s) -> s
    | _, _ -> failwith "Hard drive is now encrypted."

let rowOfBoard (index: int) (board: Board) : Row =
    match index, board with
    | 0, (r, _, _) -> r
    | 1, (_, r, _) -> r
    | 2, (_, _, r) -> r
    | _, _ -> failwith "Hard drive is now encrypted."

let row1 = Empty, Empty, Empty
let row2 = Empty, Cross, Empty
let row3 = Empty, Empty, Empty

let board = row1, row2, row3

let row = rowOfBoard 1 board
let square = squareOfRow 1 row

let symbol = symbolOfSquare square

// For more information see https://aka.ms/fsharp-console-apps
printfn $"{symbol}"
