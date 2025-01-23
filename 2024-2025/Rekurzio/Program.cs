
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


static void Quick(int[] A, int E, int V)
{
    int K = 0;

    Szetvalogat(ref A, E, V, K);

    if (K - E > 1)
    {
        Quick(A, E, K - 1);
    }

    if (V - K > 1)
    {
        Quick(A, K + 1, V);
    }

}

static void Szetvalogat(ref int[] A,int E,int V,int K)
{
    int X;
    K = E;
    int L = V;
    X = A[K];

    while (K < L)
    {
        while (K < L && A[L] > X)
        {
            L = L - 1;
        }
        if (K < L)
        {
            A[K] = A[L];
            K = K + 1;
            while (K < L && A[K] <= X)
            {
                K++;
            }
            if (K < L)
            {
                A[L] = A[K];
                L = L - 1;
            }
        }
    }
    A[K] = X;
}

int[] tomb = [1, 2, 3,];

Quick(tomb, 0, tomb.Length - 1);