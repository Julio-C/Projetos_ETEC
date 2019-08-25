<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <h1> PROJETO  </h1> <br><BR>
        <form action="" name="form" method="POST">
			Preço de fabrica:<BR><input type="text" name="val1"><br><BR>
			<input type="submit" value="Calcular" name="calculo">
        </form>
		<?php
		if(isset($_POST['calculo'])){
			$precoFabrica = $_POST['val1'];
			$total = (($precoFabrica/100)*28)+(($precoFabrica/100)*45)+$precoFabrica;
			echo "Resultado: $total";
		}
		?>
    </body>
</html>