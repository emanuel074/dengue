<?php
  $nome_agente =$_POST['nome_agente'];
  $cod_agente =$_POST['cod_agente'];
  $num_equipe =$_POST['num_equipe'];
  $data_visita =$_POST['data_visita'];
  $horario_visita =$_POST['horario_visita'];
  $nome_morador =$_POST['nome_morador'];
  $estado =$_POST['estado'];
  $cidade =$_POST['cidade'];
  $bairro =$_POST['bairro'];
  $rua =$_POST['rua'];
  $complemento =$_POST['complemento'];
  $num_casa =$_POST['num_casa'];
  $atividades =$_POST['atividades'];
  $situacao_imovel =$_POST['situacao_imovel'];
  $motivo_visita =$_POST['motivo_visita'];

  $conexao = mysql_connect('localhost','root','');
  
  mysql_select_db('bancoDengue',$conexao);
  
  $sql = "insert into fichavisita (nome_agente, cod_agente, num_equipe, data_visita, horario_visita, nome_morador, estado, cidade, bairro, rua, complemento, num_casa, atividades, situacao_imovel, motivo_visita) 
  values ('$nome_agente','$cod_agente','$num_equipe','$data_visita','$horario_visita','$nome_morador','$estado','$cidade','$bairro','$rua','$complemento','$num_casa','$atividades','$situacao_imovel','$motivo_visita')";
  
  $resultado = mysql_query($sql) or die ("Erro: " . mysql_error());
  
  if($resultado)
		  echo "ok";
   else
          echo "0";
?>
