Console.WriteLine("Введите количество элементов массива");
string value = Console.ReadLine();
int size = Convert.ToInt32(value);

int count = 0;
string [] array = new string [size];

string AddMessageToUser(string messageToUser){
    Console.WriteLine(messageToUser);
    string answer = Console.ReadLine();
    if(answer.Length <= 3) count ++;
    return answer;
}
