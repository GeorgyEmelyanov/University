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
	/// Сводка для SearchWindow
	/// </summary>
	public ref class SearchWindow : public System::Windows::Forms::Form
	{
	public: DisciplineManager discman;
	public:
		SearchWindow(void)
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
		~SearchWindow()
		{
			if (components)
			{
				delete components;
			}
		}

	protected:




	private: System::Windows::Forms::ListBox^ SearchByLb;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ SearchTb;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Button^ SearchButton;
	private: System::Windows::Forms::Button^ BackButton;
	private: System::Windows::Forms::ListBox^ SearchLB;

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
			this->SearchByLb = (gcnew System::Windows::Forms::ListBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->SearchTb = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->SearchButton = (gcnew System::Windows::Forms::Button());
			this->BackButton = (gcnew System::Windows::Forms::Button());
			this->SearchLB = (gcnew System::Windows::Forms::ListBox());
			this->SuspendLayout();
			// 
			// SearchByLb
			// 
			this->SearchByLb->FormattingEnabled = true;
			this->SearchByLb->ItemHeight = 16;
			this->SearchByLb->Items->AddRange(gcnew cli::array< System::Object^  >(3) { L"названию дисциплины", L"семетру изучения", L"рейтингу" });
			this->SearchByLb->Location = System::Drawing::Point(12, 53);
			this->SearchByLb->Name = L"SearchByLb";
			this->SearchByLb->Size = System::Drawing::Size(211, 20);
			this->SearchByLb->TabIndex = 8;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(84, 34);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(75, 16);
			this->label1->TabIndex = 9;
			this->label1->Text = L"Искать по ";
			// 
			// SearchTb
			// 
			this->SearchTb->Location = System::Drawing::Point(12, 94);
			this->SearchTb->Name = L"SearchTb";
			this->SearchTb->Size = System::Drawing::Size(211, 22);
			this->SearchTb->TabIndex = 10;
			this->SearchTb->TextChanged += gcnew System::EventHandler(this, &SearchWindow::SearchTb_TextChanged);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(65, 75);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(122, 16);
			this->label2->TabIndex = 11;
			this->label2->Text = L"Параметр поиска";
			// 
			// SearchButton
			// 
			this->SearchButton->Location = System::Drawing::Point(12, 122);
			this->SearchButton->Name = L"SearchButton";
			this->SearchButton->Size = System::Drawing::Size(211, 23);
			this->SearchButton->TabIndex = 12;
			this->SearchButton->Text = L"Искать";
			this->SearchButton->UseVisualStyleBackColor = true;
			this->SearchButton->Click += gcnew System::EventHandler(this, &SearchWindow::SearchButton_Click);
			// 
			// BackButton
			// 
			this->BackButton->Location = System::Drawing::Point(12, 323);
			this->BackButton->Name = L"BackButton";
			this->BackButton->Size = System::Drawing::Size(211, 23);
			this->BackButton->TabIndex = 21;
			this->BackButton->Text = L"Назад";
			this->BackButton->UseVisualStyleBackColor = true;
			this->BackButton->Click += gcnew System::EventHandler(this, &SearchWindow::BackButton_Click);
			// 
			// SearchLB
			// 
			this->SearchLB->FormattingEnabled = true;
			this->SearchLB->ItemHeight = 16;
			this->SearchLB->Location = System::Drawing::Point(12, 153);
			this->SearchLB->Name = L"SearchLB";
			this->SearchLB->Size = System::Drawing::Size(649, 164);
			this->SearchLB->TabIndex = 22;
			// 
			// SearchWindow
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(673, 369);
			this->Controls->Add(this->SearchLB);
			this->Controls->Add(this->BackButton);
			this->Controls->Add(this->SearchButton);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->SearchTb);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->SearchByLb);
			this->Name = L"SearchWindow";
			this->Text = L"Окно поиска";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &SearchWindow::SearchWindow_FormClosed);
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
	private: System::Void SearchWindow_FormClosed(System::Object^ sender, System::Windows::Forms::FormClosedEventArgs^ e)
	{
		if (ElecZachetBook::Application::OpenForms->Count == 0)
			ElecZachetBook::Application::Exit();
		Owner->Show();
	}

	// Кнопка поиска. Поиск записей и дальнейший вывод совпадений в листбокс. Также проверка на выбор параметраю
	private: System::Void SearchButton_Click(System::Object^ sender, System::EventArgs^ e)
	{
		SearchLB->Items->Clear();

		if (SearchByLb->Text == "названию дисциплины")
		{
			System::String^ const name = SearchTb->Text;
			if (name->Length > 0)
			{
				List<Discipline^>^ finded = discman.findByName(name);
				for (int i = 0; i < finded->Count; i++)
				{
					System::String^ out = finded[i]->id_ + ": " + finded[i]->disciplineName_ + " - " + finded[i]->themes_ + " - " + finded[i]->semestrNumber_ + " - " + finded[i]->rating_ + " - " + finded[i]->dateOfExam_;
					SearchLB->Items->Add(out);
				}

				if (SearchLB->Items->Count == 0)
					MessageBox::Show("Таких дисциплин нет в файле!");
			}
			else
				MessageBox::Show("Дисциплина должна иметь название!");
		}
		else if (SearchByLb->Text == "семетру изучения")
		{
			bool outEr = true;
			int semNum = 0;
			outEr = Int32::TryParse(SearchTb->Text, semNum);
			if (outEr == false || semNum < 0 || semNum>20)
			{
				MessageBox::Show("Неверно задан номер семетра! (требуется целое значение от 0 до 20)");
			}
			else
			{
				List<Discipline^>^ finded = discman.findBySemestr(semNum);
				for (int i = 0; i < finded->Count; i++)
				{
					System::String^ out = finded[i]->id_ + ": " + finded[i]->disciplineName_ + " - " + finded[i]->themes_ + " - " + finded[i]->semestrNumber_ + " - " + finded[i]->rating_ + " - " + finded[i]->dateOfExam_;
					SearchLB->Items->Add(out);
				}
				if (SearchLB->Items->Count == 0)
					MessageBox::Show("Таких дисциплин нет в файле!");
			}
		}
		else if (SearchByLb->Text == "рейтингу")
		{
			bool outEr = true;
			float rating = 0;
			outEr = float::TryParse(SearchTb->Text, rating);
			if (outEr == false || rating < 0 || rating>100)
			{
				MessageBox::Show("Неверно задана оценка! (требуется значение от 0 до 100)");
			}
			else
			{
				List<Discipline^>^ finded = discman.findByRating(rating);
				for (int i = 0; i < finded->Count; i++)
				{
					System::String^ out = finded[i]->id_ + ": " + finded[i]->disciplineName_ + " - " + finded[i]->themes_ + " - " + finded[i]->semestrNumber_ + " - " + finded[i]->rating_ + " - " + finded[i]->dateOfExam_;
					SearchLB->Items->Add(out);
				}
				if (SearchLB->Items->Count == 0)
					MessageBox::Show("Таких дисциплин нет в файле!");
			}
		}
		else
		{
			MessageBox::Show("Выберете параметр поиска!");
		}
	}

	// При изменении текста листбокс очищается
	private: System::Void SearchTb_TextChanged(System::Object^ sender, System::EventArgs^ e)
	{
		SearchLB->Items->Clear();
	}
	};
}
