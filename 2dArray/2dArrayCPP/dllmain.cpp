#include<iostream>

using namespace std;

extern "C" __declspec(dllexport)  void Sum(int** a, int b, int m, int n);

void Sum(int** a, int b, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i][j] += b;
        }
    }
}
