#pragma once

#include "AddWindow.h"
#include "SearchWindow.h"
#include "RemoveWindow.h"
#include "EditWindow.h"
#include "DisciplineManager.h"

namespace ElecZachetBook 
{
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	
	/// <summary>
	/// ������ ��� MainWindow
	/// </summary>
	public ref class MainWindow : public System::Windows::Forms::Form
	{
	public: DisciplineManager discmanMain;
	public:
		MainWindow(void)
		{
			InitializeComponent();
			//
			//TODO: �������� ��� ������������
			//
		}

	protected:
		/// <summary>
		/// ���������� ��� ������������ �������.
		/// </summary>
		~MainWindow()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ AddDiscButton;
	private: System::Windows::Forms::Button^ DeleteDiscButton;
	private: System::Windows::Forms::Button^ ChangeDiscButton;
	private: System::Windows::Forms::Button^ SearchDiscButton;
	protected:

	protected:






	private: System::Windows::Forms::MenuStrip^ menuStrip1;
	private: System::Windows::Forms::ToolStripMenuItem^ �������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ ����������ToolStripMenuItem;
	private: System::Windows::Forms::ToolStripMenuItem^ ��������ToolStripMenuItem;








	private:
		/// <summary>
		/// ������������ ���������� ������������.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// ��������� ����� ��� ��������� ������������ � �� ��������� 
		/// ���������� ����� ������ � ������� ��������� ����.
		/// </summary>
		void InitializeComponent(void)
		{
			this->AddDiscButton = (gcnew System::Windows::Forms::Button());
			this->DeleteDiscButton = (gcnew System::Windows::Forms::Button());
			this->ChangeDiscButton = (gcnew System::Windows::Forms::Button());
			this->SearchDiscButton = (gcnew System::Windows::Forms::Button());
			this->menuStrip1 = (gcnew System::Windows::Forms::MenuStrip());
			this->�������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->����������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->��������ToolStripMenuItem = (gcnew System::Windows::Forms::ToolStripMenuItem());
			this->menuStrip1->SuspendLayout();
			this->SuspendLayout();
			// 
			// AddDiscButton
			// 
			this->AddDiscButton->Location = System::Drawing::Point(80, 31);
			this->AddDiscButton->Name = L"AddDiscButton";
			this->AddDiscButton->Size = System::Drawing::Size(129, 72);
			this->AddDiscButton->TabIndex = 2;
			this->AddDiscButton->Text = L"�������� ����������";
			this->AddDiscButton->UseVisualStyleBackColor = true;
			this->AddDiscButton->Click += gcnew System::EventHandler(this, &MainWindow::AddButton_Click);
			// 
			// DeleteDiscButton
			// 
			this->DeleteDiscButton->Location = System::Drawing::Point(235, 31);
			this->DeleteDiscButton->Name = L"DeleteDiscButton";
			this->DeleteDiscButton->Size = System::Drawing::Size(129, 72);
			this->DeleteDiscButton->TabIndex = 3;
			this->DeleteDiscButton->Text = L"������� ����������";
			this->DeleteDiscButton->UseVisualStyleBackColor = true;
			this->DeleteDiscButton->Click += gcnew System::EventHandler(this, &MainWindow::DeleteButton_Click);
			// 
			// ChangeDiscButton
			// 
			this->ChangeDiscButton->Location = System::Drawing::Point(80, 124);
			this->ChangeDiscButton->Name = L"ChangeDiscButton";
			this->ChangeDiscButton->Size = System::Drawing::Size(129, 72);
			this->ChangeDiscButton->TabIndex = 4;
			this->ChangeDiscButton->Text = L"�������� ����������";
			this->ChangeDiscButton->UseVisualStyleBackColor = true;
			this->ChangeDiscButton->Click += gcnew System::EventHandler(this, &MainWindow::ChangeButton_Click);
			// 
			// SearchDiscButton
			// 
			this->SearchDiscButton->Location = System::Drawing::Point(235, 124);
			this->SearchDiscButton->Name = L"SearchDiscButton";
			this->SearchDiscButton->Size = System::Drawing::Size(129, 72);
			this->SearchDiscButton->TabIndex = 5;
			this->SearchDiscButton->Text = L"����� ����������";
			this->SearchDiscButton->UseVisualStyleBackColor = true;
			this->SearchDiscButton->Click += gcnew System::EventHandler(this, &MainWindow::SearchButton_Click);
			// 
			// menuStrip1
			// 
			this->menuStrip1->ImageScalingSize = System::Drawing::Size(20, 20);
			this->menuStrip1->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(1) { this->�������ToolStripMenuItem });
			this->menuStrip1->Location = System::Drawing::Point(0, 0);
			this->menuStrip1->Name = L"menuStrip1";
			this->menuStrip1->Size = System::Drawing::Size(457, 28);
			this->menuStrip1->TabIndex = 6;
			this->menuStrip1->Text = L"menuStrip1";
			// 
			// �������ToolStripMenuItem
			// 
			this->�������ToolStripMenuItem->DropDownItems->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(2) {
				this->����������ToolStripMenuItem,
					this->��������ToolStripMenuItem
			});
			this->�������ToolStripMenuItem->Name = L"�������ToolStripMenuItem";
			this->�������ToolStripMenuItem->Size = System::Drawing::Size(81, 24);
			this->�������ToolStripMenuItem->Text = L"�������";
			// 
			// ����������ToolStripMenuItem
			// 
			this->����������ToolStripMenuItem->Name = L"����������ToolStripMenuItem";
			this->����������ToolStripMenuItem->Size = System::Drawing::Size(224, 26);
			this->����������ToolStripMenuItem->Text = L"� ���������";
			this->����������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &MainWindow::����������ToolStripMenuItem_Click);
			// 
			// ��������ToolStripMenuItem
			// 
			this->��������ToolStripMenuItem->Name = L"��������ToolStripMenuItem";
			this->��������ToolStripMenuItem->Size = System::Drawing::Size(224, 26);
			this->��������ToolStripMenuItem->Text = L"�� ������";
			this->��������ToolStripMenuItem->Click += gcnew System::EventHandler(this, &MainWindow::��������ToolStripMenuItem_Click);
			// 
			// MainWindow
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(457, 240);
			this->Controls->Add(this->menuStrip1);
			this->Controls->Add(this->SearchDiscButton);
			this->Controls->Add(this->ChangeDiscButton);
			this->Controls->Add(this->DeleteDiscButton);
			this->Controls->Add(this->AddDiscButton);
			this->Name = L"MainWindow";
			this->Text = L"����������� �������� ������ (���)";
			this->FormClosed += gcnew System::Windows::Forms::FormClosedEventHandler(this, &MainWindow::MainWindow_FormClosed);
			this->Load += gcnew System::EventHandler(this, &MainWindow::MainWindow_Load);
			this->menuStrip1->ResumeLayout(false);
			this->menuStrip1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	// ���� ������������ ������ �������� ��� ����. ����� �������� ��������: ������� ��������� ����, �������� � ���� ������ (������ ���������),
	// � ����� id. ��������� �������� ����, ��� ��������, ��������� ��� ���� - ������ ��������.
	private: System::Void AddButton_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		AddWindow^ addwin = gcnew AddWindow();
		(addwin->discman).disciplines = discmanMain.disciplines;
		(addwin->discman).id = discmanMain.id;
		addwin->Owner = this;
		addwin->Show();
		this->Hide();
	}

	private: System::Void SearchButton_Click(System::Object^ sender, System::EventArgs^ e)
	{
		SearchWindow^ searchwin = gcnew SearchWindow();
		(searchwin->discman).disciplines = discmanMain.disciplines;
		(searchwin->discman).id = discmanMain.id;
		searchwin->Owner = this;
		searchwin->Show();
		this->Hide();

	}
	private: System::Void DeleteButton_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		RemoveWindow^ removewin = gcnew RemoveWindow();
		(removewin->discman).disciplines = discmanMain.disciplines;
		(removewin->discman).id = discmanMain.id;
		removewin->Owner = this;
		removewin->Show();
		this->Hide();
	}
	private: System::Void ChangeButton_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		EditWindow^ editwin = gcnew EditWindow();
		(editwin->discman).disciplines = discmanMain.disciplines;
		(editwin->discman).id = discmanMain.id;
		editwin->Owner = this;
		editwin->Show();
		this->Hide();
	}

	private: System::Void MainWindow_Load(System::Object^ sender, System::EventArgs^ e) 
	{
		if (discmanMain.fromFile("data.txt") == -1)
		{
			MessageBox::Show("������ ������ �����!");
		}
	}
	private: System::Void MainWindow_FormClosed(System::Object^ sender, System::Windows::Forms::FormClosedEventArgs^ e)
	{
		if (ElecZachetBook::Application::OpenForms->Count == 0)
			ElecZachetBook::Application::Exit();
	}
private: System::Void ����������ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	MessageBox::Show("������ 1.0");
}
private: System::Void ��������ToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	MessageBox::Show("�����: ��������� �.�.");
}
};
}
