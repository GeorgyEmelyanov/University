#pragma once
#include <string>

ref class Discipline
{
public:
	System::String^ disciplineName_;
	System::String^ themes_;
	int semestrNumber_;
	float rating_;
	System::String^ dateOfExam_;
	int id_;
	Discipline(int id, System::String^ disciplineName, System::String^ themes, int semestrNumber, float rating, System::String^ dateOfExam);
	void setId(int id);
};