// Anonymous functions

let add x y = x + y
let sum = add 3 4


let add_annyms = fun x y -> x + y
let sum_annyms = add_annyms 3 4

let apply f x y = f x y

let sum_1 = apply add 3 4
let sum_2 = apply (fun x y -> x + y) 3 4


open System

let rnd () =
    let rand = Random()
    rand.Next(100)

List.init 50 (fun _ -> rnd ())

let calculateTotal customer =
    fun spend -> printfn "Customer %d spent something" customer


type LogLevel =
    | Error
    | Warning
    | Info

let log (level: LogLevel) message = printfn "[%A]: %s" level message
let log1 (level: LogLevel) message = printfn $"[%A{level}]: %s{message}"
let log2 (level: LogLevel) message = printfn $"[{level}]: {message}"

// partially applied function
let logError = log Error
let m1 = log Error "Curried function"
let m2 = logError "Partially applied function"
