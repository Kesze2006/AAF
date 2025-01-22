
static int Fab(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return Fab(n - 1)+Fab(n -2 );
    }
}

for (int i = 0; i < 20; i++)
{
    Console.Write(Fab(i) + " ");
}
Console.WriteLine();


static int Ack(int N, int M)
{
    switch (N)
    {
        case 0: return M + 1; break;
        default: if (N > 0 && M == 0)
            {
                return Ack(N - 1, 1);
            }
            else
            {
                return Ack(N-1,Ack(N,M-1));
            }
    }
}

Console.WriteLine(Ack(4, 0));