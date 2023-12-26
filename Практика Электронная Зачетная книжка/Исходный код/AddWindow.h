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
	/// Сводка для AddWindow
	/// </summary>
	public ref class AddWindow : public System::Windows::Forms::Form
	{
	public: DisciplineManager discman;
	public:
		AddWindow(void)
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
		~AddWindow()
		{
			if (components)
			{
				delete components;
			}
		}

	protected:


	private: System::Windows::Forms::TextBox^ AddDisciplineNameTb;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ AddThemesTb;
	private: System::Windows::Forms::ContextMenuStrip^ contextMenuStrip1;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ AddSemesterNumberTb;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::TextBox^ AddRatingTb;
	private: System::Windows::Forms::Label^ label5;

	private: System::Windows::Forms::Button^ AddButton;



	private: System::Windows::Forms::MaskedTextBox^ AddDateOfExamTb;
	private: System::Windows::Forms::Button^ BackButton;


	private: System::ComponentModel::IContainer^ components;

	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			this->AddDisciplineNameTb = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->AddThemesTb = (gcnew System::Windows::Forms::TextBox());
			this->contextMenuStrip1 = (gcnew System::Windows::Forms::ContextMenuStrip(this->components));
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->AddSemesterNumberTb = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->AddRatingTb = (gcnew System::Windows::Forms::TextBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->AddButton = (gcnew System::Windows::Forms::Button());
			this->AddDateOfExamTb = (gcnew System::Windows::Forms::MaskedTextBox());
			this->BackButton = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// AddDisciplineNameTb
			// 
			this->AddDisciplineNameTb->Location = System::Drawing::Point(15, 52);
			this->AddDisciplineNameTb->Name = L"AddDisciplineNameTb";
			this->AddDisciplineNameTb->Size = System::Drawing::Size(153, 22);
			this->AddDisciplineNameTb->TabIndex = 3;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 33);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(156, 16);
			this->label1->TabIndex = 4;
			this->label1->Text = L"Название дисциплины";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(12, 77);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(174, 16);
			this->label2->TabIndex = 6;
			this->label2->Text = L"Перечень изучаемых тем";
			// 
			// AddThemesTb
			// 
			this->AddThemesTb->Location = System::Drawing::Point(15, 96);
			this->AddThemesTb->Name = L"AddThemesTb";
			this->AddThemesTb->Size = System::Drawing::Size(153, 22);
			this->AddThemesTb->TabIndex = 5;
			// 
			// contextMenuStrip1
			// 
			this->contextMenuStrip1->ImageScalingSize = System::Drawing::Size(20, 20);
			this->contextMenuStrip1->Name = L"contextMenuStrip1";
			this->contextMenuStrip1->Size = System::Drawing::Size(61, 4);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(12, 121);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(115, 16);
			this->label3->TabIndex = 9;
			this->label3->Text = L"Номер семестра";
			// 
			// AddSemesterNumberTb
			// 
			this->AddSemesterNumberTb->Location = System::Drawing::Point(15, 140);
			this->AddSemesterNumberTb->Name = L"AddSemesterNumberTb";
			this->AddSemesterNumberTb->Size = System::Drawing::Size(153, 22);
			this->AddSemesterNumberTb->TabIndex = 8;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(12, 165);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(56, 16);
			this->label4->TabIndex = 11;
			this->label4->Text = L"Оценка";
			// 
			// AddRatingTb
			// 
			this->AddRatingTb->Location = System::Drawing::Point(15, 184);
			this->AddRatingTb->Name = L"AddRatingTb";
			this->AddRatingTb->Size = System::Drawing::Size(153, 22);
			this->AddRatingTb->TabIndex = 10;
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(12, 209);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(163, 16);
			this->label5->TabIndex = 13;
			this->label5->Text = L"Дата получения оценки";
			// 
			// AddButton
			// 
			this->AddButton->Location = System::Drawing::Point(249, 52);
			this->AddButton->Name = L"AddButton";
			this->AddButton->Size = System::Drawing::Size(101, 198);
			this->AddButton->TabIndex = 14;
			this->AddButton->Text = L"Добавить";
			this->AddButton->UseVisualStyleBackColor = true;
			this->AddButton->Click += gcnew System::EventHandler(this, &AddWindow::AddButton_Click);
			// 
			// AddDateOfExamTb
			// 
			this->AddDateOfExamTb->Location = System::Drawing::Point(15, 228);
			this->AddDateOfExamTb->Mask = L"00/00/0000";
			this->AddDateOfExamTb->Name = L"AddDateOfExamTb";
			this->AddDateOfExamTb->Size = System::Drawing::Size(153, 22);
			this->AddDateOfExamTb->TabIndex = 15;
			this->AddDateOfExamTb->ValidatingType = System::DateTime::typeid;
			// 
			// BackButton
			// 
			this->BackButton->Location = System::Drawing::Point(249, 256);
			this->BackButton->Name = L"BackButton";
			this->BackButton->Size = System::Drawing::Size(101, 23);
			this->BackButton->TabIndex = 16;
			this->BackButton->Text = L"Назад";
			this->BackButton->UseVisualStyleBackColor = true;
			this->BackButton->Click += gcnew System::EventHandler(this, &AddWindow::BackButton_Click);
			// 
			// AddWindow
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(401, 320);
			this->Controls->Add(this->BackButton);
			this->Controls->Add(this->AddDateOfExamTb);
			this->Controls->Add(this->AddButton);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->AddRatingTb);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->AddSemesterNumberTb);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->AddThemesTb);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->AddDisciplineNameTb);
			this->Name = L"AddWindow";
			this->Text = L"Окно добавления дисциплины";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &AddWindow::AddWindow_FormClosed);
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
	private: System::Void AddWindow_FormClosed(System::Object^ sender, System::Windows::Forms::FormClosedEventArgs^ e)
	{
		if (ElecZachetBook::Application::OpenForms->Count == 0)
			ElecZachetBook::Application::Exit();
		Owner->Show();
	}

	// Кнопка добавления дисциплины. Вызываем обработчик полей, в случае если есть ошибки - открывается окно с ошибкой, иначе поля обрабатываются
	// и идет добавление записи (парсятся поля ввода, создается экземпляр дисциплины и последующее добавление в список).
	private: System::Void AddButton_Click(System::Object^ sender, System::EventArgs^ e)
	{

		if (errorMessage()->Length > 0)
		{
			MessageBox::Show(errorMessage(), "Ошибка заполнения полей!");
		}
		else
		{
			String^ name = AddDisciplineNameTb->Text;
			String^ themes = AddThemesTb->Text;
			int semesterNumber = Int32::Parse(AddSemesterNumberTb->Text);
			float rating = float::Parse(AddRatingTb->Text);
			String^ dateOfExam = AddDateOfExamTb->Text;
			Discipline^ newDiscipline = gcnew Discipline(0, name, themes, semesterNumber, rating, dateOfExam);



			MessageBox::Show("Запись успешно добавлена!");

			AddDisciplineNameTb->Text = "";
			AddThemesTb->Text = "";
			AddSemesterNumberTb->Text = "";
			AddRatingTb->Text = "";
			AddDateOfExamTb->Text = "";

			discman.addDiscipline(newDiscipline);
			discman.toFile("data.txt");
		}
	}

	// Обработчик полей на корректность ввода.
		   String^ errorMessage()
		   {
			   int outInt = -1;
			   float outFloat = -1;
			   bool out = true;
			   String^ error = "";
			   int k = 1;

			   if (AddDisciplineNameTb->Text == "")
			   {
				   error += k.ToString() + ") " + "Дисциплина должна иметь название! \n";
				   k++;
			   }

			   if (AddThemesTb->Text == "")
			   {
				   error += k.ToString() + ") " + "Должны быть заданы темы! \n";
				   k++;
			   }

			   out = Int32::TryParse(AddSemesterNumberTb->Text, outInt);
			   if (outInt <= 0 || outInt > 20 || out == false)
			   {
				   error += k.ToString() + ") " + "Неверно задан номер семетра! (требуется целое значение от 0 до 20) \n";
				   k++;
			   }

			   out = true;
			   out = float::TryParse(AddRatingTb->Text, outFloat);
			   if (outFloat < 0 || outFloat>100 || out == false)
				   error += k.ToString() + ") " + "Неверно задана оценка! (требуется значение от 0 до 100) \n";

			   return error;
		   }
	};
}
