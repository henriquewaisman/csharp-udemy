## Exercício
Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo.

<pre>
  Funcionario
  - Nome: String 
  - SalarioBruto: double
  - Imposto: double
  + SalarioLiquido(): double
  + AumentarSalario(porcentagem: double): void
</pre>

#### Exemplo
<pre>
  Nome: Joao Silva
  Salário bruto: 6000.00
  Imposto: 1000.00
  Funcionário: Joao Silva, $ 5000.00
  Digite a porcentagem para aumentar o salário: 10.0
  Dados atualizados: Joao Silva, $ 5600.00
</pre>
