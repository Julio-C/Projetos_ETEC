<?php

include ("../Banco/conexao.php");
include ("../Banco.dao/banco-cliente.php");

$nome = ($_POST['txtnome']);
$tel = ($_POST['txttel']);
$end = ($_POST['txtend']);
$email = ($_POST['txtemail']);
$idade = ($_POST['txtidade']);
$sal = ($_POST['txtsal']);

if(inserir($conexao,$nome,$tel,$end,$email,$idade,$sal)){
    echo "Cliente inserido com sucesso";
}
 else     
 {
     $msg=  mysqli_errno($conexao);
     echo $msg;
 }
        