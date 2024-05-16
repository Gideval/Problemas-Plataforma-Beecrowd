using System; 

class URI {

    static void Main(string[] args) { 

                string boneStructure = Console.ReadLine();
        string _class = Console.ReadLine();
        string kind = Console.ReadLine();
        string animal;
        
        if(boneStructure == "vertebrado")
        {
            if(_class == "ave")
            {
                if(kind == "carnivoro")
                {
                    animal = "aguia";
                }
                else
                {
                    animal = "pomba";
                }
            }
            else
            {
                if(kind == "onivoro")
                {
                    animal = "homem";
                }
                else
                {
                    animal = "vaca";
                }
            }
        }
        else
        {
            if(_class == "inseto")
            {
                if(kind == "hematofago")
                {
                    animal = "pulga";
                }
                else
                {
                    animal = "lagarta";
                }
            }
            else
            {
                if(kind == "hematofago")
                {
                    animal = "sanguessuga";
                }
                else
                {
                    animal = "minhoca";
                }
            }
        }
        
        Console.WriteLine (animal);

    }

}
