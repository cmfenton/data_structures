#pragma once
#include <iostream>
#include <conio.h>
#include <cstdlib>
#include <fstream>
#include <time.h>

using namespace std;

//constant of array size for easy changing of size during testing
const int ARRAY_SIZE = 10;
const int MAX_RANDOM = 10;

///////////////////////
///Custom Exception///
/////////////////////
struct FileOpenException : public exception
{
	const char * what() const throw ()
	{
		return "File Could Not Be Opened or Doesn't Exist";
	}
};

////////////////////////////////////////////
///Print the sorted array to a text file///
//////////////////////////////////////////
void printArray(int *sorted, string sortType)
{
	//save to a text file named after the type of sort used
	string filePath = "C:\\Users\\NSCCSTUDENT\\Desktop\\";
	filePath += sortType;
	filePath += ".txt";

	//try to open the file to print
	try
	{
		ofstream sortFile(filePath, ios::trunc);

		if (sortFile.fail())
		{
			throw FileOpenException();
		}

		//write to file number by number
		for (int i = 0; i < ARRAY_SIZE; i++)
		{
			sortFile << sorted[i];
			if (i != ARRAY_SIZE - 1)
			{
				sortFile << ", ";
			}
		}

		//close the file
		sortFile.close();
	}
	catch (FileOpenException &e)
	{
		cout << "Exception caught" << endl;
		cout << e.what() << endl;
	}
}


//////////////////
///Bubble Sort///
////////////////
void bubbleSort(int *unsorted)
{
	int sorted[ARRAY_SIZE];

	for (int i = 0; i < ARRAY_SIZE; i++)
	{
		sorted[i] = unsorted[i];
	}

	printArray(sorted, "BubbleSort");
}

//////////////////
///Main Method///
////////////////
int main()
{
	//Create array and fill with 100000 random numbers between 0 and 32767

	int unsorted[ARRAY_SIZE] = { 0 };//unsorted array

									 //seed the randomizer
	srand(time(0));

	//fill the array
	for (int i = 0; i < ARRAY_SIZE; i++)
	{
		unsorted[i] = rand() % MAX_RANDOM;
	}

	//Bubble Sort
	bubbleSort(unsorted);

	_getch();
	return 0;
}