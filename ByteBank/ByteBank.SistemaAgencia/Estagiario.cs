using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario,string cpf) : base(salario,cpf)
        {
        }

        public override void AumentarSalario()
        {
            // Qualquer código
        }

        protected override double GetBonificacao()
        {
            throw new System.NotImplementedException();
        }
    }
}
