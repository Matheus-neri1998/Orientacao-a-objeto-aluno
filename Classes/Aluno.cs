namespace POO_Celular.Classes // Contexto em que foi criada a pasta
{
    public class Aluno
    {
        public string nome; // Ordem da variável: Assinatura - tipo - atributo
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista;
        public float mediaFinal; 
        public double valorDaMensalidade;
        public void VerMediaFinal(double media) { 
            System.Console.WriteLine($"A média do aluno é: {media}");

        } 
        
        public void VerMensalidade(bool temBolsa, double mensalidade) {
            if (temBolsa == true) {
                System.Console.WriteLine("Esse aluno é bolsista");
                System.Console.WriteLine($"Mensalidade: {mensalidade}");

                System.Console.WriteLine($"Mensalidade com desconto: {0.7 * mensalidade}");

            }else {
                System.Console.WriteLine("Esse aluno NÃO é bolsista");
                System.Console.WriteLine($"Mensalidade: {mensalidade}");
            }
        }
    }   
}