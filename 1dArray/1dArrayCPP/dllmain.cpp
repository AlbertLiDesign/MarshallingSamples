#include<iostream>

using namespace std;

extern "C" __declspec(dllexport)  void Sum(int* a, int b, int length);

void Sum(int* a, int b, int length)
{
    for (int i = 0; i < length; i++)
    {
        a[i] += b;
    }
}
