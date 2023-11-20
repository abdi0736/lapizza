
namespace lapizza
{
    public  class PizzaListe
    {
        
            // instans felt 
            private List<Pizza> _liste;


            // evt property
            public List<Pizza> Liste 
            { 
                get { return _liste; } 
                set { _liste = value; }
            }

            /*
             * Konstruktør
             */
            public PizzaListe()
            {
                _liste = new List<Pizza>();
            }


            /*
             * Metoder
             */
            
            public void Tilføj(Pizza pizza)
            {
                _liste.Add(pizza);
            }

            public List<Pizza> HentAllePizzas()
            {
                return _liste;
            }
            
            public List<Pizza> HentFraTopping(string topping)
            {
                List<Pizza> resultatListe = new List<Pizza>();

                for (int i = 0; i < _liste.Count; i++)
                {
                    if (_liste[i].Topping == topping)
                    {
                        resultatListe.Add(_liste[i]);
                    }
                }

                return resultatListe; //update
            }

          husk slet funktionen
            }
            
    }
    }
    