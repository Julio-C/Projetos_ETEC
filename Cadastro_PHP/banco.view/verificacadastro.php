<?php

include ("../banco/conexao.php");
include ("../banco.dao/banco-cliente.php");

$nome = ($_POST['txtnome']);
$tel = ($_POST['txttel']);
$end = ($_POST['txtend']);
$email = ($_POST['txtemail']);
$idade = ($_POST['txtidade']);
$sal = ($_POST['txtsal']);

if (inserir($conexao,$nome,$tel,$end,$email,$idade,$sal)) {
    echo "cliente inserido com sucesso !!";
}else {
    $msg = mysqli_errno($conexao);
}
