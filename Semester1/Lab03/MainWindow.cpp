//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "MainWindow.h"
#include "About.h"
#include "SelectTask.h"
#include "Proc.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
byte task_num;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
	task_num = 1;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Quit1Click(TObject *Sender)
{
	if(MDIChildCount == 0)
		Close();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::About1Click(TObject *Sender)
{
    AboutBox -> Show();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Dialog1Click(TObject *Sender)
{
	Form2 = new TForm2(this);
    if(task_num == 1) {
		Form2 -> Task_1_RB -> Checked = true;
		Form2 -> Task_2_RB -> Checked = false;
	}
	if(task_num == 2) {
		Form2 -> Task_1_RB -> Checked = false;
		Form2 -> Task_2_RB -> Checked = true;
	}
    Dialog1 -> Enabled = false;
	Form2 -> Show();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Proc1Click(TObject *Sender)
{
    Form3 = new TForm3(this);
	Form3 -> Show();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::ile1Click(TObject *Sender)
{
    Tile();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Cascade1Click(TObject *Sender)
{
    Cascade();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::CloseCurrent1Click(TObject *Sender)
{
    if(ActiveMDIChild != NULL) ActiveMDIChild -> Close();
}
//---------------------------------------------------------------------------
void __fastcall TForm1::CloseAll1Click(TObject *Sender)
{
	for(int i = MDIChildCount - 1; i >=0; i--)
        MDIChildren[i] -> Close();
}
//---------------------------------------------------------------------------
