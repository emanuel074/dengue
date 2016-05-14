<?php
  $nomeProfissional =$_POST['nomeProfissional'];

  $conexao = mysql_connect('localhost','root','');
  
  mysql_select_db('bancoDengue',$conexao);
  
  $sql="select * from cadastroagente where nomeProfissional like '$nomeProfissional'";
  
  $resultado = mysql_query($sql) or die ("Erro: " . mysql_error());
  
  // Obtém o resultado de uma linha como um objeto
  
  while($linha = mysql_fetch_object($resultado)) {
          echo $linha->nomeProfissional."#";
	  echo $linha->codigoAgente."#";
	  echo $linha->equipe."#"; 
	  
	  }
  echo "^";

?>
