open System
open System.IO



[<EntryPoint>]
let main argv =
    let arr = [|0..500000|]
   
        
        
    //1.a 
    let stopWatch1a = System.Diagnostics.Stopwatch.StartNew()
    for i in arr do
        let k = 50
        arr.[i] <- k

    stopWatch1a.Stop()
    
    

    //1.b 
    
    let stopWatch1b = System.Diagnostics.Stopwatch.StartNew()
    for i = 500000 downto 0 do
        let n = 10
        arr.[i] <- n

    stopWatch1b.Stop()
    
     
       
    //1.c
    //1.c.1)
    
    let stopWatch1c1 = System.Diagnostics.Stopwatch.StartNew()
    for i in arr do
        printfn "%d" i
    stopWatch1c1.Stop()
   
    
    
    
    //1.c.2
    let stopWatch1c2 = System.Diagnostics.Stopwatch.StartNew()
    for i in arr do
        let value = arr.[i]
        if i % 10 = 0 then printfn "%d" value
        
    stopWatch1c2.Stop()
    
    
    
    //1.c.3
    let stopWatch1c3 = System.Diagnostics.Stopwatch.StartNew()
    for i in arr do
        let value = arr.[i]
        if i % 100 = 0 then printfn "%d" value
        
    stopWatch1c3.Stop()
    
    
    
    //1.c.4
    let stopWatch1c4 = System.Diagnostics.Stopwatch.StartNew()
    for i in arr do
        let value = arr.[i]
        if i % 1000 = 0 then printfn "%d" value
        
    stopWatch1c4.Stop()
    
    
    

    //2.
    //2.a
    
    let a = Array2D.init 1000 1000 (fun x y -> (x,y))
      
    
    let mutable cell = 0
    let value = 0
    let lenght = a.Length
    
    let stopWatch2a = System.Diagnostics.Stopwatch.StartNew()
    for f = 0 to 999 do
        for c = 0 to 999 do
            let k2 = 25
            a.[f,c] <- k2,k2
            cell <- cell + 1
    stopWatch2a.Stop()      
    
    
    //2.b.1)
    
    let stopWatch2b1 = System.Diagnostics.Stopwatch.StartNew()
    for f = 0 to 999  do
        for c = 0 to 999 do
            Console.WriteLine(a.[f,c])
            cell <- cell + 1


    stopWatch2b1.Stop()
    
    

    //2.b.2)
    
    let stopWatch2b2 = System.Diagnostics.Stopwatch.StartNew()
    for f = 0 to 999  do
        for c = 0 to 999 do
            let value = a.[f,c]
            if f % 10 = 0 then if c % 10 = 0 then Console.WriteLine(value)
            cell <- cell + 1
            
        
    stopWatch2b2.Stop()
   
    


    //2.b.3)
     
    let stopWatch2b3 = System.Diagnostics.Stopwatch.StartNew()
    for f = 1 to 999 do
        for c = 1 to 999 do
            let value = a.[f,c]
            if f % 100 = 0 then if c % 100 = 0 then Console.WriteLine(value)
            cell <- cell + 1
            
    stopWatch2b3.Stop()
    
    
    
    //2.b.4)
    let stopWatch2b4 = System.Diagnostics.Stopwatch.StartNew()
    for f = 1 to 999 do
        for c = 1 to 999 do
            let value = a.[f,c]
            if f % 1000 = 0 then if c % 1000 = 0 then Console.WriteLine(value)
            cell <- cell + 1
    stopWatch2b4.Stop()
    

     //2.c.
     
    let stopWatch2c = System.Diagnostics.Stopwatch.StartNew()
    for c = 0 to 999 do
         for f = 0 to 999 do
             let k3 = 90
             a.[c,f] <- k3,k3
             cell <- cell + 1
    
    stopWatch2c.Stop()
    
    
       
     //2.d.1

     
    let stopWatch2d1 = System.Diagnostics.Stopwatch.StartNew()
    for c = 0 to 999  do
         for f = 0 to 999 do
             Console.WriteLine(a.[c,f])
             cell <- cell + 1


    stopWatch2d1.Stop()
         
    
    
    //2.d.2
    let stopWatch2d2 = System.Diagnostics.Stopwatch.StartNew()
    for c = 0 to 999  do
        for f = 0 to 999 do
            let value = a.[c,f]
            if c % 10 = 0 then if f % 10 = 0 then Console.WriteLine(value)
            cell <- cell + 1
            
        
    stopWatch2d2.Stop()
    
    

    //2.d.3
    
    let stopWatch2d3 = System.Diagnostics.Stopwatch.StartNew()
    for c = 0 to 999  do
        for f = 0 to 999 do
            let value = a.[c,f]
            if c % 100 = 0 then if f % 10 = 0 then Console.WriteLine(value)
            cell <- cell + 1
            
        
    stopWatch2d3.Stop()
    
    


    //2.d.4
    let stopWatch2d4 = System.Diagnostics.Stopwatch.StartNew()
    for c = 0 to 999  do
        for f = 0 to 999 do
            let value = a.[c,f]
            if c % 1000 = 0 then if f % 1000 = 0 then Console.WriteLine(value)
            cell <- cell + 1
            
        
    stopWatch2d4.Stop()

    let s1a = string stopWatch1a.Elapsed.TotalMilliseconds
    let s1b = string stopWatch1b.Elapsed.TotalMilliseconds
    let s1c1 = string stopWatch1c1.Elapsed.TotalMilliseconds
    let s1c2 = string stopWatch1c2.Elapsed.TotalMilliseconds
    let s1c3 = string stopWatch1c3.Elapsed.TotalMilliseconds
    let s1c4 = string stopWatch1c4.Elapsed.TotalMilliseconds
    let s2a = string stopWatch2a.Elapsed.TotalMilliseconds
    let s2b1 = string stopWatch2b1.Elapsed.TotalMilliseconds
    let s2b2 = string stopWatch2b2.Elapsed.TotalMilliseconds
    let s2b3 = string stopWatch2b3.Elapsed.TotalMilliseconds
    let s2b4 = string stopWatch2b4.Elapsed.TotalMilliseconds
    let s2c = string stopWatch2c.Elapsed.TotalMilliseconds
    let s2d1 = string stopWatch2d1.Elapsed.TotalMilliseconds
    let s2d2 = string stopWatch2d2.Elapsed.TotalMilliseconds
    let s2d3 = string stopWatch2d3.Elapsed.TotalMilliseconds
    let s2d4 = string stopWatch2d4.Elapsed.TotalMilliseconds
    

    
    File.WriteAllText("tiempo.xls",s1a + Environment.NewLine + s1b + Environment.NewLine + s1c1 + Environment.NewLine + s1c2 + Environment.NewLine + s1c3 + Environment.NewLine + s1c4 + Environment.NewLine + s2a + Environment.NewLine + s2b1 + Environment.NewLine + s2b2 + Environment.NewLine + s2b3 + Environment.NewLine+s2b4 + Environment.NewLine + s2c + Environment.NewLine+ s2d1 + Environment.NewLine + s2d2 + Environment.NewLine + s2d3 + Environment.NewLine + s2d4)


    
    0 // return an integer exit code
