// basic variable definition
// by default variables are immutable in f#
let pi = 3.14159

// when mutability is desired, f# provides a way to achieve it.
let mutable counter = 0
counter <- counter + 1


// variable binding and scope
let outerVariable = "I am outside"

let someFunction() = 
    let innerVariable = "I am inside"
    printfn "%s" innerVariable
    printfn "%s" outerVariable

someFunction()
// printfn "%s" innerVariable
printfn "%s" outerVariable

// shadowing and variable binding 
let x = 5

let someOtherFunction() = 
    let x = 10
    printfn "Inner x: %d" x 

printfn "Outer x: %d" x 
someOtherFunction()

// type inference and type annotations 
let isEven: bool = true

// immutable data structures
let numbers = [1; 2; 3; 4]
let updatedNumbers = numbers @ [5; 6]
printfn "%A" updatedNumbers

let originalList = [1; 2; 3]
let modifiedList = 0 :: originalList
printfn "%A" modifiedList

// nested scoping 
let outerFunction x=  
    let outerValue = x + 1

    let innerFunction y =
        let innerValue = y + outerValue
        innerValue

    innerFunction 10

printfn "%d" (outerFunction 10)

// variable shadowing

let exampleFunction x=
    let x = x * 2
    let y = x + 10
    (x, y)

printfn "%A" (exampleFunction 10)


// type annotations
let add (x: int) (y:int): int = x + y