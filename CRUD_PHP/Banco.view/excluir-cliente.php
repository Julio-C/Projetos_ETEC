<?php
include ("../Banco/conexao.php");
include ("../Banco.dao/banco-cliente.php");

$id=$_GET['cod_cliente'];
if(excluir($conexao, $id)){
    //Comando para Atualizar a Pagina
    header("Location:lista-clientes.php");
    // Finalizar o processo.
    die();
}
?>

