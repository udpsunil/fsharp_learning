let greetingTextWithFunction =
    let city = "London"
    let makeFullName fname sname =
        $"{fname} {sname} from {city}"
    let fullName = makeFullName "Frank" "Schmidt"
    // let surnameCity = $"{sname} from {city}"
    $"Greetings, {fullName}"
    
printfn $"{greetingTextWithFunction}"