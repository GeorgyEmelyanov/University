#include "AddWindow.h"
using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
int AddWin(cli::array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	ElecZachetBook::AddWindow form;
	Application::Run(% form);
	return 0;
}

