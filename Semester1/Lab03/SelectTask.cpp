//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "SelectTask.h"
#include "MainWindow.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm2 *Form2;
extern byte task_num;
//---------------------------------------------------------------------------
__fastcall TForm2::TForm2(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm2::FormClose(TObject *Sender, TCloseAction &Action)
{
    Form1 -> Dialog1 -> Enabled = true;
    Action = caFree;
}
//---------------------------------------------------------------------------
void __fastcall TForm2::Button2Click(TObject *Sender)
{
    Close();
}
//---------------------------------------------------------------------------
void __fastcall TForm2::Button1Click(TObject *Sender)
{
    if(Task_1_RB -> Checked) task_num = 1;
	if(Task_2_RB -> Checked) task_num = 2;
	Close();
}
//---------------------------------------------------------------------------
