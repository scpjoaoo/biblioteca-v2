# Gerenciador de Biblioteca
- A aplicação a seguir foi desenvolvida da linguagem de programação C#, como alternativa à utilização de ORM, a abordagem ADO.NET foi escolhida como opção para trabalhar a comunicação com o servidor SQL.
- O tempo gasto na codificação foi algo em torno de 72 Horas.
- Equipe: João Pedro Corrêa Santos.
  
## O programa...
- O objetivo da aplicação é servir como um Gerenciador multissetorial, sendo assim ela oferece paineis de cadastro, edição, remoção e deleção (CRUD) para as seguintes areas:
  
    1- CRUD Livros:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/d3c73ac0-5618-4c0f-94ca-993bb3ec4483)

    2- CRUD Escritores:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/61c64baf-fbf0-4cad-b31e-5cd455fa0429)

    3- CRUD Funcionários:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/c55d28ff-9e17-4f75-ba25-c94825a23cc6)

    4- CRUD Clientes:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/01dc5538-fb54-4357-b92e-1fd5ff050299)

    5- CRUD Aluguéis:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/9eaa8328-7665-4876-996b-bcc658632fda)

  ## Visualização:
  - A aplicação também oferece um painel que carrega as informações do banco de dados e disponibiliza apenas para consulta (visualização), nesse passo não é possível editar ou remover informações, apenas visualizar:
    ### Painel Visualizar:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/5c3dc387-5e02-4916-93fa-72111075fe53)

  ## Edição(Update) e Remoção:
  - Seguindo um raciocínio semelhante ao Painel Visualizar, no campo de edição chamado de editor, também há a funcionalidade de carregar os dados da tabela selecionada para dentro do DataGridView. No entando, o diferencial está na possibilidade de selecionar o ID do registro que deseja-se alterar ou deletar. Isso é possível pois, para todas as tabelas do banco, a key primária é o ID, e portanto, torna-se o discriminante perfeito para essa utilização. Confira na demonstração com o cliente de ID = 3.
    ### Editor:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/c90c4d7e-859f-486b-a3e2-d731b681ef11)

    ### Após clicar em Editar com um ID válido:
    ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/22b2df71-6315-4829-9cee-e1f9fe2e5f9d)
    - Nesse momento qualquer alteração feita na tela de edição poderia ser efetivada caso o botão "Atualizar" fosse clicado. Sendo assim se o botão "Deletar" fosse pressionado esse registro seria efetivamente deletado do Banco de dados. Logicamente após uma confirmação do tipo "Você tem certeza que deseja deletar esse registro?" ou "Você tem certeza que deseja atualizar esse registro?". O botão "Cancelar" apenas fecharia o formmulário de edição.
   
  # O banco de dados:
  ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/2434bfd4-eb09-4df0-935a-627cd7b766c2)
  
  ## Cadastro realizado no exemplo:
  ![image](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/3677f023-31ae-498b-bb62-2f6f0f9f3a9b)

# Diagrama de Classes
![Class Diagram0](https://github.com/scpjoaoo/biblioteca-v2/assets/108030089/330fa09f-29bf-4bc1-89e7-2d978f90e810)

# Considerações:
-Esse trabalho foi muito gratificante de fazer, apesar de a propósta do trabalho sugerir que o mesmo seja feito em equipe sinto que me virei muito bem fazendo sozinho, certamente algumas coisas foram bem complicadas e o tempo muito apertado para uma pessoa só. No entanto, o aprendizado foi garantido.

  
    



