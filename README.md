# TeamTaskList

📌 Fase 2: Refinamento
Aqui estão algumas perguntas legais para trocar ideia com o Product Owner (PO) e deixar tudo mais claro, alinhar o que esperar e pensar nas próximas melhorias:

Que tal ter notificação quando uma tarefa for atualizada?

Deixar o prazo da tarefa editável, mas só alterar mesmo quando o gestor aprovar.

Avisar o usuário quando uma tarefa estiver quase vencendo.

Mostrar quantos dias faltam pra tarefa vencer ou avisar se já venceu.

Hoje só tem perfil de usuário e gerente — será que rola criar novos cargos com permissões diferentes?

No relatório de histórico, seria massa conseguir fazer comparativo entre o time.

Importar tarefas em lote, pra não ter que cadastrar uma por uma.

E uma tela web pra facilitar o acesso e deixar tudo mais prático.

🚀 Fase 3: Melhorias Futuras e Visão Arquitetural
Algumas ideias pra deixar o projeto mais robusto e pronto pro que vier pela frente:

Além dos testes unitários, mandar ver nos testes de integração pra garantir que tudo conversa direitinho entre as partes.

Colocar Swagger com autenticação JWT, assim fica fácil testar os endpoints que precisam de login.

Deixar a configuração do banco de dados “externa” usando volumes no Docker, pra garantir que os dados não desapareçam.

Preparar o projeto pra rodar tranquilo na nuvem — tipo Azure, AWS ou Google Cloud.

Usar containers versionados e montar um pipeline de CI/CD com GitHub Actions ou Azure DevOps pra automatizar tudo.
