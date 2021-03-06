//---------------------------------------------------------------------------

#ifndef MainWindowH
#define MainWindowH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.Menus.hpp>
//---------------------------------------------------------------------------
class Zoo{
	public:

		int Species;
		int UniqueSpecies;
		void input(int Species, int UniqueSpecies){

			this -> Species = Species;
			this -> UniqueSpecies = UniqueSpecies;
		}
};
//---------------------------------------------------------------------------
class TFormMain : public TForm
{
__published:	// IDE-managed Components
	TMainMenu *MainMenu1;
	TMenuItem *File1;
	TMenuItem *Exit1;
	TMenuItem *Work1;
	TMenuItem *Help1;
	TMenuItem *About1;
	TMenuItem *Input1;
	TMenuItem *Edit1;
	TMenuItem *ask1;
	void __fastcall Exit1Click(TObject *Sender);
	void __fastcall About1Click(TObject *Sender);
	void __fastcall Input1Click(TObject *Sender);
	void __fastcall Edit1Click(TObject *Sender);
	void __fastcall ask1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TFormMain(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TFormMain *FormMain;
//---------------------------------------------------------------------------
#endif
