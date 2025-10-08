let doACalculation theNumber =
    let twenty = 20
    let answer = twenty + theNumber
    answer

printfn $"{doACalculation 20}"

let greetingText = 
    let fullName = 
        let fname = "Sunil"
        let lname = "Udupi"
        $"{fname} {lname}"
    $"Greetings, {fullName}"


let greetingTextWithFunction person = 
    let makeFullName fname lname = 
        $"{fname} {lname}"
    let fullName = makeFullName "Sunil" "Udupi"
    $"Greetings, {fullName} from {person}."