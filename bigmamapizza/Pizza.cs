namespace lapizza
{
    public class Pizza
    {
        /*
         * Instans Felter
         */
        private string _størrelse;
        private string _topping;
        private double _pris; // skal være nul eller over
        private string _crust;
        /*
         * Properties
         */
       
        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set {if ( !(value >= 0)) 
                    
                    throw new ArgumentException("Pris skal være nul eller større end nul " + value);
            
                _pris = value; 
            }
        }
        
        public string crust
        {
            get { return _crust; }
            set { _crust = value; }
        }

        public string Størrelse
        {
            get { return _størrelse; }
            set { _størrelse = value; }
        }

        public Pizza() // default
        {
            _crust = "";
            _topping = "";
            _pris = 0;
            _størrelse = "";
        }

        public Pizza(string crust, string topping, double pris, string størrelse)
        {
            _topping = topping;
            _pris = pris;
            _crust = crust;
            _størrelse = størrelse;

            // beregn moms (0.25% of _pris)
            double moms = _pris * 0.25;
            // Leveringsprisen
            double levering = 50;
            // put summen sammen
            _pris += moms + levering;
        }

        public override string ToString()
        {
            string formateredePris = Pris.ToString("0.0");
            return $"{nameof(crust)} = {crust}, {nameof(Topping)} = {Topping}, {nameof(Pris)} = {Pris.ToString()}, {nameof(Størrelse)} = {Størrelse}";
        }
    }
}