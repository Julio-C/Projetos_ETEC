<!DOCTYPE html>
<?php
include ("../Banco/conexao.php");
include ("../Banco.dao/banco-cliente.php");
$cod_cliente=$_GET['cod_cliente'];
$cliente=  busca($conexao, $cod_cliente);
?>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Alterar</title>
    </head>
    <body>
        <h1>Alterar Cliente</h1>

        <form method="post" action="verificaAlteracao.php" >
            <pre>
              Cod_cliente:<input type="text" name="txtcod" value="<?php echo $cliente['cod_cliente']?>"><br>
              Nome:    <input type="text" name="txtnome" value="<?php echo $cliente['nome']?>"><br>
              Telefone:<input type="text" name="txttel" value="<?php echo $cliente['telefone']?>"><br>
              Endereço:<input type="text" name="txtend" value="<?php echo $cliente['endereco']?>"><br>
              Email:   <input type="text" name="txtemail" value="<?php echo $cliente['email']?>"><br>
              Idade:   <input type="text" name="txtidade" value="<?php echo $cliente['idade']?>"><br>
              Salário: <input type="text" name="txtsal" value="<?php echo $cliente['salario']?>"><br>
            <input type="submit" value="Alterar" name="btn"><br>
            </pre>
        </form>
    </body>
</html>