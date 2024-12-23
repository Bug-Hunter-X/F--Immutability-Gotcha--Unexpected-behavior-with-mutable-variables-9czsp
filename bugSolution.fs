let add x y = x + y

let result = add 10 20
printfn "%d" result //This will print 30

let result2 = add 100 200
printfn "%d" result2 //This will print 300. Using a function call ensures the calculation is done when needed.