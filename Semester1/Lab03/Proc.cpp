//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Proc.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm3 *Form3;
extern byte task_num;
//---------------------------------------------------------------------------
__fastcall TForm3::TForm3(TComponent* Owner)
	: TForm(Owner)
{
    if(task_num == 1)
		Task_name -> Caption = "����������, ����� �� ���������� ������������� � ������������� ����� � ������ ������.";
	if(task_num == 2)
		Task_name -> Caption = "������������ ���������� ������ �� ���� ������������� ��������� � ������ ������.";
}
//---------------------------------------------------------------------------
void __fastcall TForm3::FormClose(TObject *Sender, TCloseAction &Action)
{
    Action = caFree;
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Rows_editChange(TObject *Sender)
{
	int n;
	if(Rows_edit -> Text != "" && Rows_edit -> Text != "Rows"){
		n = StrToInt(Rows_edit -> Text);
	}
	if(n < 2) n = 2;
	SG1 -> RowCount = n;
	SG2 -> RowCount = n;
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Colls_editChange(TObject *Sender)
{
    int n;
	if(Colls_edit -> Text != "" && Colls_edit -> Text != "Colls"){
		n = StrToInt(Colls_edit -> Text);
	}
	if(n < 2) n = 2;
	SG1 -> ColCount = n;
}
//---------------------------------------------------------------------------
void __fastcall TForm3::Button1Click(TObject *Sender)
{
    if(task_num == 1){
		//����������, ����� �� ���������� ������������� � ������������� ����� � ������ ������.

		for (int i = 0; i < SG1 -> RowCount; i++) {
			int count_pos = 0;
			int count_neg = 0;
			for(int j = 0; j < SG1 -> ColCount; j++){
				if(SG1 -> Cells[j][i] > 0) count_pos++;
				if(SG1 -> Cells[j][i] < 0) count_neg++;
			}
			if (count_pos == count_neg) {
				SG2 -> Cells[0][i] = "True";
			}
			else{SG2 -> Cells[0][i] = "False";}
		}
	}
	if(task_num == 2){
		//������������ ���������� ������ �� ���� ������������� ��������� � ������ ������.
		for (int i = 0; i < SG1 -> RowCount; i++) {
			int sum = 0;
			for(int j = 0; j < SG1 -> ColCount; j++){
				if(SG1 -> Cells[j][i] < 0) sum += StrToInt(SG1 -> Cells[j][i]);
			}
			SG2 -> Cells[0][i] = sum;
		}

	}
}
//---------------------------------------------------------------------------