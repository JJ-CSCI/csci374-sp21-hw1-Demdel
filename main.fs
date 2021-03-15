module Assignment

// Problem 1
let rec tribn n =
    // write your code here
    if n <= 0 then 0 
    else if n =  1 then 1
    else if n =  2 then 1
    else tribn (n-1) + tribn (n-2) + tribn (n-3)
    
// Problem 2
let tribn2 n =
    // write your code here 
    if n <= 0 then 0 
    else 
      let rec Tfour lst = 
        let h = List.head lst
        1 + h ::(h + 2::( h + 3:: (h + 4 ::[])))::lst
    
      let rec tribn n =
        if n <= 0 then 0 
        else if n =  1 then 1
        else if n =  2 then 1
        else tribn (n-1) + tribn (n-2) + tribn (n-3)

  //0 default

// Problem 3
let rec last lst =
    // write your code here
    if List.isEmpty lst then 0
    else
     let h = List.head lst
     let t = List.tail lst 
     if h <> last t then h :: t
     else last h
  
  
  //0 default
    

// Problem 4
let fourth (lst:int list) =
    // write your code here
    if lst < 4 then 0
    else 
        let 
  
  
  
0 
// Problem 5
let everyfourth (lst:int list) =
    // write your code here
     
      if List.isEmpty then []
      else 

      let fourth (lst:int list) =
      
    else  
      let h = List.head 
      let t = List.tail
      if h 

    
    
    
// Problem 6
let rec take n (lst:int list) =
    // write your code here
    
    [] 

// Problem 7
let rec drop n (lst:int list) =
    // write your code here
    
    [] 
