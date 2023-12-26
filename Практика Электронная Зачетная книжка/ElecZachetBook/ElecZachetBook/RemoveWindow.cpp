#include "RemoveWindow.h"
using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
int RemoveWin(cli::array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	ElecZachetBook::RemoveWindow form;
	Application::Run(% form);
	return 0;
}



