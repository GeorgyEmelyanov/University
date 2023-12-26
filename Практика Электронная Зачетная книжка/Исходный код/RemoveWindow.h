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
	/// Сводка для RemoveWindow
	/// </summary>
	public ref class RemoveWindow : public System::Windows::Forms::Form
	{
	public: DisciplineManager discman;
	public:
		RemoveWindow(void)
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
		~RemoveWindow()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ RemoveButton;
	protected:

	protected:
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ SearchRemTb;


	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::ListBox^ SearchRemByLb;







	private: System::Windows::Forms::ListBox^ RemoveLb;
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
			this->RemoveButton = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->SearchRemTb = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->SearchRemByLb = (gcnew System::Windows::Forms::ListBox());
			this->RemoveLb = (gcnew System::Windows::Forms::ListBox());
			this->BackButton = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// RemoveButton
			// 
			this->RemoveButton->Location = System::Drawing::Point(10, 236);
			this->RemoveButton->Name = L"RemoveButton";
			this->RemoveButton->Size = System::Drawing::Size(213, 23);
			this->RemoveButton->TabIndex = 18;
			this->RemoveButton->Text = L"Удалить";
			this->RemoveButton->UseVisualStyleBackColor = true;
			this->RemoveButton->Click += gcnew System::EventHandler(this, &RemoveWindow::RemoveButton_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(61, 51);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(122, 16);
			this->label2->TabIndex = 17;
			this->label2->Text = L"Параметр поиска";
			// 
			// SearchRemTb
			// 
			this->SearchRemTb->Location = System::Drawing::Point(10, 70);
			this->SearchRemTb->Name = L"SearchRemTb";
			this->SearchRemTb->Size = System::Drawing::Size(213, 22);
			this->SearchRemTb->TabIndex = 16;
			this->SearchRemTb->TextChanged += gcnew System::EventHandler(this, &RemoveWindow::SearchRemTb_TextChanged);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(82, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(75, 16);
			this->label1->TabIndex = 15;
			this->label1->Text = L"Искать по ";
			// 
			// SearchRemByLb
			// 
			this->SearchRemByLb->FormattingEnabled = true;
			this->SearchRemByLb->ItemHeight = 16;
			this->SearchRemByLb->Items->AddRange(gcnew cli::array< System::Object^  >(3) {
				L"названию дисциплины", L"семетру изучения",
					L"рейтингу"
			});
			this->SearchRemByLb->Location = System::Drawing::Point(10, 28);
			this->SearchRemByLb->Name = L"SearchRemByLb";
			this->SearchRemByLb->Size = System::Drawing::Size(213, 20);
			this->SearchRemByLb->TabIndex = 14;
			this->SearchRemByLb->SelectedIndexChanged += gcnew System::EventHandler(this, &RemoveWindow::SearchRemByLb_SelectedIndexChanged);
			// 
			// RemoveLb
			// 
			this->RemoveLb->FormattingEnabled = true;
			this->RemoveLb->ItemHeight = 16;
			this->RemoveLb->Location = System::Drawing::Point(10, 98);
			this->RemoveLb->Name = L"RemoveLb";
			this->RemoveLb->Size = System::Drawing::Size(478, 132);
			this->RemoveLb->TabIndex = 19;
			// 
			// BackButton
			// 
			this->BackButton->Location = System::Drawing::Point(10, 265);
			this->BackButton->Name = L"BackButton";
			this->BackButton->Size = System::Drawing::Size(213, 23);
			this->BackButton->TabIndex = 20;
			this->BackButton->Text = L"Назад";
			this->BackButton->UseVisualStyleBackColor = true;
			this->BackButton->Click += gcnew System::EventHandler(this, &RemoveWindow::BackButton_Click);
			// 
			// RemoveWindow
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(502, 297);
			this->Controls->Add(this->BackButton);
			this->Controls->Add(this->RemoveLb);
			this->Controls->Add(this->RemoveButton);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->SearchRemTb);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->SearchRemByLb);
			this->Name = L"RemoveWindow";
			this->Text = L"Окно удаления";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &RemoveWindow::RemoveWindow_FormClosed);
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
	private: System::Void RemoveWindow_FormClosed(System::Object^ sender, System::Windows::Forms::FormClosedEventArgs^ e)
	{
		if (ElecZachetBook::Application::OpenForms->Count == 0)
			ElecZachetBook::Application::Exit();
		Owner->Show();
	}

	// Кнопка удаления. Если дисциплина не выбрана - окно с ошибкой, если выбрана возвращается ее id и дальнейшее удаления из списка.
	private: System::Void RemoveButton_Click(System::Object^ sender, System::EventArgs^ e)
	{
		if (RemoveLb->SelectedItems->Count > 0)
		{
			String^ str = RemoveLb->SelectedItem->ToString()->Split(':')[0];
			int delId = 0;
			delId = Int32::Parse(str);
			discman.deleteDiscipline(delId);
			discman.toFile("data.txt");
			MessageBox::Show("Дисциплина успешно удалена!");
			Owner->Show();
			this->Close();
		}
		else
		{
			MessageBox::Show("Дисциплина не выбрана!");
		}
	}

	// Поиск записей и дальнейший вывод совпадений в листбокс (обновление при любом изменении текста)
	private: System::Void SearchRemTb_TextChanged(System::Object^ sender, System::EventArgs^ e)
	{
		RemoveLb->Items->Clear();

		if (SearchRemByLb->Text == "названию дисциплины")
		{
			System::String^ const name = SearchRemTb->Text;
			List<Discipline^>^ finded = discman.findByName(name);
			for (int i = 0; i < finded->Count; i++)
			{
				System::String^ out = finded[i]->id_ + ": " + finded[i]->disciplineName_ + " - " + finded[i]->themes_ + " - " + finded[i]->semestrNumber_ + " - " + finded[i]->rating_ + " - " + finded[i]->dateOfExam_;
				RemoveLb->Items->Add(out);
			}
		}
		else if (SearchRemByLb->Text == "семетру изучения")
		{
			int semNum = 0;
			Int32::TryParse(SearchRemTb->Text, semNum);
			List<Discipline^>^ finded = discman.findBySemestr(semNum);
			for (int i = 0; i < finded->Count; i++)
			{
				System::String^ out = finded[i]->id_ + ": " + finded[i]->disciplineName_ + " - " + finded[i]->themes_ + " - " + finded[i]->semestrNumber_ + " - " + finded[i]->rating_ + " - " + finded[i]->dateOfExam_;
				RemoveLb->Items->Add(out);
			}
		}
		else
		{
			float rating = 0;
			float::TryParse(SearchRemTb->Text, rating);
			List<Discipline^>^ finded = discman.findByRating(rating);
			for (int i = 0; i < finded->Count; i++)
			{
				System::String^ out = finded[i]->id_ + ": " + finded[i]->disciplineName_ + " - " + finded[i]->themes_ + " - " + finded[i]->semestrNumber_ + " - " + finded[i]->rating_ + " - " + finded[i]->dateOfExam_;
				RemoveLb->Items->Add(out);
			}
		}
	}

	// Очистка полей при изменении параметра поиска.
	private: System::Void SearchRemByLb_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e)
	{
		SearchRemTb->Text = "";
		RemoveLb->Items->Clear();
	}
	};
}
