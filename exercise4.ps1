function Divide(){
           
           try{
               [int]$result = $num4 / $num5
               Write-host 'AAAANDDDD THE RESULTS IS:' $result
            }
      
            catch [DivideByZeroException]{
          
                Write-Host " You can't divide by zero!!"
                continue
            }
            catch{
                    Write-Host "Error has occured"
                    Write-Host $_.ErrorID
                    Write-Host $_.Exception.Message
                    break
             }
 
}  
                [int]$num4 = Read-host 'Enter first number'
                [int]$num5 = Read-host 'Enter second number'
                Divide($num4,$num5)
                
               