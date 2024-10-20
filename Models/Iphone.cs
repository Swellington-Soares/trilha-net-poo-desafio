namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        public Iphone(string numero): base(numero, "IPhone 5S", "454587844487", 2048){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O app {nomeApp} foi instalado no seu IPhone.");
            this.Apps.Add(nomeApp);
        }
    }
}