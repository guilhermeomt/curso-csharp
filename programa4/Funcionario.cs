    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

       public void aumentarSalario(double porcentagem)
       {
           Salario += Salario * (porcentagem / 100);
       }
    }
