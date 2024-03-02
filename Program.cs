class Program
{
    static void Main()
    {
        string[] velocidades = Console.ReadLine().Split(' ');
        int vmin = int.Parse(velocidades[0]);
        int vmax = int.Parse(velocidades[1]);

        string comandos = Console.ReadLine();

        Robo robo = new Robo(vmin, vmax);

        foreach (char comando in comandos)
        {
            if (comando == 'A')
            {
                robo.Acelerar();
            }
            else if (comando == 'D')
            {
                robo.Desacelerar();
            }
        }

        Console.WriteLine(robo.VelocidadeAtual);
    }
}
