#include <iostream>
using namespace std;
int main() {
  int n;
  cin >> n;
  int sum;
  for (int i = 0; i < n; i++) {
    int a;
    cin >> a;
    sum += a;
  }
  sum *= 1.08;
  cout << sum << endl;
}
