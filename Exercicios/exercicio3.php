<html>
    <head>
        <meta charset="UTF-8">
        <title>calculadora</title>
    </head>
    <body>
        <h1>EXERCICIO 1</h1> <BR>
        <form method="post">
            1 valor:<input type="text" name="txtvalor1"><br>
            2 valor:<input type="text" name="txtvalor2"><br>
            <input type="submit" value="/" name="btndividir">
        </form>
                
         <?php
         $v1 = $_POST['txtvalor1'];
         $v2 = $_POST['txtvalor2'];
         $total = $v1+$v2;
         
         echo $total;
        
         ?>
         <br><a href="index.php">voltar</a>
       
           
    
    </body>
</html>

