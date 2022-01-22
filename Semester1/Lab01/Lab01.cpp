//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Lab01.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
//	for(int i = 1; i < SG1 -> ColCount; i++)
//		SG1 -> Cells[i][0] = i;
//	for(int i = 1; i < SG1 -> RowCount; i++)
//		SG1 -> Cells[0][i] = i;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::CollsEditChange(TObject *Sender)
{
	int k;
	if (CollsEdit -> Text != "") {
		k = StrToInt(CollsEdit -> Text);
		if (k < 2) {
			k = 2;
		}
		SG1 -> ColCount = k;
//		for(int i = 1; i < SG1 -> ColCount; i++)
//			SG1 -> Cells[i][0] = i;
	}


}
//---------------------------------------------------------------------------
void __fastcall TForm1::RowsEditChange(TObject *Sender)
{
	int k;
	if (RowsEdit -> Text != "") {
		k = StrToInt(RowsEdit -> Text);
		if (k < 2) {
			k = 2;
		}
		SG1 -> RowCount = k;
//		for(int i = 1; i < SG1 -> RowCount; i++)
//			SG1 -> Cells[0][i] = i;
	}
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
	int kol = 0;
	float x, sum = 0;

	float max = StrToFloat(SG1 -> Cells[0][0]);
	float min = max;

	for(int i = 0; i < SG1 -> ColCount; i++){
		for(int j = 0; j < SG1 -> RowCount; j++){
			x = StrToFloat(SG1 -> Cells[i][j]);
			if(x > max) max = x;
			if(x < min) min = x;
		}
	}

	MaxVal -> Caption = max;
	MinVal -> Caption = min;

	for(int i = 0; i < SG1 -> ColCount; i++){
		for(int j = 0; j < SG1 -> RowCount; j++){
			x = StrToFloat(SG1 -> Cells[i][j]);
			sum += x;
			kol++;
		}
	}

	if(kol == 0){
		Out1 -> Caption = "NO";
	}
	else{
		x = sum / kol;
		Out1 -> Caption = x;
		// TODO: �������� �������� �� ������� ����� ��� � 10 ���

		if (max / min > 10) {
			for(int i = 0; i < SG1 -> ColCount; i++){
				for(int j = 0; j < SG1 -> RowCount; j++){
					float val = StrToFloat(SG1 -> Cells[i][j]);
					SG1 -> Cells[i][j] = val - x;
				}
			}
		}
	}


}
//---------------------------------------------------------------------------
