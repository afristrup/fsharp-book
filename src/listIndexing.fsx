let lst = [3..9]
printfn "lst = %A, lst[1] = %A" lst lst[1]
printfn "First 2 elments of lst = %A" lst[..1]
printfn "Last 3 elements of lst = %A" lst[4..]
printfn "Element number 3 to 5 = %A" lst[2..4]
printfn "All elements = %A" lst[*]
