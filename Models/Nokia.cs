namespace DesafioPOO.Models
{
    public class Nokia: Smartphone
    {
        public Nokia(string numero): base(numero, "Nokia", "45458784487", 1024)
        {            
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O app {nomeApp} foi instalado no seu Nokia.");
           this.Apps.Add(nomeApp);
        }
    }
   
}