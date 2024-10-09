#pragma once
#include <string>
using namespace std;
class Svic
{
private:
	string portovi[24];
	int i;
public:
	Svic();
	void postaviPort(string mac);
};

