public class Conta
{
    private int agencia;
    private int numero;
    private string nomeCliente;
    private float valorDisponivel;

    public int Agencia
    {
        get { return agencia; }
        set
        {
            if (value.ToString().Length == 4)
            {
                agencia = value;
            }
            else
            {
                throw new ArgumentException("A agência deve conter 4 dígitos.");
            }
        }
    }

    public int Numero
    {
        get { return numero; }
        set
        {
            if (value.ToString().Length == 8)
            {
                numero = value;
            }
            else
            {
                throw new ArgumentException("O número deve conter 8 dígitos.");
            }
        }
    }

    public string NomeCliente
    {
        get { return nomeCliente; }
        set { nomeCliente = value; }
    }

    public float ValorDisponivel
    {
        get { return valorDisponivel; }
        set { valorDisponivel = value; }
    }
}
