<?php

include ("../Banco/conexao.php");
include ("../Banco.dao/banco-cliente.php");

$cod_cliente= ($_POST['txtcod']);
$nome = ($_POST['txtnome']);
$tel = ($_POST['txttel']);
$end = ($_POST['txtend']);
$email = ($_POST['txtemail']);
$idade = ($_POST['txtidade']);
$sal = ($_POST['txtsal']);

if(alterar($conexao,$nome,$tel,$end,$email,$idade,$sal,$cod_cliente)){
    echo "Cliente alterado com sucesso";
}
 else     
 {
     $msg=  mysqli_errno($conexao);
     echo "$msg";
 }
?>