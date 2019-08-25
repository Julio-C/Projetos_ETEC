<?php

function inserir($conexao,$nome,$tel,$end,$email,$idade,$sal) {
    $sql = "insert into cliente"
  . "(nome,telefone,endereco,email,idade,salario)"
  . " values ('$nome','$tel','$end','$email',$idade,$sal)";
    return mysqli_query($conexao,$sql);
            
}

