int sum_ascii(char string[])
{
    int sum = 0;
    int index = 0;
    char current;
    
    while ((current = string[index++]) != '\0')
    {
        sum += current;
    }
    
    return sum;
}