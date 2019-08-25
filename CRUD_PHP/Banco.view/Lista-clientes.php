<!DOCTYPE html>
<?php
include ("../Banco/conexao.php");
include ("../Banco.dao/banco-cliente.php");
?>

<html>
    <head>
        <meta charset="UTF-8">
        <title>Lista de Clientes</title>
    </head>
    <body>
        <h1>Clientes Cadastrados</h1>
        <table border="1">
            <tr>
                <td>Id</td>
                <td>Nome</td>
                <td>Telefone</td>
                <td>Endereço</td>
                <td>Email</td>
                <td>Idade</td>
                <td>Salário</td>
                <td>Excluir</td>
                <td>Alterar</td>
            </tr>
            <?php
            $clientes = listaClientes($conexao);
            foreach ($clientes as $cliente):
            ?>
            <tr>
                <td><?php echo $cliente['cod_cliente']?></td>
                <td><?php echo $cliente['nome']?></td>
                <td><?php echo $cliente['telefone']?></td>
                <td><?php echo $cliente['endereco']?></td>
                <td><?php echo $cliente['email']?></td>
                <td><?php echo $cliente['idade']?></td>
                <td><?php echo $cliente['salario']?></td>
                <td><a href="excluir-cliente.php?cod_cliente=
                    <?php echo $cliente['cod_cliente']?>">Excluir</a>   
                </td>
                <td><a href="alterar-cliente.php?cod_cliente=
                    <?php echo $cliente['cod_cliente']?>">Alterar</a>   
                </td>
            </tr>
        <?php
        endforeach;
        ?>
        </table>
    </body>
</html>
