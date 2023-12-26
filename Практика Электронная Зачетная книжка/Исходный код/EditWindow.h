#pragma once

#include "DisciplineManager.h"
#include <msclr\marshal_cppstd.h>

namespace ElecZachetBook {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для EditWindow
	/// </summary>
	public ref class EditWindow : public System::Windows::Forms::Form
	{

	public: DisciplineManager discman;
	private: System::Windows::Forms::MaskedTextBox^ EditDateOfExamTb;
	public:
	public: int editId;
	public:
		EditWindow(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~EditWindow()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::ListBox^ EditLb;
	protected:

	protected:

	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ SearchEditTb;

	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::ListBox^ SearchEditByLb;






	private: System::Windows::Forms::Button^ EditButton;
	private: System::Windows::Forms::Label^ label5;

	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::TextBox^ EditRatingTb;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ EditSemesterNumberTb;
	private: System::Windows::Forms::Label^ label6;
	private: System::Windows::Forms::TextBox^ EditThemesTb;
	private: System::Windows::Forms::Label^ label7;
	private: System::Windows::Forms::TextBox^ EditDisciplineNameTb;
	private: System::Windows::Forms::Button^ BackButton;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->EditLb = (gcnew System::Windows::Forms::ListBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->SearchEditTb = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->SearchEditByLb = (gcnew System::Windows::Forms::ListBox());
			this->EditButton = (gcnew System::Windows::Forms::Button());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->EditRatingTb = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->EditSemesterNumberTb = (gcnew System::Windows::Forms::TextBox());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->EditThemesTb = (gcnew System::Windows::Forms::TextBox());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->EditDisciplineNameTb = (gcnew System::Windows::Forms::TextBox());
			this->BackButton = (gcnew System::Windows::Forms::Button());
			this->EditDateOfExamTb = (gcnew System::Windows::Forms::MaskedTextBox());
			this->SuspendLayout();
			// 
			// EditLb
			// 
			this->EditLb->FormattingEnabled = true;
			this->EditLb->ItemHeight = 16;
			this->EditLb->Location = System::Drawing::Point(45, 121);
			this->EditLb->Name = L"EditLb";
			this->EditLb->Size = System::Drawing::Size(211, 84);
			this->EditLb->TabIndex = 26;
			this->EditLb->SelectedIndexChanged += gcnew System::EventHandler(this, &EditWindow::EditLb_SelectedIndexChanged);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(96, 74);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(122, 16);
			this->label2->TabIndex = 24;
			this->label2->Text = L"Параметр поиска";
			// 
			// SearchEditTb
			// 
			this->SearchEditTb->Location = System::Drawing::Point(45, 93);
			this->SearchEditTb->Name = L"SearchEditTb";
			this->SearchEditTb->Size = System::Drawing::Size(211, 22);
			this->SearchEditTb->TabIndex = 23;
			this->SearchEditTb->TextChanged += gcnew System::EventHandler(this, &EditWindow::SearchEditTb_TextChanged);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(117, 32);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(75, 16);
			this->label1->TabIndex = 22;
			this->label1->Text = L"Искать по ";
			// 
			// SearchEditByLb
			// 
			this->SearchEditByLb->FormattingEnabled = true;
			this->SearchEditByLb->ItemHeight = 16;
			this->SearchEditByLb->Items->AddRange(gcnew cli::array< System::Object^  >(3) {
				L"названию дисциплины", L"семетру изучения",
					L"рейтингу"
			});
			this->SearchEditByLb->Location = System::Drawing::Point(45, 51);
			this->SearchEditByLb->Name = L"SearchEditByLb";
			this->SearchEditByLb->Size = System::Drawing::Size(211, 20);
			this->SearchEditByLb->TabIndex = 21;
			this->SearchEditByLb->SelectedIndexChanged += gcnew System::EventHandler(this, &EditWindow::SearchEditByLb_SelectedIndexChanged);
			// 
			// EditButton
			// 
			this->EditButton->Location = System::Drawing::Point(45, 253);
			this->EditButton->Name = L"EditButton";
			this->EditButton->Size = System::Drawing::Size(370, 24);
			this->EditButton->TabIndex = 37;
			this->EditButton->Text = L"Изменить";
			this->EditButton->UseVisualStyleBackColor = true;
			this->EditButton->Click += gcnew System::EventHandler(this, &EditWindow::EditButton_Click);
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(259, 206);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(163, 16);
			this->label5->TabIndex = 36;
			this->label5->Text = L"Дата получения оценки";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(259, 162);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(56, 16);
			this->label4->TabIndex = 34;
			this->label4->Text = L"Оценка";
			// 
			// EditRatingTb
			// 
			this->EditRatingTb->Location = System::Drawing::Point(262, 181);
			this->EditRatingTb->Name = L"EditRatingTb";
			this->EditRatingTb->Size = System::Drawing::Size(153, 22);
			this->EditRatingTb->TabIndex = 33;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(259, 118);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(115, 16);
			this->label3->TabIndex = 32;
			this->label3->Text = L"Номер семестра";
			// 
			// EditSemesterNumberTb
			// 
			this->EditSemesterNumberTb->Location = System::Drawing::Point(262, 137);
			this->EditSemesterNumberTb->Name = L"EditSemesterNumberTb";
			this->EditSemesterNumberTb->Size = System::Drawing::Size(153, 22);
			this->EditSemesterNumberTb->TabIndex = 31;
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(259, 74);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(174, 16);
			this->label6->TabIndex = 30;
			this->label6->Text = L"Перечень изучаемых тем";
			// 
			// EditThemesTb
			// 
			this->EditThemesTb->Location = System::Drawing::Point(262, 93);
			this->EditThemesTb->Name = L"EditThemesTb";
			this->EditThemesTb->Size = System::Drawing::Size(153, 22);
			this->EditThemesTb->TabIndex = 29;
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(259, 30);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(156, 16);
			this->label7->TabIndex = 28;
			this->label7->Text = L"Название дисциплины";
			// 
			// EditDisciplineNameTb
			// 
			this->EditDisciplineNameTb->Location = System::Drawing::Point(262, 49);
			this->EditDisciplineNameTb->Name = L"EditDisciplineNameTb";
			this->EditDisciplineNameTb->Size = System::Drawing::Size(153, 22);
			this->EditDisciplineNameTb->TabIndex = 27;
			// 
			// BackButton
			// 
			this->BackButton->Location = System::Drawing::Point(120, 283);
			this->BackButton->Name = L"BackButton";
			this->BackButton->Size = System::Drawing::Size(211, 23);
			this->BackButton->TabIndex = 38;
			this->BackButton->Text = L"Назад";
			this->BackButton->UseVisualStyleBackColor = true;
			this->BackButton->Click += gcnew System::EventHandler(this, &EditWindow::BackButton_Click);
			// 
			// EditDateOfExamTb
			// 
			this->EditDateOfExamTb->Location = System::Drawing::Point(262, 225);
			this->EditDateOfExamTb->Mask = L"00/00/0000";
			this->EditDateOfExamTb->Name = L"EditDateOfExamTb";
			this->EditDateOfExamTb->Size = System::Drawing::Size(153, 22);
			this->EditDateOfExamTb->TabIndex = 39;
			this->EditDateOfExamTb->ValidatingType = System::DateTime::typeid;
			// 
			// EditWindow
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(447, 316);
			this->Controls->Add(this->EditDateOfExamTb);
			this->Controls->Add(this->BackButton);
			this->Controls->Add(this->EditButton);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->EditRatingTb);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->EditSemesterNumberTb);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->EditThemesTb);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->EditDisciplineNameTb);
			this->Controls->Add(this->EditLb);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->SearchEditTb);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->SearchEditByLb);
			this->Name = L"EditWindow";
			this->Text = L"Окно изменения";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &EditWindow::EditWindow_FormClosed);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	// Кнопка возвращения (закрытие текущей формы и показ основной)
	private: System::Void BackButton_Click(System::Object^ sender, System::EventArgs^ e)
	{
		Owner->Show();
		this->Close();
	}

	// Проверка на закрытие окна (чтобы не было такого, что все окна закрыты, а программа продолжает работать в фоновом режиме, 
	// и ее по итогу нельзя закрыть, кроме как через диспетчер задач)
	private: System::Void EditWindow_FormClosed(System::Object^ sender, System::Windows::Forms::FormClosedEventArgs^ e)
	{
		if (ElecZachetBook::Application::OpenForms->Count == 0)
			ElecZachetBook::Application::Exit();
		Owner->Show();
	}

	// Кнопка изменения дисциплины. Вызываем обработчик полей, в случае если есть ошибки - открывается окно с ошибкой, иначе поля обрабатываются
	// и идет изменение записи (парсятся поля ввода, создается экземпляр дисциплины и последующее изменение в списке).
	private: System::Void EditButton_Click(System::Object^ sender, System::EventArgs^ e)
	{
		if (errorMessageSave()->Length > 0)
		{
			MessageBox::Show(errorMessageSave(), "Ошибка заполнения полей!");
		}
		else
		{
			String^ disciplineName = EditDisciplineNameTb->Text;
			String^ themes = EditThemesTb->Text;
			int semestrNumber = Int32::Parse(EditSemesterNumberTb->Text);
			float rating = float::Parse(EditRatingTb->Text);
			String^ dateOfExam = EditDateOfExamTb->Text;
			Discipline^ nd = gcnew Discipline(editId, disciplineName, themes, semestrNumber, rating, dateOfExam);
			discman.editDiscipline(nd, editId);
			discman.toFile("data.txt");

			SearchEditTb->Text = "";
			EditLb->Items->Clear();

			MessageBox::Show("Данные изменены!");
		}
	}

	// При изменении параметра поля очищаются.
	private: System::Void SearchEditByLb_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e)
	{
		SearchEditTb->Text = "";
		EditLb->Items->Clear();
	}

	// Поиск записей и дальнейший вывод совпадений в листбокс (обновление при любом изменении текста)
	private: System::Void SearchEditTb_TextChanged(System::Object^ sender, System::EventArgs^ e)
	{
		EditLb->Items->Clear();

		EditDisciplineNameTb->Text = "";
		EditThemesTb->Text = "";
		EditSemesterNumberTb->Text = "";
		EditRatingTb->Text = "";
		EditDateOfExamTb->Text = "";

		if (SearchEditByLb->Text == "названию дисциплины")
		{
			System::String^ const name = SearchEditTb->Text;
			List<Discipline^>^ finded = discman.findByName(name);
			for (int i = 0; i < finded->Count; i++)
			{
				System::String^ out = finded[i]->id_ + ":" + finded[i]->disciplineName_ + "-" + finded[i]->themes_ + "-" + finded[i]->semestrNumber_ + "-" + finded[i]->rating_ + "-" + finded[i]->dateOfExam_;
				EditLb->Items->Add(out);
			}
		}
		else if (SearchEditByLb->Text == "семетру изучения")
		{
			int semNum = 0;
			Int32::TryParse(SearchEditTb->Text, semNum);
			List<Discipline^>^ finded = discman.findBySemestr(semNum);
			for (int i = 0; i < finded->Count; i++)
			{
				System::String^ out = finded[i]->id_ + ":" + finded[i]->disciplineName_ + "-" + finded[i]->themes_ + "-" + finded[i]->semestrNumber_ + "-" + finded[i]->rating_ + "-" + finded[i]->dateOfExam_;
				EditLb->Items->Add(out);
			}
		}
		else if (SearchEditByLb->Text == "рейтингу")
		{
			float rating = 0;
			float::TryParse(SearchEditTb->Text, rating);
			List<Discipline^>^ finded = discman.findByRating(rating);
			for (int i = 0; i < finded->Count; i++)
			{
				System::String^ out = finded[i]->id_ + ":" + finded[i]->disciplineName_ + "-" + finded[i]->themes_ + "-" + finded[i]->semestrNumber_ + "-" + finded[i]->rating_ + "-" + finded[i]->dateOfExam_;
				EditLb->Items->Add(out);
			}
		}
	}

	// Автозаполнение полей при выборе (или изменении) экземпляра записи
	private: System::Void EditLb_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e)
	{
		String^ str = EditLb->SelectedItem->ToString();
		editId = Int32::Parse(str->Split(':')[0]);
		str = str->Split(':')[1];
		String^ editName = str->Split('-')[0];
		String^ editThem = str->Split('-')[1];
		String^ editSem = str->Split('-')[2];
		String^ editRat = str->Split('-')[3];
		String^ editDate = str->Split('-')[4];

		EditDisciplineNameTb->Text = editName;
		EditThemesTb->Text = editThem;
		EditSemesterNumberTb->Text = editSem;
		EditRatingTb->Text = editRat;
		EditDateOfExamTb->Text = editDate;
	}

		   // Обработчик полей на корректность ввода.
		   String^ errorMessageSave()
		   {
			   String^ error = "";
			   if (EditLb->SelectedItems->Count == 0)
			   {
				   error += "Дисциплина не выбрана!";
			   }
			   else
			   {
				   int outInt = -1;
				   float outFloat = -1;
				   bool out = true;
				   int k = 1;

				   if (EditDisciplineNameTb->Text == "")
				   {
					   error += k.ToString() + ") " + "Дисциплина должна иметь название! \n";
					   k++;
				   }

				   if (EditThemesTb->Text == "")
				   {
					   error += k.ToString() + ") " + "Должны быть заданы темы! \n";
					   k++;
				   }

				   out = Int32::TryParse(EditSemesterNumberTb->Text, outInt);
				   if (outInt <= 0 || outInt > 20 || out == false)
				   {
					   error += k.ToString() + ") " + "Неверно задан номер семетра! (требуется целое значение от 0 до 20) \n";
					   k++;
				   }

				   out = true;
				   out = float::TryParse(EditRatingTb->Text, outFloat);
				   if (outFloat < 0 || outFloat>100 || out == false)
					   error += k.ToString() + ") " + "Неверно задана оценка! (требуется значение от 0 до 100) \n";
			   }
			   return error;
		   }
	};
}
