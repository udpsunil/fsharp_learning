let addTenThenDouble (theNumber : int) : int = {
    let addedTen : int = theNumber + 10;
    let answer : int = addedTen * 2;
    printfn $"({theNumber} + 10) * 2 is {answer}";
    let website: System.Uri = new System.Uri ("https://fsharp.org");
    return answer;
}