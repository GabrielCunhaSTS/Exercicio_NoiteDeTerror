Console.Clear();

int dia, mes;
string[] mesMonstros = new string[] {
    "O Zumbi",      
    "O Assassino",  
    "O Psicopata",  
    "O Alienígena", 
    "O Carniceiro", 
    "O Matador",    
    "O Vampiro",    
    "O Maluco",     
    "O Vingador",   
    "O Monstro",    
    "O Bruxo",      
    "O Demônio",    
};

string[] diaMonstros = new string[]{
    "Endiabrado",       
    "Radioativo",       
    "Endemoniado",      
    "Vermelho",        
    "Possuído",         
    "Macabro",          
    "Sombrio",          
    "Sem Cabeça",       
    "Desconhecido",     
    "Inconsciente",
    "Oculto",           
    "Esquecido",        
    "Lúgubre",          
    "Invocado",         
    "Caído",            
    "Costurado",        
    "Amaldiçoado",      
    "Anormal",          
    "Perturbado",       
    "Sanguinário",      
    "Tenebroso",        
    "Imortal",          
    "Ressuscitado",     
    "do Pântano",       
    "da Encruzilhada",  
    "do Porão",         
    "do Velho Poço",    
    "sem Perdão",       
    "do Cemitério",     
    "da Meia-Noite",    
    "da Lua Cheia"      
};

Console.WriteLine("------ Bem-vindo(a) ao programa da Noite do Terror ------");

Console.Write("Qual o dia de nascimento da vítima (1 a 31): ");

while (!int.TryParse(Console.ReadLine(), out dia) || dia <= 0 || dia > 31  ){
    Console.Write("Resposta inválida. Tente novamente digitando um número inteiro entre 1 e 31: "); 
}  

Console.Write("Qual o mês de nascimento da vítima (1 a 12): ");

while (!int.TryParse(Console.ReadLine(), out mes) || mes <= 0 || mes > 12){
    Console.Write("Resposta inválida. Tente novamente digitando um número inteiro entre 1 e 12: ");
}

Console.Clear();

if (dia == 29 && mes == 2){
    Console.WriteLine("SORTE! Nenhum monstro correrá atrás de você por ter nascido em um ano bisexto!!");
}
else{
    Console.WriteLine($"CORRA! {mesMonstros[mes - 1]} {diaMonstros[dia - 1]} ESTÁ CORRENDO PARA TE PEGAR!!!\n");
}

Console.Write("\nDigite qualquer tecla para finalizar o programa!");
Console.ReadKey();
Console.Clear();