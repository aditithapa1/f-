// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from Aditi Thapa"
let rec factorial number secondparameter =
    if number = 0 then
        secondparameter
    else
        factorial (number - 1) (secondparameter * number)

let result = factorial 4 1
printfn "Factorial of 4 is: %d" result
