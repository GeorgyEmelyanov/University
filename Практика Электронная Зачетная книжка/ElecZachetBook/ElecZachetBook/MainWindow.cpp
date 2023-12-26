#include "MainWindow.h"
using namespace System;
using namespace System::Windows::Forms;

[STAThreadAttribute]
int MainWin(cli::array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	ElecZachetBook::MainWindow form;
	Application::Run(% form);
	return 0;
}

