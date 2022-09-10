string[] strings = new string[6] {"Hello", "2", "World", ":-)", "55555", "dom"};

int k = 0;

for(int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        k++;
    }
}

string[] new_strings = new string[k];

int j = 0;
for(int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        new_strings[j] = strings[i];
        j++;
    }
}

//вывод на экран
for(int i = 0; i < new_strings.Length; i++)
{
    Console.WriteLine(new_strings[i]);
}

