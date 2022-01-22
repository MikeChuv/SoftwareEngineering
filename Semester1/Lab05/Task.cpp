//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Task.h"
#include "MainWindow.h"
//---------------------------------------------------------------------------
#include "map"
#include "list"
#include "algorithm"
#include "iostream"
#include "vector"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TFormTask *FormTask;

extern std::map<AnsiString, Zoo> ZooMap1;
extern std::map<AnsiString, Zoo>::iterator ZooIt1, ZooIt2, ZooIt3;
//---------------------------------------------------------------------------
__fastcall TFormTask::TFormTask(TComponent* Owner)
	: TForm(Owner)
{
	OutputSG -> DefaultColWidth = (int)OutputSG -> Width / 3 - 2;
	OutputSG -> Cells[0][0] = "Зоопарк";
	OutputSG -> Cells[1][0] = "Видов";
	OutputSG -> Cells[2][0] = "Редких";
}
//---------------------------------------------------------------------------
void __fastcall TFormTask::FormClose(TObject *Sender, TCloseAction &Action)
{
    Action = caFree;
}
//---------------------------------------------------------------------------
void __fastcall TFormTask::OKbtnClick(TObject *Sender)
{

	// первый вариант - макс кол-во редких
	if(TaskSelectRG -> ItemIndex == 0){


		// функция для определения максимального
		auto isGreater{
			[]
			(std::pair<const AnsiString, Zoo> el1, std::pair<const AnsiString, Zoo> el2){
				return el1.second.UniqueSpecies < el2.second.UniqueSpecies;
			}
		};
		// max_element - возвращает итератор
		auto maxIt = std::max_element(ZooMap1.begin(), ZooMap1.end(), isGreater);


        // функция для подсчета максимальных
		auto isMax{
			[maxIt]
			(std::pair<const AnsiString, Zoo> el){
				return el.second.UniqueSpecies == maxIt -> second.UniqueSpecies;
			}
		};
		// возвращает int
		auto count = std::count_if(ZooMap1.begin(), ZooMap1.end(), isMax);


		ZooIt2 = ZooMap1.begin();
		OutputSG -> RowCount = count + 1;
		for(int i = 1; ZooIt2 != ZooMap1.end(); ZooIt2++){
			if(ZooIt2 -> second.UniqueSpecies == maxIt -> second.UniqueSpecies){

				OutputSG -> Cells[0][i] = ZooIt2 -> first;
				OutputSG -> Cells[1][i] = IntToStr(ZooIt2 -> second.Species);
				OutputSG -> Cells[2][i] = IntToStr(ZooIt2 -> second.UniqueSpecies);
                i++;
			}
		}


	}

	// второй вариант - доля редких меньше заданного
	if(TaskSelectRG -> ItemIndex == 1){



		float part = StrToFloat(UniquePartEdit -> Text);
		int i = 0;
		OutputSG -> RowCount = 1;
		// пресмотреть лямды, мб поменять параметры на pair
		for_each(ZooMap1.begin(), ZooMap1.end(), [part, this, i](std::pair<const AnsiString, Zoo> el)mutable{
			float iPart = (float)el.second.UniqueSpecies / el.second.Species;
			if(iPart < part){
				OutputSG -> RowCount++;
				i++;
				OutputSG -> Cells[0][i] = el.first;
				OutputSG -> Cells[1][i] = el.second.Species;
				OutputSG -> Cells[2][i] = el.second.UniqueSpecies;

			}
		});



	}
}
//---------------------------------------------------------------------------
