namespace lapizza
{
    public class KundeKatalog
    {
    
        //konstruktør
        public KundeKatalog()
        {
            _katalog = new Dictionary<int, Kunde>();
        }
        
        //instanst felt
        Dictionary<int, Kunde> _katalog;

        //Propeties
        public Dictionary<int, Kunde> Katalog
        {
            get { return _katalog; }
            set { _katalog = value; }
        }
        
        
        /*
         * metoder
         */
        
        //tilføj kunde
        public Kunde Tilføj(Kunde kunde)
        {
            _katalog.Add(kunde.kundenummer, kunde);

            return kunde;
        }
        
        // hente en kunde udefra 
        public Kunde HentKundeUdFraTlf(string tlf)
        {
            Kunde resKunde = null;
            foreach (Kunde k in _katalog.Values)
            {
                if (k.Tlf==tlf)
                {
                    return k;
                }
            }

            return resKunde;
        }
        
        //slette kunde
        public Kunde Slet(int kundenummer)
        {
            if (_katalog.ContainsKey(kundenummer))
            {
                Kunde slettetKunde = _katalog[kundenummer];
                _katalog.Remove(kundenummer);
                return slettetKunde;
                
            }
            else
            {
                return null;
            }
        }
        
        // opdatere kunde
        public Kunde Opdater(int kundenummer, string nytNavn, string nyTlf)
        {
            if (_katalog.ContainsKey(kundenummer))
            {
                Kunde opdateretKunde = _katalog[kundenummer];
                opdateretKunde.Navn = nytNavn; // Opdater navn
                opdateretKunde.Tlf = nyTlf;    // Opdater telefonnummer
                return opdateretKunde;
            }
            else
            {
                return null; // Kundenummeret findes ikke prøv igen
            }
        }
        
        //hente en kunde
        public Kunde HentKunde(int kundenummer)
        {
            if (_katalog.ContainsKey(kundenummer))
            {
                return _katalog[kundenummer];

            }
            else
            {
                
                // opdaget en fejl
                throw new KeyNotFoundException("kundenummer findes ikke prøv igen");
                //return null;
            }
        }

      
        public override string ToString()
        {
            String tekst = String.Join("], [", _katalog.Values)+"]";
            
            return $"{nameof(Katalog)}= {tekst}";

        }
    }

    }
    