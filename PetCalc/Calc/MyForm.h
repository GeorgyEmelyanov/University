#pragma once

namespace Calc {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Сводка для MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
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
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ Xbox;
	protected:

	protected:


	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::ComboBox^ MATbox;


	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ RESbox;

	private: System::Windows::Forms::TextBox^ Ybox;
	private: System::Windows::Forms::TextBox^ Lbox;


	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Button^ button2;


	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->Xbox = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->MATbox = (gcnew System::Windows::Forms::ComboBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->RESbox = (gcnew System::Windows::Forms::TextBox());
			this->Ybox = (gcnew System::Windows::Forms::TextBox());
			this->Lbox = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// Xbox
			// 
			this->Xbox->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->Xbox->Location = System::Drawing::Point(79, 107);
			this->Xbox->Name = L"Xbox";
			this->Xbox->Size = System::Drawing::Size(161, 26);
			this->Xbox->TabIndex = 0;
			// 
			// button1
			// 
			this->button1->BackColor = System::Drawing::SystemColors::ButtonShadow;
			this->button1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Italic, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->button1->Location = System::Drawing::Point(79, 276);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(161, 35);
			this->button1->TabIndex = 1;
			this->button1->Text = L"Рассчет";
			this->button1->UseVisualStyleBackColor = false;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// MATbox
			// 
			this->MATbox->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom));
			this->MATbox->Font = (gcnew System::Drawing::Font(L"qtquickcontrols", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->MATbox->FormattingEnabled = true;
			this->MATbox->Items->AddRange(gcnew cli::array< System::Object^  >(1) { L"Фанера 3мм" });
			this->MATbox->Location = System::Drawing::Point(211, 12);
			this->MATbox->Name = L"MATbox";
			this->MATbox->Size = System::Drawing::Size(104, 25);
			this->MATbox->TabIndex = 2;
			this->MATbox->Text = L"Материал";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(0, 110);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(72, 20);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Высота";
			this->label1->Click += gcnew System::EventHandler(this, &MyForm::label1_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label2->Location = System::Drawing::Point(1, 142);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(73, 20);
			this->label2->TabIndex = 3;
			this->label2->Text = L"Ширина";
			this->label2->Click += gcnew System::EventHandler(this, &MyForm::label1_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label3->Location = System::Drawing::Point(1, 174);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(63, 20);
			this->label3->TabIndex = 3;
			this->label3->Text = L"Длина";
			this->label3->Click += gcnew System::EventHandler(this, &MyForm::label1_Click);
			// 
			// RESbox
			// 
			this->RESbox->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->RESbox->Location = System::Drawing::Point(79, 240);
			this->RESbox->Name = L"RESbox";
			this->RESbox->ReadOnly = true;
			this->RESbox->Size = System::Drawing::Size(161, 31);
			this->RESbox->TabIndex = 0;
			// 
			// Ybox
			// 
			this->Ybox->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->Ybox->Location = System::Drawing::Point(79, 139);
			this->Ybox->Name = L"Ybox";
			this->Ybox->Size = System::Drawing::Size(161, 26);
			this->Ybox->TabIndex = 0;
			// 
			// Lbox
			// 
			this->Lbox->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->Lbox->Location = System::Drawing::Point(79, 171);
			this->Lbox->Name = L"Lbox";
			this->Lbox->Size = System::Drawing::Size(161, 26);
			this->Lbox->TabIndex = 0;
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label4->Location = System::Drawing::Point(99, 217);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(126, 20);
			this->label4->TabIndex = 3;
			this->label4->Text = L"Итого руб/шт:";
			this->label4->Click += gcnew System::EventHandler(this, &MyForm::label1_Click);
			// 
			// button2
			// 
			this->button2->BackColor = System::Drawing::SystemColors::ButtonShadow;
			this->button2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Italic, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->button2->Location = System::Drawing::Point(79, 317);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(161, 35);
			this->button2->TabIndex = 1;
			this->button2->Text = L"Сброс";
			this->button2->UseVisualStyleBackColor = false;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::ActiveBorder;
			this->ClientSize = System::Drawing::Size(327, 366);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->MATbox);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->RESbox);
			this->Controls->Add(this->Lbox);
			this->Controls->Add(this->Ybox);
			this->Controls->Add(this->Xbox);
			this->Name = L"MyForm";
			this->Text = L"Калькулятор";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void label1_Click(System::Object^ sender, System::EventArgs^ e) {}
private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
	double X, Y, L, m, S, res;
	X = System::Convert::ToDouble(Xbox->Text);
	Y = System::Convert::ToDouble(Ybox->Text);
	L = System::Convert::ToDouble(Lbox->Text);
	int kx = 1475 / (X+2);
	int ky = 1475 / (Y+2);
	int k = kx * ky;

	if (MATbox->SelectedItem == "Фанера 3мм") {
		m = 20;
		S = 1331;
		res = (S / k) + m * L/1000;
	}
	else
	{
		MessageBox::Show("Не выбран материал");
	}
	res = System::Math::Round(res, 2);
	RESbox->Text = System::Convert::ToString(res);
}
private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
	Xbox->Text = L"";
	Ybox->Text = L"";
	Lbox->Text = L"";
	RESbox->Text = L"";
}
};
}
