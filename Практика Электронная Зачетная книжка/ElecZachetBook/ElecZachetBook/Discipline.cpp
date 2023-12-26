#include "Discipline.h"

// Задание начальных параметров дисциплины
Discipline::Discipline(int id, System::String^ disciplineName, System::String^ themes, int semestrNumber, float rating, System::String^ dateOfExam)
{
	id_ = id;
	disciplineName_ = disciplineName;
	themes_ = themes;
	semestrNumber_ = semestrNumber;
	rating_ = rating;
	dateOfExam_ = dateOfExam;
}

// Переприсваивание id;
void Discipline::setId(int id)
{
		id_ = id;
}
