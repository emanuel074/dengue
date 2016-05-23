<?php
  $perguntas =$_POST['perguntas'];
  $respostas =$_POST['respostas'];
  $resposta_certa =$_POST['resposta_certa'];
  

  $conexao = mysql_connect('localhost','root','');
  
  mysql_select_db('bancodengue',$conexao);
  
  $sql = "insert into questionario (perguntas, respostas, resposta_certa) 
  values ('$perguntas','$respostas','$resposta_certa')";
  
  $resultado = mysql_query($sql) or die ("Erro: " . mysql_error());
  
  if($resultado)
		  echo "ok";
   else
          echo "0";
?>
