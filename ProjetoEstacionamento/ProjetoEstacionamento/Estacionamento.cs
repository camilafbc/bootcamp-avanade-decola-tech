using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstacionamento
{
    public class Estacionamento
    {
        private decimal _tarifaBase;
        private decimal _valorPorHora;
        public List<string> ListaDeVeiculos = new List<string>();
        
        public decimal TarifaBase
        {
            get => _tarifaBase;

            set => _tarifaBase = value;
        }

        public decimal ValorPorHora
        {
            get => _valorPorHora;

            set => _valorPorHora = value;
        }


        public bool RegistrarVeiculo(string placa, DateTime entrada)
        {
            string veiculoRegistrado = BuscarVeiculo(placa);

            if (veiculoRegistrado == null)
            {
               ListaDeVeiculos.Add($"{placa} - {entrada}");
               return true;
            } else
            {
              return false;
            }
        }

        public decimal ValorAPagar(DateTime entrada, DateTime saida)
        {   
            TimeSpan tempo = saida - entrada;
            double tempoEmHoras = tempo.TotalHours;
            decimal valorAPagar = ((decimal)tempoEmHoras * _valorPorHora) + _tarifaBase;
            return valorAPagar;
        }

        public string BuscarVeiculo(string placa)
        {
            string veiculo = ListaDeVeiculos.Find(item => item.StartsWith(placa));
            return veiculo;
        }

        public List<string> BuscarVeiculos(string placa)
        {
            List<string> veiculos = ListaDeVeiculos.FindAll(item => item.StartsWith(placa));
            return veiculos;
        }

        public bool RemoverVeiculo(string item)
        {
            try
            {
                ListaDeVeiculos.Remove(item);
                return true;
            }catch (Exception)
            {
                return false;
            }
        }
    }
}
