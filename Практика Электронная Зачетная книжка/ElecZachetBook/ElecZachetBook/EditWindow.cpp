#include "EditWindow.h"
using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
int EditWin(cli::array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	ElecZachetBook::EditWindow form;
	Application::Run(% form);
	return 0;
}

