#include "SearchWindow.h"
using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
int SearchWin(cli::array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	ElecZachetBook::SearchWindow form;
	Application::Run(% form);
	return 0;
}

