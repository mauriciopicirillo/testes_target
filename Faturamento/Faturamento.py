# 3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
# • O menor valor de faturamento ocorrido em um dia do mês;
# • O maior valor de faturamento ocorrido em um dia do mês;
# • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

# IMPORTANTE:
# a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
# b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

import json
import locale

locale.setlocale(locale.LC_ALL, 'pt_BR.UTF-8')

try:
    # Abre o arquivo para leitura
    dados = open("dados.json", "r")
    # Faz a leitura no formato JSON
    faturamentos = json.load(dados)

except FileNotFoundError:
    print("Arquivo não encontrado.")
except PermissionError:
    print("Sem permissão para abrir o arquivo.")
except IOError:
    print("Erro de E/S.")
except json.decoder.JSONDecodeError:
    print("O arquivo não está no formato JSON.")

else:
    # Fecha o arquivo
    dados.close()

    valores = []
    maior = 0
    menor = 0
    quantidade = 21
    soma = 0
    contador_dias = 0

    # Feito um laço para percorrer o arquivos dados.json e fazer a verificação do maior e do menor valor.
    for faturamento in faturamentos:
        valores = faturamento["valor"]
        if faturamento == 0:
            maior = menor = valores
        else:
            if valores > maior:
                maior = valores
            if valores < menor or valores != 0:
                menor = int(valores)
    # Feito um laço para determinar a quantidade de dias que teve faturamento maior que a media.
    for faturamento in faturamentos:
        valores = faturamento["valor"]
        soma = soma + valores
        media = soma / quantidade
        if media < valores:
            contador_dias = contador_dias + 1





print('=-' * 40)
print(f'O menor valor de faturamento ocorrido em um dia do mês foi de R$ {menor:.2f}')
print('=-' * 40)
print(f'O maior valor de faturamento ocorrido em um dia do mês foi de R$ {maior:.2f}')
print('=-' * 40)
print(f'O valor de faturamento em {contador_dias} dias, foi superior à média mensal')
print('=-' * 40)


