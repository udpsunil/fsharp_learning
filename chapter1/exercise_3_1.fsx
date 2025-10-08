let someFunction first second third =
    let inProgress = first + second
    let answer = inProgress * third
    $"The answer is {answer}"
    
printfn $"{someFunction 10 20 30}"