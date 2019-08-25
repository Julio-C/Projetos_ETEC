<html>
    <head>
        <meta charset="UTF-8">
        <title>calculadora</title>
    </head>
    <body>
        <h1>troca de valores</h1> <BR>
       
        <form method="post">
             valor A:<input type="text" name="txtvalor1"><br>
             valor B:<input type="text" name="txtvalor2"><br>
            <input type="submit" value="inversao" name="btnMais">
                    
         </form>         
           <?php
            $v1 = $_POST['txtvalor1'];
            $v2 = $_POST['txtvalor2'];
           
            $v1=$v1- $v2;
           $v2= $v2+$v1;
           $v1=$v2-$v1;
           echo "o valor de 'a' é: $v1 <br>
                 o valo de 'b' é: $v2 ";
           
          
           ?>
    
 
                
             
           
    
    </body>
</html>
