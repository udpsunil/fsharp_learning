type Customer =
    { Id: string
      IsEligible: bool
      IsRegistered: bool }

let calculateTotal customer spend =
    let discount =
        if customer.IsEligible && spend >= 100.0M then
            spend * 0.1M
        else
            0.0M

    spend - discount

let john =
    { Id = "john"
      IsEligible = true
      IsRegistered = true }

let mary =
    { Id = "mary"
      IsEligible = true
      IsRegistered = true }

let richard =
    { Id = "richard"
      IsEligible = false
      IsRegistered = true }

let sarah =
    { Id = "sarah"
      IsEligible = false
      IsRegistered = false }

let assertJohn = calculateTotal john 100.0M = 90.0M
let assertMary = calculateTotal mary 99.0M = 99.0M
let assertRichard = calculateTotal richard 100.0M = 100.0M
let assertSarah = calculateTotal sarah 100.0M = 100.0M

assert (assertJohn && assertMary && assertRichard && assertSarah)
printfn "All tests passed: %b" (assertJohn && assertMary && assertRichard && assertSarah)
