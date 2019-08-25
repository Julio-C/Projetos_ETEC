<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <h1> PROJETO Impar/Par </h1> <br>
        <form method="POST">
            Valor :<BR><input type="text" name="valor"><br>
			<input type="submit" value="verificar" name="verificar">
	    </form> 
        <?php
            $n1 = $_POST['valor'];
			if(isset($_POST['verificar'])){
				$n1 = $n1%2;
				if($n1==0){
					echo "PAR";
				}else{
					echo "IMPAR";
				}
				
			}
			?>
        </form>
    </body>
</html>