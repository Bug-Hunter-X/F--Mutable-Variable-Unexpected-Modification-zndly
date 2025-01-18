let mutable x = 10

let addOne x = 
  x <- x + 1
  x

let result = addOne x
printfn "%d" result
printfn "%d" x