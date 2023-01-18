namespace Program
{
    class Indexers
    {
        private Dictionary<string, string> _dict;

        public Indexers(){
            _dict = new Dictionary<string, string>();
        }


        public string this[string key]{
            get{
                return _dict[key];
            }
            set{
                _dict[key] = value;
            }
        }
    }
}
