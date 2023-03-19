int NotContains(int[] array)
{
    int n = array.Length;

    for (int i = 0; i < n; i++)
    {
        if (array[i] <= 0 || array[i] > n)
        {
            array[i] = n + 1;
        }
    }

    for (int i = 0; i < n; i++)
    {
        int idx = Math.Abs(array[i]) - 1;
        if (idx < n && array[idx] > 0)
        {
            array[idx] = -array[idx];
        }
    }

    for (int i = 0; i < n; i++)
    {
        if (array[i] > 0)
        {
            return i + 1;
        }
    }

    return n + 1;
}

