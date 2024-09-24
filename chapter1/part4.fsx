type CustomerType =
    | Registered of IsEligible: bool
    | Guest

type Customer = { Id: string; Type: CustomerType }

// Unregistered Customer -> basically a guest
let sarah = { Id = "Sarah"; Type = Guest }

// Registered customers
let john =
    { Id = "John"
      Type = Registered(IsEligible = true) }

let mary =
    { Id = "Mary"
      Type = Registered(IsEligible = true) }

let richard =
    { Id = "Richard"
      Type = Registered(IsEligible = false) }


let calculateTotal customer spend =
    let discount =
        match customer.Type with
        | Registered(IsEligible = isEligible) when isEligible && spend >= 100.0M -> spend * 0.1M
        | _ -> 0.0M

    spend - discount

let assertJohn = calculateTotal john 100.0M = 90.0M
let assertMary = calculateTotal mary 99.0M = 99.0M
let assertRichard = calculateTotal richard 100.0M = 100.0M
let assertSarah = calculateTotal sarah 100.0M = 100.0M

assert (assertJohn && assertMary && assertRichard && assertSarah)
printfn "All tests passed: %b" (assertJohn && assertMary && assertRichard && assertSarah)
