﻿<?php

  $conexao = mysql_connect('localhost','root','');
  
  mysql_select_db('bancodengue',$conexao);
  
  $sql="select * from cadastroagente";
  
  $resultado = mysql_query($sql) or die ("Erro: " . mysql_error());
  echo "#";
  // Obtém o resultado de uma linha como um objeto
  while($linha = mysql_fetch_object($resultado))
      echo $linha->nomeProfissional."#";
  echo "^";

?>
