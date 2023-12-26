#include "DisciplineManager.h"

// �������� ������� ���������
DisciplineManager::DisciplineManager()
{
	disciplines = gcnew List<Discipline^>;
}

// ����� ���������� �� �����: ��������� ����, ��������� ��������� ��������, ������ ������ �� ����������� (';'), ������� ������ ������,
// ����� ��������� ���� ������ � ������. ����� ��� ���� �������, ������� ������ ���������� �� ����� ������ ��������� �������� id.
int DisciplineManager::fromFile(std::string filename)
{
	std::ifstream reader;

	reader.open(filename);
	if (!reader.is_open())
	{
		std::ofstream { "data.txt" };
		return -1;
	}
	else
	{
		std::string str;
		id = 0;
		while (std::getline(reader, str))
		{
			int x = 0;
			id += 1;

			System::String^ disName;
			System::String^ disThem;
			System::String^ date;
			int semNum = 0;
			float rating = 0;

			
			x = str.find_first_of(";") + 1;
			std::string sub = str.substr(0, x - 1);
			disName = gcnew System::String(sub.c_str());
			
			str.erase(0, x + 1);
			
			x = str.find_first_of(";") + 1;
			sub = str.substr(0, x - 1);
			disThem = gcnew System::String(sub.c_str());
			str.erase(0, x + 1);

			x = str.find_first_of(";") + 1;
			sub = str.substr(0, x - 1);
			semNum = std::stoi(sub);
			str.erase(0, x + 1);

			x = str.find_first_of(";") + 1;
			sub = str.substr(0, x - 1);
			rating = std::stof(sub);
			str.erase(0, x + 1);

			date = gcnew System::String(str.c_str());

			Discipline^ nd = gcnew Discipline(id, disName, disThem, semNum, rating, date);
			disciplines->Add(nd);
		}
		reader.close();
		return 0;
	}
}

// ����� ������ � ����: ��������� � �������������� ����. �������� �� ����� ����� � ����� �������� ��������� ������ � ���������� � ������,
// ����� ��� ������ ���������� � ����
int DisciplineManager::toFile(std::string filename)
{
	std::ofstream reader;
	reader.open(filename);
	if (!reader.is_open())
	{
		return -1;
	}
	else
	{
		for (int i = 0; i < disciplines->Count; i++)
		{
			msclr::interop::marshal_context context;
			std::string s; 
			s += context.marshal_as<std::string>(disciplines[i]->disciplineName_);
			s += "; " + context.marshal_as<std::string>(disciplines[i]->themes_);
			s += "; " + context.marshal_as<std::string>(disciplines[i]->semestrNumber_.ToString());
			s += "; " + context.marshal_as<std::string>(disciplines[i]->rating_.ToString());
			s += "; " + context.marshal_as<std::string>(disciplines[i]->dateOfExam_);
			reader << s << std::endl;
		}
	}
	reader.close();
	return 0;
}

// ����� ���������� ������ � ������ ( ����������� id ��� ���������� ������)
int DisciplineManager::addDiscipline(Discipline^ discipline)
{
	id += 1;
	discipline->setId(id);
	disciplines->Add(discipline);

	return 0;
}

// ����� �������� ���������� ( ������� ���� ���������� �� �� id, ��� ������ ����� - ������� � ��������� ���� ������)
void DisciplineManager::deleteDiscipline(int id)
{
	for (int i = 0; i < disciplines->Count; i++)
	{
		if (disciplines[i]->id_ == id)
		{
			disciplines->RemoveAt(i);
			break;
		}
	}
}

// ����� �������������� ���������� ( �� ���� ������ ���������� �������)
void DisciplineManager::editDiscipline( Discipline^ discipline, const int id)
{
	deleteDiscipline(id);
	disciplines->Add(discipline);
}

// ����� ���� ��� ��������� ������, ������� ���������� ������ ���������, ��������� ������� ��������� � ���������.
// ����� �������� �� ����� ����� � ��� ���������� �������� ��������� ��� � ������������ ������.
List<Discipline^>^ DisciplineManager::findByName(System::String^ name)
{
	List<Discipline^>^ finded = gcnew List<Discipline^>;
	for (int i = 0; i < disciplines->Count; i++)
	{
		if (disciplines[i]->disciplineName_ == name)
			finded->Add(disciplines[i]);
	}
	return finded;
}

List<Discipline^>^ DisciplineManager::findBySemestr(int semNum)
{	
	List<Discipline^>^ finded = gcnew List<Discipline^>;
	for (int i = 0; i < disciplines->Count; i++)
	{
		if (disciplines[i]->semestrNumber_ == semNum)
			finded->Add(disciplines[i]);
	}
	return finded;
}

List<Discipline^>^ DisciplineManager::findByRating(float rating)
{
	List<Discipline^>^ finded = gcnew List<Discipline^>;
	for (int i = 0; i < disciplines->Count; i++)
	{
		if (disciplines[i]->rating_ == rating)
			finded->Add(disciplines[i]);
	}
	return finded;
}

