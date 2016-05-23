<?php
   $usuario =$_POST['usuario'];
   $senha =$_POST['senha'];
    
    $conexao = mysql_connect('localhost','root','');
   
   mysql_select_db('bancoDengue',$conexao);
      
   $sql="select * from login where usuario like '$usuario' and senha like '$senha'";
  
   $resultado = mysql_query($sql) or die ("Erro: " . mysql_error());

  while($linha = mysql_fetch_object($resultado)) {
   echo $linha->usuario."#";
   echo $linha->senha."^";
      }

echo "^";

?>