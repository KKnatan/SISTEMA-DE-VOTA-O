
 
 
 
 # DETALHAMENTO DO PROJETO
 Esse projeto consiste em um sistema de votos baseado na criação de candidatos para uma "Eleição". Ultilizando da logica de  *C-R-U-D* para a criação dos candidatos (com nome e idade), sem a necessidade de programas externos
 ou bancos de dados a parte da linguagem, nesse caso, foi usado a função de *LISTAS* da própria linguagem para armazenar as informações.

O programa apresenta um *MENU* de opções para seu funcionamento.
![image](https://github.com/user-attachments/assets/4b720141-27e7-4b92-adbc-6c26775b87ae)
 


# ELEIÇÕES
>>RECOMENDO COMEÇAR PELA FUNÇÃO DE *ADICIONAR* PARA A MELHR COMPREENSÃO DO PROJETO
Após feito o cadastro dos candidatos, o usuário pode partir para as eleições.
![image](https://github.com/user-attachments/assets/a7630657-2684-49b1-b33d-8add44396788)
O nome de cada candidato irá aparecer em ordem númerica, como mostra a imagem acima. Para votar, o usuário deverá digitar o índice de cada candidato, ou seja, caso deseje votar no primeiro candidato digite "1"
caso queria votar no segundo candidato digite "2".....etc. Após votar, irá aparecer uma mensagem de confirmação do voto, para *Encerrar a votação*, digite *0*.


![image](https://github.com/user-attachments/assets/0ee8f3bd-c391-486e-8406-032f3090c60e)

Após digitar >*0*<, o programa irá exibir o quantitativo de votos em cada candidato e o total dos votos, como mostra a figuria acima.
        (obs: *nessa parte, após ler todos os dados, o programa espera que o usuário aperte alguma tecla para continuar*)





![image](https://github.com/user-attachments/assets/293ca028-f606-4f77-ab7a-e7d8b8f8a1b3)



Ao final do programa, será exibido os resultados. Logo que apertar qualquer tecla, o programa irá voltar para o *MENU* e todos os candidatos registrados anteriormente serão apagados, sendo necessario cadastrar novamente para realizar outra eleição.



# ADICIONAR
Para adicionar um candidato, basta digitar *2* no *MENU* que o usuário será legvado para o cadastro do candidato.

![image](https://github.com/user-attachments/assets/7d938500-255a-45a4-a344-64beb570df06)

Para o cadastro, o usuário deverá digitar o nome do candidato e a idade, como mostra acima. Após cadastrar, irá aparecer uma mensagem confirmando o cadastro e perguntando se o usuário deseja ou não adicionar mais candidatos, repetindo o processo até o programa receber um "n" como resposta. Recebendo um "n" como resposta, o programa exige que usuário volte para o menu apertando qualquer tecla.


# ATUALIZAR 

Para atualizar um candidato, basta digitar *3* no *MENU* que o usuário será levado para uma parte separada, mostrando cada candidato registrado com *Nome* e a *idade*.

![image](https://github.com/user-attachments/assets/de147510-7e69-4170-9267-cd896314a87b)



para fazer a atualização dos dados, basta digitar o nome do candidato que deseje atualizar. Quando digitar o nome do candidato, o programa mostrará separado apenas o candidato escolhido, pedindo um novo nome e uma idade nova (caso queira atualizar apenas um campo, basta repetir os dados de "nome" ou "idade".

 ![image](https://github.com/user-attachments/assets/8cc54f5f-20ba-44da-b37f-06caa4b0e371)


# Remover

Para remover ou deletar um candidato, basta digitar 4 no *MENU* que o usuário será levado para uma parte separada com os candidatos registrados.

 ![image](https://github.com/user-attachments/assets/0ed2e474-65d2-44f3-b38c-d5a682c20101)


Para realizar a remocão de algum candidato, basta digitar o nome do candidato que deseja remover. Após digitar o nome corretamente, o programa mostrará uma mensagem *VERDE* confirmando a remoção .
![image](https://github.com/user-attachments/assets/e4e3987c-0290-45cc-8cd3-c3588edf116f)


# VISUALIZAR

Para visualizar os candidatos registrados, bastar digita *5* no *MENU*, que o usuário será levado para uma parte separada mostrando os candidatos registrados

  ![image](https://github.com/user-attachments/assets/f03cc4b6-ee9e-4b64-86dc-45d99d78ee7c)




# Sair
Caso o usuário deseja sair do programa, basta digitar *6*, que o programa irá ser encerrado....

# CONDIÇÕES
>>Eleições: para fazer uma eleição, deverá ter no minímo 2 candidatos registrados, menos que isso ocorrerá um erro.

>>Adicionar: a idade do candidato deverá ser maior ou igual a 35, caso seja menor, o programa irá mostrar um erro e a idade poderá ser repetida ate ser igual ou maior que 35.

>>Atualizar: Caso o usuário digite o nome de um candidato que não está registrado, o programa irá mostrar um erro e o usuário deverá voltar para o menu.

>>Remover: Caso o usuário digite o nome de um candidato que não está registrado, o programa irá mostrar um erro e o usuário deverá voltar para o menu.

>>Visualizar: após entrar em *visualizar*, o usuário apenas conseguirá voltar ao menu caso aperte alguma tecla.

