namespace HelloWorld
{
    class Program
    {
        public bool IsAnagram(string s, string t) {
            for( int i = 0 ; i<s.Length ; i++ ){
                for ( int j =0 ; j<t.Length ; j++ ){
                    if (s[i] == t[j]){
                        break;
                    }
                    else if (j == t.Length-1){
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string string1 = "hellozzw";
            string string2 = "elloh";

        }
    }
}
