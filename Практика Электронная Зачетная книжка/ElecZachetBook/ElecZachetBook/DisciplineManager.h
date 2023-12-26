#pragma once
#include "Discipline.h"
#include <list>
#include <fstream>
#include <string>
#include <msclr\marshal_cppstd.h>



using namespace System::Collections::Generic;

ref class DisciplineManager
{
public:
	List<Discipline^>^ disciplines;
	DisciplineManager();
	int id;
	int fromFile(std::string filename);
	int toFile(std::string filename);
	int addDiscipline(Discipline^ discipline);
	void deleteDiscipline(int id);
	void editDiscipline(Discipline^ discipline, const int id);
	List<Discipline^>^ findByName(System::String^ name);
	List<Discipline^>^ findBySemestr(int semNum);
	List<Discipline^>^ findByRating(float rating);
};



