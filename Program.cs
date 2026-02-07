using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidadorCartao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Validador de Cartão de Crédito (TIVIT/DIO) ===");
            Console.Write("Digite o número do cartão: ");
            string input = Console.ReadLine();
            string cardNumber = Regex.Replace(input ?? "", @"[^\d]", "");

            if (string.IsNullOrEmpty(cardNumber)) {
                Console.WriteLine("Erro: Número inválido.");
                return;
            }

            bool isValidLuhn = IsLuhnValid(cardNumber);
            string brand = GetCardBrand(cardNumber);

            Console.WriteLine($"\nValidade (Luhn): {(isValidLuhn ? "✅ Válido" : "❌ Inválido")}");
            Console.WriteLine($"Bandeira: {brand}\n");
        }

        static bool IsLuhnValid(string number) {
            int sum = 0; bool alt = false;
            for (int i = number.Length - 1; i >= 0; i--) {
                int n = int.Parse(number[i].ToString());
                if (alt) { n *= 2; if (n > 9) n -= 9; }
                sum += n; alt = !alt;
            }
            return (sum % 10 == 0);
        }

        static string GetCardBrand(string number) {
            var brands = new Dictionary<string, string> {
                { "Visa", @"^4[0-9]{12}(?:[0-9]{3})?$" },
                { "Mastercard", @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$" },
                { "Amex", @"^3[47][0-9]{13}$" },
                { "Elo", @"^((4011(78|79))|(431274)|(438935)|(451416)|(457393)|(457631)|(457632)|(504175)|(627780)|(636297)|(636368)|(650031)|(650405)|(650700)|(650901))$" }
            };
            foreach (var b in brands) { if (Regex.IsMatch(number, b.Value)) return b.Key; }
            return "Desconhecida";
        }
    }
}
