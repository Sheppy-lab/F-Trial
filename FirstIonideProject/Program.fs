// Learn more about F# at http://fsharp.org

open System

module PigLatin = 
    let toPigLatin (word: string) =
        let isVowel (c: char) =
            match c with
            | 'a' | 'e' | 'i' |'o' |'u'
            | 'A' | 'E' | 'I' | 'O' | 'U' -> true
            |_ -> false
        
        if isVowel word.[0] then
            word + "yay"
        else
            word.[1..] + string(word.[0]) + "ay"

[<EntryPoint>]
let main argv =
    let sqr x = x*x
    let plus1 x = x+1
    let sqrPlus = fun x -> plus1 (sqr x)
    let x2er f = fun x -> f (f x)
    printfn "26 is %d" (x2er sqrPlus 2)
    printfn "16 is %d" (x2er sqr 2)
    printfn "4 is %d" ((fun n -> x2er plus1 n) 2)
    for name in argv do
        let newName = PigLatin.toPigLatin name
        printfn "%s in Pig Latin is: %s" name newName 

    0 // return an integer exit code