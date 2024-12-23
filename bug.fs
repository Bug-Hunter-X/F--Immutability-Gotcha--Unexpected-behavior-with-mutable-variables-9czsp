let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printfn "%d" result //This will print 30

x <- 100
y <- 200

printfn "%d" result //This will still print 30. The result variable doesn't update when x and y are changed.