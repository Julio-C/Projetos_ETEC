<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <h1> PROJETO Operações Matemáticas </h1> <br>
        <form method="post">
            1 valor:<BR><input type="text" name="v1"><br>
            2 valor:<BR><input type="text" name="v2"><br>
            <input type="submit" value="+" name="soma">
            <input type="submit" value="-" name="subt">
            <input type="submit" value="/" name="div">
            <input type="submit" value="*" name="mult">
            <input type="submit" value="POT." name="poten">
        </form> 
        <?php
            $v1 = $_POST['v1'];
            $v2 = $_POST['v2'];
			if(isset($_POST['soma'])){
				$total = $v1 + $v2;
			}elseif(isset($_POST['subt'])){
				$total = $v1 - $v2;}
			elseif(isset($_POST['div'])){
				$total = $v1 / $v2;}
            elseif(isset($_POST['mult'])){
				$total = $v1 * $v2;}
			elseif(isset($_POST['poten'])) {
				$total = pow($v1,$v2);}
            ?>
        Total: <?php echo $total; ?> <br>
        </form>
    </body>
</html>
