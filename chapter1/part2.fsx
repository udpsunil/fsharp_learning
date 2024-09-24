type RegisteredCustomer = { Id: string; IsEligible: bool }

type UnregisteredCustomer = { Id: string }

type Customer =
    | Registered of RegisteredCustomer
    | Guest of UnregisteredCustomer


// Unregistered Customer -> basically a guest
let sarah = Guest { Id = "Sarah" }

// Registered customers
let john = Registered { Id = "John"; IsEligible = true }
let mary = Registered { Id = "Mary"; IsEligible = true }
let richard = Registered { Id = "Richard"; IsEligible = false }


let calculateTotal customer spend =
    let discount =
        match customer with
        | Registered c ->
            if c.IsEligible && spend >= 100.0M then
                spend * 0.1M
            else
                0.0M
        | Guest _ -> 0.0M

    spend - discount

let assertJohn = calculateTotal john 100.0M = 90.0M
let assertMary = calculateTotal mary 99.0M = 99.0M
let assertRichard = calculateTotal richard 100.0M = 100.0M
let assertSarah = calculateTotal sarah 100.0M = 100.0M

assert (assertJohn && assertMary && assertRichard && assertSarah)
printfn "All tests passed: %b" (assertJohn && assertMary && assertRichard && assertSarah)
