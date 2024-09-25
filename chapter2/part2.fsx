open System

let now () = DateTime.UtcNow

let log msg =
    printfn "[%s] %s" (now().ToString("HH:mm:ss")) msg
    ()

now