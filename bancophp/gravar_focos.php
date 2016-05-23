<?php
  $nome_agente =$_POST['nome_agente'];
  $cod_agente =$_POST['cod_agente'];
  $equipe =$_POST['equipe'];
  $nome_morador =$_POST['nome_morador'];
  $estado =$_POST['estado'];
  $cidade =$_POST['cidade'];
  $rua =$_POST['rua'];
  $num_casa =$_POST['num_casa'];
  $complemento =$_POST['complemento'];
  $data_visita =$_POST['data_visita'];
  $horario_visita =$_POST['horario_visita'];          
  $local_Visita =$_POST['local_Visita'];
  $quantidade_focosAgua =$_POST['quantidade_focosAgua'];
  $quantidade_criadouros =$_POST['quantidade_criadouros'];
  $local_tem_entulho =$_POST['local_tem_entulho'];
  $tipofocos1 =$_POST['tipofocos1'];
  $num_focos1 =$_POST['num_focos1'];
  $tipofocos2 =$_POST['tipofocos2'];
  $num_focos2 =$_POST['num_focos2'];
  $tipofocos3 =$_POST['tipofocos3'];
  $num_focos3 =$_POST['num_focos3'];
  $situacao_imovel =$_POST['situacao_imovel'];
  $atividades =$_POST['atividades'];
  $endereco =$_POST['endereco'];
  $gps_local =$_POST['gps_local'];
  $gps_local_long =$_POST['gps_local_long'];           
  

  $conexao = mysql_connect('localhost','root','');
  
  mysql_select_db('bancodengue',$conexao);
  
  $sql = "insert into registrodefocos (nome_agente, cod_agente, equipe, nome_morador, estado, cidade, rua, num_casa, complemento, data_visita, horario_visita, local_Visita, quantidade_focosAgua, quantidade_criadouros, local_tem_entulho, tipofocos1, num_focos1, tipofocos2, num_focos2, tipofocos3, num_focos3, situacao_imovel, atividades, endereco, gps_local, gps_local_long) 
  values ('$nome_agente','$cod_agente','$equipe','$nome_morador','$estado','$cidade','$rua','$num_casa','$complemento','$data_visita','$horario_visita','$local_Visita','$quantidade_focosAgua','$quantidade_criadouros','$local_tem_entulho','$tipofocos1','$num_focos1','$tipofocos2','$num_focos2','$tipofocos3','$num_focos3','$situacao_imovel','$atividades','$endereco','$gps_local','$gps_local_long')";
  
  $resultado = mysql_query($sql) or die ("Erro: " . mysql_error());
  
  if($resultado)
		  echo "ok";
   else
          echo "0";
?>
