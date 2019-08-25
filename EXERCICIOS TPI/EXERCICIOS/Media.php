<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <h1> PROJETO MÉDIA </h1> <br>
        <form method="POST">
            1 nota:<BR><input type="text" name="n1"><br>
            2 nota:<BR><input type="text" name="n2"><br>
			3 nota:<BR><input type="text" name="n3"><br>
			<input type="submit" value="calcular" name="calcular">
	    </form> 
        <?php
            $n1 = $_POST['n1'];
            $n2 = $_POST['n2'];
			$n3 = $_POST['n3'];
			if(isset($_POST['calcular'])){
				$media = (($n1*2)+($n2*3)+($n3*5))/10;
				echo "Média: $media";
			}
			?>
        </form>
    </body>
</html>